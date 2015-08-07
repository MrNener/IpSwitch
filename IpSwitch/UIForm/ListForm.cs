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

        public void LoadConfig(object sender,EventArgs e)
        {
             LoadConfig();
        }

        public void LoadConfig()
        {
            ipMaskedTextBox.Text = "";
            subnetMaskedTextBox.Text = "";
            gateMaskedTextBox.Text ="";
            dnsMaskedTextBox.Text = "";

            itemsComboBox.DataSource = null;
            itemsComboBox.Items.Clear();
            var ls = IpSwitchHelper.LoadItems();
            if (ls.Items.Count <= 0) { return; }
            itemsComboBox.DataSource = ls.Items;
            itemsComboBox.DisplayMember = "Name";
            itemsComboBox.ValueMember = "Id";
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
            MessageBox.Show(IpSwitchHelper.SetNetworkAdapter(model));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formmodel = new Manage();
            formmodel.ShowDialog();
            LoadConfig();
        }
    }
}
