using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Helper
{
    public class IpEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        /// <summary>
        /// ip
        /// </summary>
        public string IpAddress { get; set; }

        public string SpareIpAddress { get; set; }
        /// <summary>
        /// 子网掩码
        /// </summary>
        public string SubnetMask { get; set; } 

        public string SpareSubnetMask { get; set; }
        /// <summary>
        /// 网关
        /// </summary>
        public string Gateway { get; set; } 

        public string SpareGateway { get; set; }

        /// <summary>
        /// DNS
        /// </summary>
        public string DNS { get; set; } //= "114.114.114.114";

        public string SpareDNS { get; set; } //= "8.8.8.8";

    }

    public class XmlConfig
    {
        public IEnumerable< IpEntity> Items { get; set; }

    }

    public static class IpSwitchHelper
    {
        private  const string fileName = @"Config.ipswitch";
        public static void SvaeConfig(XmlConfig items)
        {

        }
        public static void AddConfig(IpEntity model)
        {

        }

        
        public static XmlConfig LoadItems()
        {
            string xml = string.Empty;
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    xml=sr.ReadToEnd();
                }
            }
            XmlConfig res = null;
            if (string.IsNullOrEmpty(xml))
            {
                res= new XmlConfig {Items=new List<IpEntity>() };
            }
            else
            {
                try
                {
                    res= XmlHelper.Deserialize<XmlConfig>(xml);
                }
                catch (Exception e)
                {
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }
                    res = new XmlConfig { Items = new List<IpEntity>() };
                }
            }
            return res;
        }

        public static IpEntity CreateDefault()
        {
            return new IpEntity
            {   
                DNS="114.114.114.114",
                SpareDNS="8.8.8.8",
            };
        }

        public static bool IsIpAddress(string ip)
        {
            const string pattern = @"((?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d))))";
            return Regex.IsMatch(ip, pattern);
        }

        /// <summary>
        /// 组装ip 
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="spareIp"></param>
        /// <returns></returns>
        public static string[] GetIps(string ip, string spareIp)
        {
            if (string.IsNullOrEmpty(ip)) return null;
            if (string.IsNullOrEmpty(spareIp)) { return new string[] { ip }; }
            return new string[] { ip, spareIp };
        }

        /// <summary>
        /// 检查ip 以及备用 ip
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="spareIp"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool CheckIps(string ip, string spareIp, ref string msg)
        {
            if (!IsIpAddress(ip))
            {
                msg += "格式不正确！";
                return false;
            }
            if (!string.IsNullOrEmpty(spareIp))
            {
                if (!IsIpAddress(spareIp))
                {
                    msg += "格式不正确！";
                    msg = "备用" + msg;
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 检查实体格式对不对
        /// </summary>
        /// <param name="model"></param>
        /// <param name="isPass"></param>
        /// <returns></returns>
        public static string CheckIpEntity(IpEntity model, ref bool isPass)
        {
            isPass = true;
            var res = string.Empty;
            var msg = "IP地址";
            if ((!string.IsNullOrEmpty( model.IpAddress))&&!CheckIps(model.IpAddress, model.SpareIpAddress, ref msg))
            {
                isPass = false;
                return msg;
            }
            msg = "子网掩码";
            if ((!string.IsNullOrEmpty(model.SubnetMask)) && !CheckIps(model.SubnetMask, model.SpareSubnetMask, ref msg))
            {
                isPass = false;
                return msg;
            }
            msg = "网关";
            if ((!string.IsNullOrEmpty(model.Gateway)) && !CheckIps(model.Gateway, model.SpareGateway, ref msg))
            {
                isPass = false;
                return msg;
            }
            msg = "DNS";
            if ((!string.IsNullOrEmpty(model.DNS)) && !CheckIps(model.DNS, model.SpareDNS, ref msg))
            {
                isPass = false;
                return msg;
            }
            return string.Empty;
        }

        public static string GetInvokeMethodMsg(object thisResult, string pre)
        {
            int re = -1;
            if (int.TryParse(thisResult.ToString(), out re))
            {
                if (re != 1 && re != 0)
                {
                    return string.Format("修改{0}失败，错误代码：{1}!", pre,re);
                }
                return "";
            }
            return string.Format("修改{0}失败，错误代码：{1}!", pre, thisResult.ToString());
        }

        public static string SetNetworkAdapter(IpEntity model)
        {
            var res = string.Empty;
            var isPass = true;
            res = CheckIpEntity(model, ref isPass);
            if (!isPass)
            {
                return res;
            }
            ManagementBaseObject inPar = null;
            ManagementBaseObject outPar = null;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (!(bool)mo["IPEnabled"]) { continue; }
                foreach(PropertyData pd in mo.Properties)
                {
                    var ob = mo.GetPropertyValue(pd.Name);
                    res += (Environment.NewLine + pd.Name + ":" + mo.GetPropertyValue(pd.Name));
                }
                try
                {
                    string[] ips=null;
                    //设置ip地址和子网掩码 
                    ips = GetIps(model.IpAddress, model.SpareIpAddress);
                    if (ips != null)
                    {
                        inPar = mo.GetMethodParameters("EnableStatic");
                        inPar.SetPropertyValue("IPAddress", ips);
                        var subnet = GetIps(model.SubnetMask, model.SpareSubnetMask);
                        inPar.SetPropertyValue("SubnetMask", subnet); // 1.备用 2.IP
                        outPar = mo.InvokeMethod("EnableStatic", inPar, null);
                        res = GetInvokeMethodMsg(outPar.GetPropertyValue("ReturnValue"),"IP或子网掩码");
                    }

                    //设置网关地址 
                    ips = GetIps(model.Gateway, model.SpareGateway);
                    if (ips != null)
                    {
                        inPar = mo.GetMethodParameters("SetGateways");
                        inPar["DefaultIPGateway"] = ips;// 1.网关;2.备用网关 
                        outPar = mo.InvokeMethod("SetGateways", inPar, null);
                        res += GetInvokeMethodMsg(outPar.GetPropertyValue("ReturnValue"), "网关");
                    }

                    //设置DNS 
                    ips = GetIps(model.DNS, model.SpareDNS);
                    if (ips != null)
                    {
                        inPar = mo.GetMethodParameters("SetDNSServerSearchOrder");
                        inPar["DNSServerSearchOrder"] = ips; // 1.DNS 2.备用DNS 
                        outPar = mo.InvokeMethod("SetDNSServerSearchOrder", inPar, null);
                        res += GetInvokeMethodMsg(outPar.GetPropertyValue("ReturnValue"), "DNS");
                    }
                    res +=(Environment.NewLine+ "ok");
                }
                catch (Exception e)
                {
                    res = e.Message;
                    break;
                }
                break;
            }
            return res;
        }
    }
}
