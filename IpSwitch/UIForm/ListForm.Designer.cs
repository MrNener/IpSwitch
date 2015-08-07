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
            this.itemsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ipMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.subnetMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dnsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
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
            this.subnetMaskedTextBox.Location = new System.Drawing.Point(90, 79);
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
            this.gateMaskedTextBox.Location = new System.Drawing.Point(90, 128);
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
            this.dnsMaskedTextBox.Location = new System.Drawing.Point(90, 177);
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
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "子网掩码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP地址：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
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
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "默认网关：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "DNS：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(483, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(499, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(499, 280);
            this.Name = "ListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IpSwitch";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
    }
}