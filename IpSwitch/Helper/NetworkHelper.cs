using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Collections;
using System.Net.NetworkInformation;
using System.Linq;

namespace IpSwitch.Helper
{
    public class NetworkHelper
    {
        /// <summary>
        /// 网卡列表
        /// </summary>
        public static List<NetworkInterface> NetWorkList()
        {
            var ls = NetworkInterface.GetAllNetworkInterfaces().Where(a => a.NetworkInterfaceType == NetworkInterfaceType.Ethernet).Select(a => a).ToList();
            return ls;

            //string manage = "SELECT * From Win32_NetworkAdapter WHERE MACAddress IS NOT NULL";
            //ManagementObjectSearcher searcher = new ManagementObjectSearcher(manage);
            //ManagementObjectCollection collection = searcher.Get();
            //List<string> netWorkList = new List<string>();
            //foreach (ManagementObject obj in collection)
            //{
            //    netWorkList.Add(obj["Name"].ToString());

            //}
            //return netWorkList;

        }

        /// <summary>
        /// 禁用网卡
        /// </summary>5
        /// <param name="netWorkName">网卡名</param>
        /// <returns></returns>
        public static bool DisableNetWork(ManagementObject network)
        {
            var res = network.InvokeMethod("Disable", null);
            return true;
        }

        /// <summary>
        /// 启用网卡
        /// </summary>
        /// <param name="netWorkName">网卡名</param>
        /// <returns></returns>
        public static bool EnableNetWork(ManagementObject network)
        {
            var res = network.InvokeMethod("Enable", null);
            return true;
        }

        /// <summary>
        /// 网卡状态
        /// </summary>
        /// <param name="netWorkName">网卡名</param>
        /// <returns></returns>
        public bool GetNetworkState(string netWorkName)
        {
            string netState = "SELECT * From Win32_NetworkAdapter";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(netState);
            ManagementObjectCollection collection = searcher.Get();
            foreach (ManagementObject manage in collection)
            {
                if (manage["Name"].ToString() == netWorkName)
                {
                    return (bool)manage["IPEnabled"];
                }
            }
            return false;
        }

        /// <summary>
        /// 得到指定网卡
        /// </summary>
        /// <param name="networkname">网卡名字</param>
        /// <returns></returns>
        public ManagementObject GetNetwork(string networkname)
        {
            string netState = "SELECT * From Win32_NetworkAdapter ";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(netState);
            ManagementObjectCollection collection = searcher.Get();

            foreach (ManagementObject manage in collection)
            {
                if (manage["Name"].ToString() == networkname)
                {
                    return manage;
                }
            }
            return null;
        }
    }
}
