using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public string Name { get; set; } = Guid.NewGuid().ToString("N");

        /// <summary>
        ///网卡名称 
        /// </summary>
        public string NetworkName { get; set; }

        /// <summary>
        /// mac 地址
        /// </summary>
        public string MACAddress { get; set; }

        /// <summary>
        /// 网卡id
        /// </summary>
        public string NetworkID { get; set; }
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
        public string DNS { get; set; } = "114.114.114.114";

        public string SpareDNS { get; set; } = "8.8.8.8";

    }

    /// <summary>
    /// 配置
    /// </summary>
    public class XmlConfig
    {
        public List<IpEntity> Items { get; set; }

    }

    public static class IpSwitchHelper
    {
        private  const string fileName = @"Config.ipswitch";

        /// <summary>
        /// 保存实体
        /// </summary>
        /// <param name="xmlConfig"></param>
        /// <returns></returns>
        public static string SaveConfig(XmlConfig xmlConfig)
        {
            var msg = "Ok";
            var xml = string.Empty;
            try
            {
                xml = XmlHelper.Serializer(xmlConfig);
                File.WriteAllText(fileName, xml, Encoding.UTF8);
            }
            catch (Exception e)
            {
                msg=e.Message;
            }
            return msg;
        }

        public static string UpdateConfig(IpEntity model)
        {
            bool isPass = true;
            var msg = CheckIpEntity(model, ref isPass);
            if (!isPass) { return msg; }
            XmlConfig xmlConfig = LoadItems();
            var index = xmlConfig.Items.FindIndex(a => a.Id.Equals(model.Id));
            if (index < 0 || index > xmlConfig.Items.Count)
            {
                return "更新失败";
            }
            xmlConfig.Items[index] = model;
            return SaveConfig(xmlConfig);
        }

        public static string DeleteConfig(IpEntity model)
        {
            XmlConfig xmlConfig = LoadItems();
            xmlConfig.Items.RemoveAll(a=>a.Id.Equals(model.Id));
            return SaveConfig(xmlConfig);
        }

        /// <summary>
        /// 添加一个实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string AddConfig(IpEntity model)
        {
            bool isPass = true;
            var msg= CheckIpEntity(model, ref isPass);
            if (!isPass) { return msg; }
            XmlConfig xmlConfig = LoadItems();
            xmlConfig.Items.Add(model);
            return SaveConfig(xmlConfig);
        }


        public static IpEntity FindById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return default(IpEntity);
            }
            return LoadItems().Items.Where(a => a.Id.Equals(id)).FirstOrDefault();
        }
        
        /// <summary>
        /// 从文件载入配置
        /// </summary>
        /// <returns></returns>
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
                return new XmlConfig { Items = new List<IpEntity> () };
            }
            try
            {
                res = XmlHelper.Deserialize<XmlConfig>(xml);
            }
            catch (Exception)
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                res =  new XmlConfig { Items = new List<IpEntity>() };
            }
            return res;
        }

        public static IpEntity CreateDefault( string networkId)
        {
            var model= new IpEntity
            {   
                DNS="114.114.114.114",
                SpareDNS="8.8.8.8",
                NetworkID= networkId
            };
           // ManagementClass mc =new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = new ManagementObjectSearcher("select * from  Win32_NetworkAdapterConfiguration where MACAddress is not null").Get();
            foreach (ManagementObject mo in moc)
            {
                if (!(string.IsNullOrEmpty(model.NetworkID)) && (string)mo["SettingID"] != model.NetworkID)
                {
                    continue;
                }
                if (string.IsNullOrEmpty(model.NetworkID)&& (!(bool)mo["IPEnabled"])){
                    continue;
                }
                string[] ips =(string[]) mo["DefaultIPGateway"];
                model.Gateway = ips.Length > 0 ? ips[0] : "";
                ips = (string[])mo["DNSServerSearchOrder"];
                model.DNS = ips.Length > 0 ? ips[0] : model.DNS;
                ips = (string[])mo["IPAddress"];
                model.IpAddress= ips.Length > 0 ? ips[0] :"";
                ips = (string[])mo["IPSubnet"];
                model.SubnetMask = ips.Length > 0 ? ips[0] : "";
                break;
            }
            return model;
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
            if (string.IsNullOrEmpty(ip)) { return null; }
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
            if(string.IsNullOrEmpty(model.Name))
            {
                isPass = false;
                return "方案名称不能为空！";
            }
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

        public static string GetInvokeMethodMsg(object thisResult, string pre,ref bool isOk)
        {
            int re = -1;
            if (int.TryParse(thisResult.ToString(), out re))
            {
                if (re != 1 && re != 0)
                {
                    isOk = false;
                    return string.Format("修改{0}失败，错误代码：{1}!", pre,re);
                }
                return "";
            }
            isOk = false;
            return string.Format("修改{0}失败，错误代码：{1}!", pre, thisResult.ToString());
        }

        public static string SetNetworkAdapter(IpEntity model,ref bool isOk)
        {
            var res = string.Empty;
            var isPass = true;
            isOk = true;
            res = CheckIpEntity(model, ref isPass);
            if (!isPass)
            {
                isOk = false;
                return res;
            }
      
            ManagementBaseObject inPar = null;
            ManagementBaseObject outPar = null;
            ManagementObjectCollection moc =new ManagementObjectSearcher("Select  * from Win32_NetworkAdapterConfiguration where MACAddress is not null and SettingID='"+model.NetworkID+"'").Get();
            if (string.IsNullOrEmpty(model.NetworkID)&& moc.Count<=0)
            {
                isOk = false;
                return "找不到指定网卡";
            }
            foreach (ManagementObject mo in moc)
            {
                if((string)mo["SettingID"]!= model.NetworkID)
                {
                    isOk = false;
                    res+="找不到指定网卡";
                    continue;
                }
                //启用网卡
                if ((!(bool)mo["IPEnabled"])&&(!IpSwitch.Helper.NetworkHelper.EnableNetWork(mo))) {
                    isOk = false;
                    return "网卡启用失败";
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
                        res = GetInvokeMethodMsg(outPar.GetPropertyValue("ReturnValue"),"IP或子网掩码",ref isOk);
                    }

                    //设置网关地址 
                    ips = GetIps(model.Gateway, model.SpareGateway);
                    if (ips != null)
                    {
                        inPar = mo.GetMethodParameters("SetGateways");
                        inPar["DefaultIPGateway"] = ips;// 1.网关;2.备用网关 
                        outPar = mo.InvokeMethod("SetGateways", inPar, null);
                        res += GetInvokeMethodMsg(outPar.GetPropertyValue("ReturnValue"), "网关", ref isOk);
                    }

                    //设置DNS 
                    ips = GetIps(model.DNS, model.SpareDNS);
                    if (ips != null)
                    {
                        inPar = mo.GetMethodParameters("SetDNSServerSearchOrder");
                        inPar["DNSServerSearchOrder"] = ips; // 1.DNS 2.备用DNS 
                        outPar = mo.InvokeMethod("SetDNSServerSearchOrder", inPar, null);
                        res += GetInvokeMethodMsg(outPar.GetPropertyValue("ReturnValue"), "DNS", ref isOk);
                    }
                    res=string.IsNullOrEmpty(res)?"OK!":res+ (Environment.NewLine + "Ok!");
                }
                catch (Exception e)
                {
                    res += e.Message;
                    isOk = false;
                }
                break;
            }
            return res;
        }
    }
}
