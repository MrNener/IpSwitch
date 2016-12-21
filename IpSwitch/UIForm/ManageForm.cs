using Helper;
using IpSwitch.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpSwitch.UIForm
{
    public partial class Manage : Form
    {
        public const string tempId = "8888";
        public Manage()
        {
            InitializeComponent();
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            LoadConfig();
            networkComBox.DataSource = null;
            networkComBox.DataSource=NetworkHelper.NetWorkList();
            networkComBox.DisplayMember = "Name";
            networkComBox.ValueMember = "Id";
            SelectItem();
        }

        public void LoadConfig()
        {
            nameMaskedTextBox.Text ="";
            ipMaskedTextBox.Text = "";
            subnetMaskedTextBox.Text = "";
            gateMaskedTextBox.Text = "";
            dnsMaskedTextBox.Text = "";
            idMaskedTextBox.Text = "";


            itemListBox.DataSource = null;
            itemListBox.Items.Clear();
            var ls = IpSwitchHelper.LoadItems();
            if (ls.Items.Count <= 0) { return; }
            itemListBox.DataSource = ls.Items;
            itemListBox.DisplayMember = "Name";
            itemListBox.ValueMember = "Id";
        }
        public void SelectItem()
        {
            var id = itemListBox.SelectedValue?.ToString();
            var model = IpSwitchHelper.FindById(id);
            if (model == default(IpEntity)) { return; }
            nameMaskedTextBox.Text = model.Name;
            ipMaskedTextBox.Text = model.IpAddress;
            subnetMaskedTextBox.Text = model.SubnetMask;
            gateMaskedTextBox.Text = model.Gateway;
            dnsMaskedTextBox.Text = model.DNS;
            idMaskedTextBox.Text = model.Id;
            networkComBox.SelectedValue = model.NetworkID;

        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var se = itemListBox.SelectedIndex;
            var net=networkComBox.SelectedItem as System.Net.NetworkInformation.NetworkInterface;
           var model = new IpEntity
            {
                Name = nameMaskedTextBox.Text.Trim(),
                IpAddress = ipMaskedTextBox.Text.Trim(),
                Id = idMaskedTextBox.Text.Trim(),
                Gateway = gateMaskedTextBox.Text.Trim(),
                SubnetMask = subnetMaskedTextBox.Text.Trim(),
                NetworkName= net?.Name,
                NetworkID=net?.Id,
                MACAddress= net?.GetPhysicalAddress()?.ToString(),
                DNS = dnsMaskedTextBox.Text.Trim()
            };
            var isPass = true;
            var res = string.Empty;
            res= IpSwitchHelper.CheckIpEntity(model, ref isPass);
            if (!isPass)
            {
                MessageBox.Show(res, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (model.Id.Equals(tempId)||string.IsNullOrEmpty(model.Id))
            {
                model.Id = Guid.NewGuid().ToString("N");
                res = IpSwitchHelper.AddConfig(model);
            }
            else
            {
                res = IpSwitchHelper.UpdateConfig(model);
            }
            LoadConfig();
            itemListBox.SelectedIndex = se >= 0 ? se : 0;
            MessageBox.Show(res, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var net = networkComBox.SelectedItem as System.Net.NetworkInformation.NetworkInterface;
            var model = IpSwitchHelper.CreateDefault(net?.Id);
            nameMaskedTextBox.Text = "新方案"+(itemListBox.Items.Count+1);
            ipMaskedTextBox.Text = model.IpAddress;
            subnetMaskedTextBox.Text = model.SubnetMask;
            gateMaskedTextBox.Text = model.Gateway;
            dnsMaskedTextBox.Text = model.DNS;
            idMaskedTextBox.Text = tempId;
            itemListBox.SelectedIndex = -1;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            var id = itemListBox.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(id)) { return; }
            var se = itemListBox.SelectedIndex;
            var msg = IpSwitchHelper.DeleteConfig(new IpEntity { Id = id });
            LoadConfig();
            itemListBox.SelectedIndex = se >= 0 ?(se>=itemListBox.Items.Count?se-1:se) : 0;
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

 
    }
}
