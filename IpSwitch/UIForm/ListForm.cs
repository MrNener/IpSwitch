using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Helper;
using Microsoft.Win32;
using IpSwitch.Properties;

namespace IpSwitch.UIForm
{
    public partial class ListForm : Form
    {
        private static string version = "v1.0.5";

        private static bool isAuto = false;



        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            Settings set = new Settings();
            isAuto = set.isAutoStart;
            autoStartCB.Checked = set.isAutoStart;
            formNotifyIcon.Visible = true;
            LoadConfig();
            LoadItem(itemsComboBox.SelectedValue?.ToString());
            GetNowStatus(IpSwitchHelper.LoadItems());
        }

        /// <summary>
        /// 装载配置
        /// </summary>
        public void LoadConfig()
        {
            ipMaskedTextBox.Text = "";
            subnetMaskedTextBox.Text = "";
            gateMaskedTextBox.Text = "";
            dnsMaskedTextBox.Text = "";

            itemsComboBox.DataSource = null;
            itemsComboBox.Items.Clear();
            var ls = IpSwitchHelper.LoadItems();
            if (ls.Items.Count <= 0) { return; }
            itemsComboBox.DataSource = ls.Items;
            itemsComboBox.DisplayMember = "Name";
            itemsComboBox.ValueMember = "Id";

            formNotifyIcon.ContextMenuStrip = null;
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("当前：...");
            menu.Items.Add(new ToolStripSeparator());
            int c = 0;
            foreach (var item in ls.Items)
            {
                if (c >= 5)
                {
                    menu.Items.Add("更多...", null, (object s, EventArgs ea) =>
                    {
                        WindowState = FormWindowState.Normal;
                    });
                    break;
                }
                menu.Items.Add(item.Name, null, (object s, EventArgs ea) =>
                {
                    var model = IpSwitchHelper.FindById(item.Id);
                    var isOk = true;
                    MessageBox.Show(IpSwitchHelper.SetNetworkAdapter(model,ref isOk), "IpSwitch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (isOk)
                    {
                        GetNowStatus(null, model);
                    }
                });
            }
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add("关于", null, (object s, EventArgs ea) => { MessageBox.Show(":-)"+Environment.NewLine+ version, ":-)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); });
            menu.Items.Add("退出", null, (object s, EventArgs ea) => { Close(); Dispose(); Application.Exit(); });
            formNotifyIcon.ContextMenuStrip = menu;
        }

        /// <summary>
        /// 获取当前配置项
        /// </summary>
        /// <param name="ls"></param>
        /// <param name="addModel"></param>
        private void GetNowStatus(XmlConfig ls,IpEntity addModel=null)
        {
            var status = string.Empty;
            var defaultModel = IpSwitchHelper.CreateDefault();
            var nowModel = addModel!=null&&addModel!=default(IpEntity)? addModel: ls.Items.Where(a => a.IpAddress.Equals(defaultModel.IpAddress) && a.DNS.Equals(defaultModel.DNS) && a.SubnetMask.Equals(defaultModel.SubnetMask) && a.Gateway.Equals(defaultModel.Gateway)).FirstOrDefault();
            if (nowModel!=default(IpEntity))
            {
                status = nowModel.Name;
                for (int i = 0; i < itemsComboBox.Items.Count; i++)
                {
                    var ipEntity = (IpEntity)itemsComboBox.Items[i];
                    if (ipEntity.Id.Equals(nowModel.Id))
                    {
                        itemsComboBox.SelectedIndex = i;
                    }
                }
                formNotifyIcon.ContextMenuStrip.Items.RemoveAt(0);
                formNotifyIcon.ContextMenuStrip.Items.Insert(0,new ToolStripMenuItem("当前："+status));
            }
            statusLabel.Text = status;
        }

        /// <summary>
        /// 单个item 显示到界面上
        /// </summary>
        /// <param name="id"></param>
        public void LoadItem(string id)
        {
            var model = IpSwitchHelper.LoadItems().Items.Where(a => a.Id.Equals(id)).FirstOrDefault();
            if (model == default(IpEntity)) { return; }
            ipMaskedTextBox.Text = model.IpAddress;
            subnetMaskedTextBox.Text = model.SubnetMask;
            gateMaskedTextBox.Text = model.Gateway;
            dnsMaskedTextBox.Text = model.DNS;
        }
        private void itemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItem(itemsComboBox.SelectedValue?.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = itemsComboBox.SelectedValue?.ToString();
            var model = IpSwitchHelper.FindById(id);
            if (model == default(IpEntity)) { return; }
            var isOk = true;
            MessageBox.Show(IpSwitchHelper.SetNetworkAdapter(model,ref isOk), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (isOk)
            {
                GetNowStatus(null, model);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formmodel = new Manage();
            formmodel.ShowDialog();
            LoadConfig();
            GetNowStatus(IpSwitchHelper.LoadItems());
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        private void ListForm_SizeChanged(object sender, EventArgs e)
        {
            formNotifyIcon.Visible = true;
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                return;
            }
            ShowInTaskbar = true;

        }

        private void formNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ListForm_Shown(object sender, EventArgs e)
        {
            //GetNowStatus(IpSwitchHelper.LoadItems());
        }

        private void autoStartCB_CheckedChanged(object sender, EventArgs e)
        {
            if (autoStartCB.Checked) //设置开机自启动 
            {
                if (isAuto) { return; }
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.SetValue("IpSwitch", path);
                rk2.Close();
                rk.Close();
                isAuto = true;
                Settings set = new Settings();
                set.isAutoStart = true;
                set.Save();
            }
            else //取消开机自启动 
            {
                isAuto = false;
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.DeleteValue("IpSwitch", false);
                rk2.Close();
                rk.Close();
                Settings set = new Settings();
                set.isAutoStart = false;
                set.Save();
            }

        }
    }
}
