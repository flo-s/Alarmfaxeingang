using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarmfaxeingang
{
    public partial class Form1 : Form
    {
        int iTicks = 0, maxTicks = 10;
        public Form1()
        {
            InitializeComponent();
            timer.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void buttonMinimieren_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
                buttonMinimieren.Location = new Point(((this.Width - 8) / 2) - 38, this.Height - 75);
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void buttonEingang_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtEingang.Text))
                Process.Start(txtEingang.Text);
            else
                MessageBox.Show("Eingangsordner existiert nicht");
        }

        private void buttonZiel_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtZiel.Text))
                Process.Start(txtZiel.Text);
            else
                MessageBox.Show("Zielordner existiert nicht");
        }

        private void buttonArchiv_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtArchiv.Text))
                Process.Start(txtArchiv.Text);
            else
                MessageBox.Show("Zielordner existiert nicht");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (iTicks == maxTicks)
            {
                timer.Stop();

                txtTicks.Text = "Ordner wird überprüft";
                Application.DoEvents();

                // check for new file
                CheckFolder();
                System.Threading.Thread.Sleep(1000);

                iTicks = 0;
                timer.Start();
            }
            else
            {
                txtTicks.Text = "Orderprüfung in " + (maxTicks - iTicks) + " Sekunden";

                iTicks++;
            }
        }
        private void NeueMeldung(string text)
        {
            txtVerlauf.Text = DateTime.Now.ToString("dd.mm.yyyy, HH:mm") + ": " + text + Environment.NewLine + txtVerlauf.Text;
            Application.DoEvents();
        }
        private void KonvertiereDatei(string fileWithPath)
        {
            string file = Path.GetFileName(fileWithPath);
            string target = txtZiel.Text + (txtZiel.Text.EndsWith("\\") ? "" : "\\") + file.Replace("sff", "tif");

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFilesX86), "IrfanView", "i_view32.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = fileWithPath + " /convert=" + target;


                using (Process proc = Process.Start(startInfo))
                {
                    proc.WaitForExit();
                }

                NeueMeldung("Datei " + file + " konvertiert");
            }
            catch
            {
                NeueMeldung("Konvertierungsfehler bei " + file);
            }
        }

        void Hochladen(string sourcefile)
        {
            try
            {
                string file = Path.GetFileName(sourcefile);
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://feuerwehr-kienberg.de/faxe/" + Path.GetFileName(file));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("", "");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;
                using (FileStream stream = File.OpenRead(sourcefile))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    stream.Close();
                    using (Stream reqStream = request.GetRequestStream())
                    {
                        reqStream.Write(buffer, 0, buffer.Length);
                        reqStream.Close();
                        NeueMeldung("Datei " + file + " hochgeladen");
                    }
                }
            }
            catch (Exception ex)
            {
                NeueMeldung("Upload fehlgeschlagen, " + sourcefile);
            }
        }

        void Informieren(string file)
        {
            try
            {
                //WebClient client = new WebClient();
                //string downloadString = client.DownloadString("https://ssl.webpack.de/app.feuerwehr-kienberg.de/index.php?modul=fax&authcode=&fax=" + Path.GetFileName(file));
                NeueMeldung("Kollegen informiert");
            }
            catch
            {
                NeueMeldung("Fehler beim Informieren");
            }
        }
        void Verschieben(string fileWithPath)
        {
            string file = Path.GetFileName(fileWithPath);
            string target = txtArchiv.Text + (txtArchiv.Text.EndsWith("\\") ? "" : "\\") + file;

            try
            {
                File.Move(fileWithPath, target);
                NeueMeldung("Datei " + file + " archiviert");
            }
            catch
            {
                NeueMeldung("Datei konnte nicht verschoben werden, " + file);
            }
        }

        private void CheckFolder()
        {
            if (Directory.Exists(txtEingang.Text))
            {
                string[] files = Directory.GetFiles(txtEingang.Text, "*.sff");
                if (files.Length > 0)
                {
                    NeueMeldung(files.Length + " Dateien gefunden");
                    foreach (string file in files)
                    {
                        KonvertiereDatei(file);
                        Hochladen(file);
                        Informieren(file);
                        Verschieben(file);
                    }
                }
                files = null;
            }
        }
    }
}
