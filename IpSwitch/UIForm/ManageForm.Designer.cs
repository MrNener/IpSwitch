namespace IpSwitch.UIForm
{
    partial class Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subnetMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dnsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemListBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(164, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // itemListBox
            // 
            this.itemListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.HorizontalScrollbar = true;
            this.itemListBox.ItemHeight = 17;
            this.itemListBox.Location = new System.Drawing.Point(10, 28);
            this.itemListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(139, 242);
            this.itemListBox.TabIndex = 0;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idMaskedTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nameMaskedTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ipMaskedTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.subnetMaskedTextBox);
            this.groupBox2.Controls.Add(this.dnsMaskedTextBox);
            this.groupBox2.Controls.Add(this.gateMaskedTextBox);
            this.groupBox2.Location = new System.Drawing.Point(182, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox2.Size = new System.Drawing.Size(261, 287);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息";
            // 
            // idMaskedTextBox
            // 
            this.idMaskedTextBox.Location = new System.Drawing.Point(90, 263);
            this.idMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.idMaskedTextBox.Name = "idMaskedTextBox";
            this.idMaskedTextBox.PromptChar = ' ';
            this.idMaskedTextBox.Size = new System.Drawing.Size(149, 23);
            this.idMaskedTextBox.TabIndex = 13;
            this.idMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idMaskedTextBox.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "名称：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameMaskedTextBox
            // 
            this.nameMaskedTextBox.Location = new System.Drawing.Point(90, 28);
            this.nameMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.nameMaskedTextBox.Name = "nameMaskedTextBox";
            this.nameMaskedTextBox.PromptChar = ' ';
            this.nameMaskedTextBox.Size = new System.Drawing.Size(149, 23);
            this.nameMaskedTextBox.TabIndex = 11;
            this.nameMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "DNS：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "默认网关：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP地址：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ipMaskedTextBox
            // 
            this.ipMaskedTextBox.Location = new System.Drawing.Point(90, 78);
            this.ipMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ipMaskedTextBox.Name = "ipMaskedTextBox";
            this.ipMaskedTextBox.PromptChar = ' ';
            this.ipMaskedTextBox.Size = new System.Drawing.Size(149, 23);
            this.ipMaskedTextBox.TabIndex = 3;
            this.ipMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "子网掩码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subnetMaskedTextBox
            // 
            this.subnetMaskedTextBox.Location = new System.Drawing.Point(90, 128);
            this.subnetMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.subnetMaskedTextBox.Name = "subnetMaskedTextBox";
            this.subnetMaskedTextBox.PromptChar = ' ';
            this.subnetMaskedTextBox.Size = new System.Drawing.Size(149, 23);
            this.subnetMaskedTextBox.TabIndex = 4;
            this.subnetMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dnsMaskedTextBox
            // 
            this.dnsMaskedTextBox.Location = new System.Drawing.Point(90, 228);
            this.dnsMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dnsMaskedTextBox.Name = "dnsMaskedTextBox";
            this.dnsMaskedTextBox.PromptChar = ' ';
            this.dnsMaskedTextBox.Size = new System.Drawing.Size(149, 23);
            this.dnsMaskedTextBox.TabIndex = 6;
            this.dnsMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gateMaskedTextBox
            // 
            this.gateMaskedTextBox.Location = new System.Drawing.Point(90, 178);
            this.gateMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gateMaskedTextBox.Name = "gateMaskedTextBox";
            this.gateMaskedTextBox.PromptChar = ' ';
            this.gateMaskedTextBox.Size = new System.Drawing.Size(149, 23);
            this.gateMaskedTextBox.TabIndex = 5;
            this.gateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addButton.Location = new System.Drawing.Point(10, 314);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 30);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "新建";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveButton.Location = new System.Drawing.Point(171, 314);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 30);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.delButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delButton.ForeColor = System.Drawing.SystemColors.Window;
            this.delButton.Location = new System.Drawing.Point(332, 314);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(110, 30);
            this.delButton.TabIndex = 13;
            this.delButton.Text = "删除";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(454, 365);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 404);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 404);
            this.Name = "Manage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageList";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox nameMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ipMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox subnetMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dnsMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox gateMaskedTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.MaskedTextBox idMaskedTextBox;
    }
}