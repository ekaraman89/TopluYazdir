﻿using Microsoft.Win32;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TopluYazdir
{
    public partial class frmTopluYazdir : Form
    {
        public frmTopluYazdir()
        {
            InitializeComponent();
        }

        private class Dosya
        {
            public string Firma { get; set; }
            public string Donem { get; set; }
            public string Tur { get; set; }
            public string Cins { get; set; }
            public string Yol { get; set; }

            public Dosya(FileInfo info)
            {
                Firma = info.Directory.Parent.Name;
                Donem = info.Directory.Name;
                string[] tmp = info.Name.Split('_');
                Tur = tmp[0];
                Cins = tmp[1];
                Yol = info.FullName;
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            chkListFirma.Items.Clear();
            GetAllFiles();

            var ts = lst.GroupBy(x => x.Firma).Select(y => y.First().Firma).ToArray();

            chkListFirma.Items.AddRange(ts);
            if (chkListFirma.Items.Count > 0)
                chkListFirma.Items.Insert(0, "Tümünü Seç");

            rdBtnAll.Checked = true;
            chkListDonem.Items.Clear();
            chkListTur.Items.Clear();
            lstBoxFiles.Items.Clear();

        }

        List<Dosya> lst = new List<Dosya>();
        List<Dosya> tmp = new List<Dosya>();

        List<String> Firmalar = new List<string>();
        List<String> Donemler = new List<string>();
        List<String> Tur = new List<string>();

        private void GetAllFiles()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                lst.Clear();

                string[] allfiles = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories);

                foreach (var file in allfiles.OrderBy(x => x))
                {
                    FileInfo info = new FileInfo(file);
                    try
                    {
                        Dosya dosya = new Dosya(info);
                        lst.Add(dosya);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private List<Dosya> Query(Func<Dosya, bool> condition)
        {
            return lst.Where(condition).ToList();
        }

        private void chkListFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Firmalar.Clear();

            bool check = false;
            if (chkListFirma.GetItemCheckState(0) == CheckState.Checked) check = true;

            if (((CheckedListBox)sender).SelectedIndex == 0)
            {
                for (int i = 0; i < chkListFirma.Items.Count; i++)
                {
                    chkListFirma.SetItemChecked(i, check);
                }
            }
            else
            {
                chkListFirma.SetItemChecked(0, false);
            }

            foreach (string item in chkListFirma.CheckedItems)
            {
                Firmalar.Add(item);
            }


            tmp = Query(x => Firmalar.Contains(x.Firma));

            var ts = tmp.GroupBy(x => x.Donem).Select(y => y.First().Donem).ToArray();
            chkListDonem.Items.Clear();
            chkListDonem.Items.AddRange(ts);

            ReadyToPrint(tmp);

        }

        private void chkListDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Donemler.Clear();
            foreach (string item in chkListDonem.CheckedItems)
            {
                Donemler.Add(item);
            }

            var ts = tmp.Where(x => Donemler.Contains(x.Donem)).ToList();

            chkListTur.Items.Clear();
            chkListTur.Items.AddRange(ts.GroupBy(x => x.Tur).Select(y => y.First().Tur).ToArray());

            ReadyToPrint(ts);

        }

        private void chkListTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tur.Clear();
            foreach (string item in chkListTur.CheckedItems)
            {
                Tur.Add(item);
            }

            var ts = tmp.Where(x => Donemler.Contains(x.Donem) && Tur.Contains(x.Tur)).ToList();
            ReadyToPrint(ts);

        }

        private void rdBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            var ts = tmp.Where(x => Donemler.Contains(x.Donem) && Tur.Contains(x.Tur)).ToList();
            ReadyToPrint(ts);
        }

        private void rdBtnBeyanname_CheckedChanged(object sender, EventArgs e)
        {
            var ts = tmp.Where(x => Donemler.Contains(x.Donem) && Tur.Contains(x.Tur) && x.Cins.ToLower().Contains("beyanname")).ToList();
            ReadyToPrint(ts);
        }

        private void rdBtnTahakkuk_CheckedChanged(object sender, EventArgs e)
        {
            var ts = tmp.Where(x => Donemler.Contains(x.Donem) && Tur.Contains(x.Tur) && x.Cins.ToLower().Contains("tahakkuk")).ToList();
            ReadyToPrint(ts);
        }

        private void rdBtnHizmet_CheckedChanged(object sender, EventArgs e)
        {
            var ts = tmp.Where(x => Donemler.Contains(x.Donem) && Tur.Contains(x.Tur) && x.Cins.ToLower().Contains("hizmet")).ToList();
            ReadyToPrint(ts);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lstBoxFiles.Items.Count > 0)
            {
                if (MessageBox.Show(lstBoxFiles.Items.Count + " adet dosya yazıcıya gönderilecek. Onaylıyor musunuz ?", "Yazdırma Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Print(lstBoxFiles.Items.OfType<string>().ToArray());
                MessageBox.Show("Yazdırma işlemi tamamlandı");
            }
            else
            {
                MessageBox.Show("Liste Boş");
            }
        }

        private void ReadyToPrint(List<Dosya> printList)
        {
            lstBoxFiles.Items.Clear();
            lstBoxFiles.Items.AddRange(printList.Select(x => x.Yol).ToArray());
            label1.Text = $"{lstBoxFiles.Items.Count} Dosya Seçildi";
        }

        const string path = "temp";

        public void Print(string[] files)
        {
            if (!Directory.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }

            using (PdfDocument outPdf = new PdfDocument())
            {
                for (int i = 0; i < lstBoxFiles.Items.Count; i++)
                {
                    using (PdfDocument tmp = PdfReader.Open(lstBoxFiles.Items[i].ToString(), PdfDocumentOpenMode.Import))
                        CopyPages(tmp, outPdf);
                }

                outPdf.Save(path + "/files.pdf");
            }

            try
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    Process.Start(
                    Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion" +
                    @"\App Paths\AcroRd32.exe").GetValue("").ToString(),
                    string.Format("/h /t \"{0}\" \"{1}\"", path + "/files.pdf", printDialog.PrinterSettings.PrinterName));
                }
            }
            catch { }
        }

        private void txtFirmaAra_TextChanged(object sender, EventArgs e)
        {
            string find = txtFirmaAra.Text.ToUpper();
            chkListFirma.Items.Clear();
            var ts = lst.GroupBy(x => x.Firma).Select(y => y.First().Firma).ToArray();
            chkListFirma.Items.AddRange(ts);

            if (!string.IsNullOrWhiteSpace(find))
            {
                ts = lst.Where(x => x.Firma.Contains(find)).GroupBy(y => y.Firma).Select(z => z.First().Firma).ToArray();
                chkListFirma.Items.Clear();
                chkListFirma.Items.AddRange(ts);
            }

            if (chkListFirma.Items.Count > 0)
                chkListFirma.Items.Insert(0, "Tümünü Seç");
        }

        void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }

        private void frmTopluYazdir_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }
    }
}
