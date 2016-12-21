namespace IpSwitch.UIForm
{
    partial class ListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.itemsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ipMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.subnetMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dnsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.autoStartCB = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.networkTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsComboBox
            // 
            this.itemsComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.itemsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.itemsComboBox.FormattingEnabled = true;
            this.itemsComboBox.Location = new System.Drawing.Point(19, 30);
            this.itemsComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemsComboBox.Name = "itemsComboBox";
            this.itemsComboBox.Size = new System.Drawing.Size(175, 25);
            this.itemsComboBox.TabIndex = 0;
            this.itemsComboBox.SelectedIndexChanged += new System.EventHandler(this.itemsComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.itemsComboBox);
            this.groupBox1.Location = new System.Drawing.Point(262, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(208, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(18, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "管理";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(19, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "应用";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipMaskedTextBox
            // 
            this.ipMaskedTextBox.Location = new System.Drawing.Point(90, 30);
            this.ipMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ipMaskedTextBox.Name = "ipMaskedTextBox";
            this.ipMaskedTextBox.PromptChar = ' ';
            this.ipMaskedTextBox.ReadOnly = true;
            this.ipMaskedTextBox.Size = new System.Drawing.Size(128, 23);
            this.ipMaskedTextBox.TabIndex = 3;
            this.ipMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subnetMaskedTextBox
            // 
            this.subnetMaskedTextBox.Location = new System.Drawing.Point(90, 106);
            this.subnetMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subnetMaskedTextBox.Name = "subnetMaskedTextBox";
            this.subnetMaskedTextBox.PromptChar = ' ';
            this.subnetMaskedTextBox.ReadOnly = true;
            this.subnetMaskedTextBox.Size = new System.Drawing.Size(128, 23);
            this.subnetMaskedTextBox.TabIndex = 4;
            this.subnetMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gateMaskedTextBox
            // 
            this.gateMaskedTextBox.Location = new System.Drawing.Point(90, 144);
            this.gateMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gateMaskedTextBox.Name = "gateMaskedTextBox";
            this.gateMaskedTextBox.PromptChar = ' ';
            this.gateMaskedTextBox.ReadOnly = true;
            this.gateMaskedTextBox.Size = new System.Drawing.Size(128, 23);
            this.gateMaskedTextBox.TabIndex = 5;
            this.gateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dnsMaskedTextBox
            // 
            this.dnsMaskedTextBox.Location = new System.Drawing.Point(90, 182);
            this.dnsMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dnsMaskedTextBox.Name = "dnsMaskedTextBox";
            this.dnsMaskedTextBox.PromptChar = ' ';
            this.dnsMaskedTextBox.ReadOnly = true;
            this.dnsMaskedTextBox.Size = new System.Drawing.Size(128, 23);
            this.dnsMaskedTextBox.TabIndex = 6;
            this.dnsMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "子网掩码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP地址：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.networkTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ipMaskedTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.subnetMaskedTextBox);
            this.groupBox2.Controls.Add(this.dnsMaskedTextBox);
            this.groupBox2.Controls.Add(this.gateMaskedTextBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(233, 224);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "DNS：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "默认网关：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // formNotifyIcon
            // 
            this.formNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.formNotifyIcon.BalloonTipText = "IpSwitch";
            this.formNotifyIcon.BalloonTipTitle = "IpSwitch";
            this.formNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("formNotifyIcon.Icon")));
            this.formNotifyIcon.Text = "IpSwitch";
            this.formNotifyIcon.Visible = true;
            this.formNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.formNotifyIcon_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "状态：";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(57, 225);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(17, 17);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "...";
            // 
            // autoStartCB
            // 
            this.autoStartCB.AutoSize = true;
            this.autoStartCB.Location = new System.Drawing.Point(271, 225);
            this.autoStartCB.Name = "autoStartCB";
            this.autoStartCB.Size = new System.Drawing.Size(75, 21);
            this.autoStartCB.TabIndex = 12;
            this.autoStartCB.Text = "开机自启";
            this.autoStartCB.UseVisualStyleBackColor = true;
            this.autoStartCB.CheckedChanged += new System.EventHandler(this.autoStartCB_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 21);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "网卡：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox1
            // 
            this.networkTextBox.Location = new System.Drawing.Point(90, 68);
            this.networkTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.networkTextBox.Name = "maskedTextBox1";
            this.networkTextBox.PromptChar = ' ';
            this.networkTextBox.ReadOnly = true;
            this.networkTextBox.Size = new System.Drawing.Size(128, 23);
            this.networkTextBox.TabIndex = 11;
            this.networkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(483, 245);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.autoStartCB);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(499, 284);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(499, 284);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IpSwitch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.Shown += new System.EventHandler(this.ListForm_Shown);
            this.SizeChanged += new System.EventHandler(this.ListForm_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox itemsComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox ipMaskedTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox subnetMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox gateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dnsMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon formNotifyIcon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox autoStartCB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox networkTextBox;
    }
}