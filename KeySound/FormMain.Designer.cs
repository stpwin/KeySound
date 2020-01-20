namespace KeySound
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonTestEnd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKeys = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.separator1 = new KeySound.Separator();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Wave file|*.wav";
            this.openFileDialog1.Title = "เลือกไฟล์เสียง";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(282, 59);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(14, 35);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "เลือกไฟล์";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Visible = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "เสียง:";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(282, 15);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(14, 35);
            this.textBoxFilePath.TabIndex = 3;
            this.textBoxFilePath.Visible = false;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(61, 56);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(100, 35);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "เล่น";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonTestEnd
            // 
            this.buttonTestEnd.Location = new System.Drawing.Point(169, 56);
            this.buttonTestEnd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonTestEnd.Name = "buttonTestEnd";
            this.buttonTestEnd.Size = new System.Drawing.Size(100, 35);
            this.buttonTestEnd.TabIndex = 5;
            this.buttonTestEnd.Text = "หยุด";
            this.buttonTestEnd.UseVisualStyleBackColor = true;
            this.buttonTestEnd.Click += new System.EventHandler(this.buttonTestEnd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "คีย์ลัด:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxKeys
            // 
            this.comboBoxKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeys.FormattingEnabled = true;
            this.comboBoxKeys.Location = new System.Drawing.Point(92, 129);
            this.comboBoxKeys.Name = "comboBoxKeys";
            this.comboBoxKeys.Size = new System.Drawing.Size(177, 35);
            this.comboBoxKeys.TabIndex = 9;
            this.comboBoxKeys.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeys_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ผู้หญิง",
            "ผู้ชาย"});
            this.comboBox1.Location = new System.Drawing.Point(61, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 35);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // separator1
            // 
            this.separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator1.Location = new System.Drawing.Point(13, 109);
            this.separator1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(283, 11);
            this.separator1.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 192);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.buttonTestEnd);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse);
            this.Font = new System.Drawing.Font("CS ChatThai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Sound";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonTestEnd;
        private Separator separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKeys;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

