using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;

namespace IpSwitch.UIForm
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {

            LoadConfig();
            LoadItem(itemsComboBox.SelectedValue?.ToString());
        }

        public void LoadConfig(object sender, EventArgs e)
        {
            LoadConfig();
        }

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
            foreach (var item in ls.Items)
            {
                menu.Items.Add(item.Name, null, (object s, EventArgs ea) =>
                {
                  MessageBox.Show(  IpSwitchHelper.SetNetworkAdapter(IpSwitchHelper.FindById(item.Id)),"IpSwitch",MessageBoxButtons.OK,MessageBoxIcon.Information);
                });
            }
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add("关于", null, (object s, EventArgs ea) => { MessageBox.Show(":-)", ":-)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); });
            menu.Items.Add("退出", null, (object s, EventArgs ea) => { Application.Exit(); });
            formNotifyIcon.ContextMenuStrip = menu;

        }

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
            MessageBox.Show(IpSwitchHelper.SetNetworkAdapter(model), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formmodel = new Manage();
            formmodel.ShowDialog();
            LoadConfig();
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        private void ListForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //托盘显示图标等于托盘图标对象 
                //注意notifyIcon1是控件的名字而不是对象的名字 
                //隐藏任务栏区图标 
                this.ShowInTaskbar = false;
                //图标显示在托盘区 
                formNotifyIcon.Visible = true;
                return;
            }
            this.ShowInTaskbar = true;
            formNotifyIcon.Visible = false;

        }

        private void formNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowState = FormWindowState.Normal;

            }
        }
    }
}
