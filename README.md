# TopluYazdir

            var adobe = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows").OpenSubKey("CurrentVersion").OpenSubKey("App Paths").OpenSubKey("AcroRd32.exe");
            var path = adobe.GetValue("");

            var adobeOtherWay = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Classes").OpenSubKey("acrobat").OpenSubKey("shell").OpenSubKey("open").OpenSubKey("command");
            var pathOtherWay = adobeOtherWay.GetValue("");


            Process process = new Process();

            process.StartInfo.FileName = @"C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe";


            string strFileName = pdfPath;

            string filename = strFileName;

            process.StartInfo.Arguments = "/p /h \"" + filename + "\" \"" + getPrinterName() + " \""; //"/t " + @"C:\test.pdf" // "HP LaserJet 1022n"; // "/t " + @"c:\SSN.pdf"; //"\"" + @"c:\SSN.pdf" + "\"" + " \"" + "HP LaserJet 1022n" + "\""; // "\t " + @"C:\SSN.pdf" + " HP LaserJet 1022n";

            process.StartInfo.CreateNoWindow = true;

            process.StartInfo.RedirectStandardOutput = true;

            process.StartInfo.UseShellExecute = false;

            process.Start();

            process.CloseMainWindow();
