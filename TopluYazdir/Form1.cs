using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TopluYazdir
{
    public partial class Form1 : Form
    {
        public Form1()
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
            GetAllFiles();
            var ts = lst.GroupBy(x => x.Firma).Select(y => y.First().Firma).ToArray();

            chkListFirma.Items.AddRange(ts);
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
            string[] allfiles = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories);

            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);
                Dosya dosya = new Dosya(info);
                lst.Add(dosya);
            }
        }

        private List<Dosya> Query(Func<Dosya, bool> condition)
        {
            return lst.Where(condition).ToList();
        }

        private void chkListFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Firmalar.Clear();
            foreach (string item in chkListFirma.CheckedItems)
            {
                Firmalar.Add(item);
            }

            lstBoxFiles.Items.Clear();

            tmp = Query(x => Firmalar.Contains(x.Firma));
            lstBoxFiles.Items.AddRange(tmp.Select(x => x.Yol).ToArray());

            var ts = tmp.GroupBy(x => x.Donem).Select(y => y.First().Donem).ToArray();
            chkListDonem.Items.Clear();
            chkListDonem.Items.AddRange(ts);
        }

        private void chkListDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Donemler.Clear();
            foreach (string item in chkListDonem.CheckedItems)
            {
                Donemler.Add(item);
            }

            lstBoxFiles.Items.Clear();


            var ts = tmp.Where(x => Donemler.Contains(x.Donem)).ToList();

            chkListTur.Items.Clear();
            chkListTur.Items.AddRange(ts.GroupBy(x => x.Tur).Select(y => y.First().Tur).ToArray());

            // var lstforlstbox = tmp.Where(x => Donemler.Contains(x.Donem)).ToList().GroupBy(x => new { x.Tur, x.Cins }).ToList();
            // listBox1.Items.AddRange(lstforlstbox.Select(x => x.First().Yol).ToArray());
            // listBox1.Items.AddRange(ts.GroupBy(x => x.Tur).Select(x => x.First().Yol).ToArray());
            lstBoxFiles.Items.AddRange(ts.Select(x => x.Yol).ToArray());


        }

        private void chkListTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tur.Clear();
            foreach (string item in chkListTur.CheckedItems)
            {
                Tur.Add(item);
            }
            lstBoxFiles.Items.Clear();
            var ts = tmp.Where(x => Donemler.Contains(x.Donem) && Tur.Contains(x.Tur)).ToList();

            lstBoxFiles.Items.AddRange(ts.Select(x => x.Yol).ToArray());

        }

        private void rdBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            var ts = tmp.Where(x => Donemler.Contains(x.Donem) && Tur.Contains(x.Tur)).ToList();
            lstBoxFiles.Items.Clear();
            lstBoxFiles.Items.AddRange(ts.Select(x => x.Yol).ToArray());
        }

        private void rdBtnBeyanname_CheckedChanged(object sender, EventArgs e)
        {
            var ts = tmp.Where(x => Donemler.Contains(x.Donem) && Tur.Contains(x.Tur) && x.Cins.ToLower().Contains("beyanname")).ToList();
            lstBoxFiles.Items.Clear();

            lstBoxFiles.Items.AddRange(ts.Select(x => x.Yol).ToArray());

        }

        private void rdBtnTahakkuk_CheckedChanged(object sender, EventArgs e)
        {
            var ts = tmp.Where(x => Donemler.Contains(x.Donem) && Tur.Contains(x.Tur) && x.Cins.ToLower().Contains("tahakkuk")).ToList();
            lstBoxFiles.Items.Clear();

            lstBoxFiles.Items.AddRange(ts.Select(x => x.Yol).ToArray());

        }

        private void SendToPrinter(string file)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = file;
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000);
            if (false == p.CloseMainWindow())
                p.Kill();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lstBoxFiles.Items.Count > 0)
            {
                if (MessageBox.Show(lstBoxFiles.Items.Count + " adet dosya yazıcıya gönderilecek. Onaylıyor musunuz ?", "Yazdırma Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    foreach (var item in lstBoxFiles.Items)
                    {
                        SendToPrinter(item.ToString());
                    }
            }
            else
            {
                MessageBox.Show("Liste Boş");
            }
        }

    }
}
