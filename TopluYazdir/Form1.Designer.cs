namespace TopluYazdir
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lstBoxFiles = new System.Windows.Forms.ListBox();
            this.chkListFirma = new System.Windows.Forms.CheckedListBox();
            this.chkListDonem = new System.Windows.Forms.CheckedListBox();
            this.chkListTur = new System.Windows.Forms.CheckedListBox();
            this.rdBtnAll = new System.Windows.Forms.RadioButton();
            this.rdBtnBeyanname = new System.Windows.Forms.RadioButton();
            this.rdBtnTahakkuk = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(126, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Dosya Yolu Ayarla";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lstBoxFiles
            // 
            this.lstBoxFiles.FormattingEnabled = true;
            this.lstBoxFiles.Location = new System.Drawing.Point(12, 232);
            this.lstBoxFiles.Name = "lstBoxFiles";
            this.lstBoxFiles.Size = new System.Drawing.Size(767, 212);
            this.lstBoxFiles.TabIndex = 1;
            // 
            // chkListFirma
            // 
            this.chkListFirma.CheckOnClick = true;
            this.chkListFirma.FormattingEnabled = true;
            this.chkListFirma.Location = new System.Drawing.Point(12, 46);
            this.chkListFirma.Name = "chkListFirma";
            this.chkListFirma.Size = new System.Drawing.Size(290, 169);
            this.chkListFirma.TabIndex = 2;
            this.chkListFirma.SelectedIndexChanged += new System.EventHandler(this.chkListFirma_SelectedIndexChanged);
            // 
            // chkListDonem
            // 
            this.chkListDonem.CheckOnClick = true;
            this.chkListDonem.FormattingEnabled = true;
            this.chkListDonem.Location = new System.Drawing.Point(308, 47);
            this.chkListDonem.Name = "chkListDonem";
            this.chkListDonem.Size = new System.Drawing.Size(144, 169);
            this.chkListDonem.TabIndex = 3;
            this.chkListDonem.SelectedIndexChanged += new System.EventHandler(this.chkListDonem_SelectedIndexChanged);
            // 
            // chkListTur
            // 
            this.chkListTur.CheckOnClick = true;
            this.chkListTur.FormattingEnabled = true;
            this.chkListTur.Location = new System.Drawing.Point(469, 47);
            this.chkListTur.Name = "chkListTur";
            this.chkListTur.Size = new System.Drawing.Size(144, 169);
            this.chkListTur.TabIndex = 4;
            this.chkListTur.SelectedIndexChanged += new System.EventHandler(this.chkListTur_SelectedIndexChanged);
            // 
            // rdBtnAll
            // 
            this.rdBtnAll.AutoSize = true;
            this.rdBtnAll.Checked = true;
            this.rdBtnAll.Location = new System.Drawing.Point(649, 62);
            this.rdBtnAll.Name = "rdBtnAll";
            this.rdBtnAll.Size = new System.Drawing.Size(52, 17);
            this.rdBtnAll.TabIndex = 5;
            this.rdBtnAll.TabStop = true;
            this.rdBtnAll.Text = "Hepsi";
            this.rdBtnAll.UseVisualStyleBackColor = true;
            this.rdBtnAll.CheckedChanged += new System.EventHandler(this.rdBtnAll_CheckedChanged);
            // 
            // rdBtnBeyanname
            // 
            this.rdBtnBeyanname.AutoSize = true;
            this.rdBtnBeyanname.Location = new System.Drawing.Point(649, 85);
            this.rdBtnBeyanname.Name = "rdBtnBeyanname";
            this.rdBtnBeyanname.Size = new System.Drawing.Size(81, 17);
            this.rdBtnBeyanname.TabIndex = 6;
            this.rdBtnBeyanname.Text = "Beyanname";
            this.rdBtnBeyanname.UseVisualStyleBackColor = true;
            this.rdBtnBeyanname.CheckedChanged += new System.EventHandler(this.rdBtnBeyanname_CheckedChanged);
            // 
            // rdBtnTahakkuk
            // 
            this.rdBtnTahakkuk.AutoSize = true;
            this.rdBtnTahakkuk.Location = new System.Drawing.Point(649, 109);
            this.rdBtnTahakkuk.Name = "rdBtnTahakkuk";
            this.rdBtnTahakkuk.Size = new System.Drawing.Size(74, 17);
            this.rdBtnTahakkuk.TabIndex = 7;
            this.rdBtnTahakkuk.Text = "Tahakkuk";
            this.rdBtnTahakkuk.UseVisualStyleBackColor = true;
            this.rdBtnTahakkuk.CheckedChanged += new System.EventHandler(this.rdBtnTahakkuk_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(649, 161);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Yazıcıya Gönder";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rdBtnTahakkuk);
            this.Controls.Add(this.rdBtnBeyanname);
            this.Controls.Add(this.rdBtnAll);
            this.Controls.Add(this.chkListTur);
            this.Controls.Add(this.chkListDonem);
            this.Controls.Add(this.chkListFirma);
            this.Controls.Add(this.lstBoxFiles);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ListBox lstBoxFiles;
        private System.Windows.Forms.CheckedListBox chkListFirma;
        private System.Windows.Forms.CheckedListBox chkListDonem;
        private System.Windows.Forms.CheckedListBox chkListTur;
        private System.Windows.Forms.RadioButton rdBtnAll;
        private System.Windows.Forms.RadioButton rdBtnBeyanname;
        private System.Windows.Forms.RadioButton rdBtnTahakkuk;
        private System.Windows.Forms.Button btnPrint;
    }
}

