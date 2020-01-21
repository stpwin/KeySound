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
            this.comboBoxSound = new System.Windows.Forms.ComboBox();
            this.comboBoxKeys2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSound2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTest2 = new System.Windows.Forms.Button();
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
            this.buttonBrowse.Location = new System.Drawing.Point(745, 59);
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "เสียง:";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(745, 15);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(14, 35);
            this.textBoxFilePath.TabIndex = 3;
            this.textBoxFilePath.Visible = false;
            // 
            // buttonTest
            // 
            this.buttonTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTest.Location = new System.Drawing.Point(545, 17);
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
            this.buttonTestEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestEnd.Location = new System.Drawing.Point(653, 39);
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
            this.label2.Location = new System.Drawing.Point(13, 16);
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
            this.comboBoxKeys.Location = new System.Drawing.Point(92, 16);
            this.comboBoxKeys.Name = "comboBoxKeys";
            this.comboBoxKeys.Size = new System.Drawing.Size(177, 35);
            this.comboBoxKeys.TabIndex = 9;
            this.comboBoxKeys.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeys_SelectedIndexChanged);
            // 
            // comboBoxSound
            // 
            this.comboBoxSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSound.FormattingEnabled = true;
            this.comboBoxSound.Items.AddRange(new object[] {
            "ผู้หญิง",
            "ผู้ชาย",
            "ประเมิณความพึงพอใจผู้หญิง"});
            this.comboBoxSound.Location = new System.Drawing.Point(330, 17);
            this.comboBoxSound.Name = "comboBoxSound";
            this.comboBoxSound.Size = new System.Drawing.Size(208, 35);
            this.comboBoxSound.TabIndex = 10;
            this.comboBoxSound.SelectedIndexChanged += new System.EventHandler(this.comboBoxSound_SelectedIndexChanged);
            // 
            // comboBoxKeys2
            // 
            this.comboBoxKeys2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxKeys2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeys2.FormattingEnabled = true;
            this.comboBoxKeys2.Location = new System.Drawing.Point(92, 57);
            this.comboBoxKeys2.Name = "comboBoxKeys2";
            this.comboBoxKeys2.Size = new System.Drawing.Size(177, 35);
            this.comboBoxKeys2.TabIndex = 12;
            this.comboBoxKeys2.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeys2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "คีย์ลัด:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSound2
            // 
            this.comboBoxSound2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSound2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSound2.FormattingEnabled = true;
            this.comboBoxSound2.Items.AddRange(new object[] {
            "ผู้หญิง",
            "ผู้ชาย",
            "ประเมิณความพึงพอใจผู้หญิง"});
            this.comboBoxSound2.Location = new System.Drawing.Point(330, 58);
            this.comboBoxSound2.Name = "comboBoxSound2";
            this.comboBoxSound2.Size = new System.Drawing.Size(208, 35);
            this.comboBoxSound2.TabIndex = 14;
            this.comboBoxSound2.SelectedIndexChanged += new System.EventHandler(this.comboBoxSound2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "เสียง:";
            // 
            // buttonTest2
            // 
            this.buttonTest2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTest2.Location = new System.Drawing.Point(545, 57);
            this.buttonTest2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(100, 35);
            this.buttonTest2.TabIndex = 15;
            this.buttonTest2.Text = "เล่น";
            this.buttonTest2.UseVisualStyleBackColor = true;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 104);
            this.Controls.Add(this.buttonTest2);
            this.Controls.Add(this.comboBoxSound2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxKeys2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSound);
            this.Controls.Add(this.comboBoxKeys);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKeys;
        private System.Windows.Forms.ComboBox comboBoxSound;
        private System.Windows.Forms.ComboBox comboBoxKeys2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSound2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTest2;
    }
}

