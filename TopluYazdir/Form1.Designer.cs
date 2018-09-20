namespace TopluYazdir
{
    partial class frmTopluYazdir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTopluYazdir));
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lstBoxFiles = new System.Windows.Forms.ListBox();
            this.chkListFirma = new System.Windows.Forms.CheckedListBox();
            this.chkListDonem = new System.Windows.Forms.CheckedListBox();
            this.chkListTur = new System.Windows.Forms.CheckedListBox();
            this.rdBtnAll = new System.Windows.Forms.RadioButton();
            this.rdBtnBeyanname = new System.Windows.Forms.RadioButton();
            this.rdBtnTahakkuk = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtnHizmet = new System.Windows.Forms.RadioButton();
            this.txtFirmaAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            resources.ApplyResources(this.btnSelectFolder, "btnSelectFolder");
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lstBoxFiles
            // 
            this.lstBoxFiles.FormattingEnabled = true;
            resources.ApplyResources(this.lstBoxFiles, "lstBoxFiles");
            this.lstBoxFiles.Name = "lstBoxFiles";
            // 
            // chkListFirma
            // 
            this.chkListFirma.CheckOnClick = true;
            this.chkListFirma.FormattingEnabled = true;
            resources.ApplyResources(this.chkListFirma, "chkListFirma");
            this.chkListFirma.Name = "chkListFirma";
            this.chkListFirma.SelectedIndexChanged += new System.EventHandler(this.chkListFirma_SelectedIndexChanged);
            // 
            // chkListDonem
            // 
            this.chkListDonem.CheckOnClick = true;
            this.chkListDonem.FormattingEnabled = true;
            resources.ApplyResources(this.chkListDonem, "chkListDonem");
            this.chkListDonem.Name = "chkListDonem";
            this.chkListDonem.SelectedIndexChanged += new System.EventHandler(this.chkListDonem_SelectedIndexChanged);
            // 
            // chkListTur
            // 
            this.chkListTur.CheckOnClick = true;
            this.chkListTur.FormattingEnabled = true;
            resources.ApplyResources(this.chkListTur, "chkListTur");
            this.chkListTur.Name = "chkListTur";
            this.chkListTur.SelectedIndexChanged += new System.EventHandler(this.chkListTur_SelectedIndexChanged);
            // 
            // rdBtnAll
            // 
            resources.ApplyResources(this.rdBtnAll, "rdBtnAll");
            this.rdBtnAll.Checked = true;
            this.rdBtnAll.Name = "rdBtnAll";
            this.rdBtnAll.TabStop = true;
            this.rdBtnAll.UseVisualStyleBackColor = true;
            this.rdBtnAll.CheckedChanged += new System.EventHandler(this.rdBtnAll_CheckedChanged);
            // 
            // rdBtnBeyanname
            // 
            resources.ApplyResources(this.rdBtnBeyanname, "rdBtnBeyanname");
            this.rdBtnBeyanname.Name = "rdBtnBeyanname";
            this.rdBtnBeyanname.UseVisualStyleBackColor = true;
            this.rdBtnBeyanname.CheckedChanged += new System.EventHandler(this.rdBtnBeyanname_CheckedChanged);
            // 
            // rdBtnTahakkuk
            // 
            resources.ApplyResources(this.rdBtnTahakkuk, "rdBtnTahakkuk");
            this.rdBtnTahakkuk.Name = "rdBtnTahakkuk";
            this.rdBtnTahakkuk.UseVisualStyleBackColor = true;
            this.rdBtnTahakkuk.CheckedChanged += new System.EventHandler(this.rdBtnTahakkuk_CheckedChanged);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDialog
            // 
            this.printDialog.AllowPrintToFile = false;
            this.printDialog.UseEXDialog = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // rdBtnHizmet
            // 
            resources.ApplyResources(this.rdBtnHizmet, "rdBtnHizmet");
            this.rdBtnHizmet.Name = "rdBtnHizmet";
            this.rdBtnHizmet.UseVisualStyleBackColor = true;
            this.rdBtnHizmet.CheckedChanged += new System.EventHandler(this.rdBtnHizmet_CheckedChanged);
            // 
            // txtFirmaAra
            // 
            resources.ApplyResources(this.txtFirmaAra, "txtFirmaAra");
            this.txtFirmaAra.Name = "txtFirmaAra";
            this.txtFirmaAra.TextChanged += new System.EventHandler(this.txtFirmaAra_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // frmTopluYazdir
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirmaAra);
            this.Controls.Add(this.rdBtnHizmet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rdBtnTahakkuk);
            this.Controls.Add(this.rdBtnBeyanname);
            this.Controls.Add(this.rdBtnAll);
            this.Controls.Add(this.chkListTur);
            this.Controls.Add(this.chkListDonem);
            this.Controls.Add(this.chkListFirma);
            this.Controls.Add(this.lstBoxFiles);
            this.Controls.Add(this.btnSelectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTopluYazdir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTopluYazdir_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ListBox lstBoxFiles;
        private System.Windows.Forms.CheckedListBox chkListFirma;
        private System.Windows.Forms.CheckedListBox chkListDonem;
        private System.Windows.Forms.CheckedListBox chkListTur;
        private System.Windows.Forms.RadioButton rdBtnAll;
        private System.Windows.Forms.RadioButton rdBtnBeyanname;
        private System.Windows.Forms.RadioButton rdBtnTahakkuk;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtnHizmet;
        private System.Windows.Forms.TextBox txtFirmaAra;
        private System.Windows.Forms.Label label2;
    }
}

