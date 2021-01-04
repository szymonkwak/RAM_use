using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using RAM_use.Properties;

namespace RAM_use
{
    public partial class Form1 : Form
    {
        Int64 totalM; //Cały RAM komputera
        Int64 actualValueM; //Aktualne użycie ramu
        Warning warnForm = new Warning();
        AppSettings settingsForm = new AppSettings();
        int timerWarningCounter; //Zlicza "tiki" zegara timerWarning.

        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerRAM.Start(); //Start timera
            this.TopMost = true; //Zawsze na wierzchu
            totalM = PerformanceInfo.GetTotalMemoryInMiB(); //Pobierz ile jest pamięci w kompie
            //Ustal minimalny czas co ile wyskoczy powiadomienie:
            timerWarning.Interval = int.Parse(Settings.Default["WarningTime"].ToString()) * 60000;

        }

        private void timerRAM_Tick(object sender, EventArgs e)
        {
            actualValueM = PerformanceInfo.GetPhysicalAvailableMemoryInMiB(); //Ile teraz jest dostępne pamięci
            double percentOccupied = (((double)totalM - (double)actualValueM) * 100 / (double)totalM); //Zajęta pamięć procentowo

            #region Wyswietlanie [% RAM] na ProgessBar i Label

            progressBarRAM.Value = (int)percentOccupied;
            string prctOcc = String.Format("{0:0}%", percentOccupied);
            labelPercent.Text = prctOcc;

            #endregion

            #region Wyswietlenie warningu 

            if (timerWarningCounter >= 1)
            {
                timerWarning.Stop();
            }

            if (percentOccupied > double.Parse(Settings.Default["WarningValue"].ToString()) && timerWarning.Enabled == false)
            //Tutaj pobieram wartość z ustawień projektu (WarninngValue)
            {
                warnForm.Show();
                timerWarningCounter = 0;
                timerWarning.Start();

            }
            #endregion

        }

        private void timerWarning_Tick(object sender, EventArgs e)
        {
            timerWarningCounter++;
        }

        #region Tray Context Menu

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            this.Close();
            warnForm.Close();
            settingsForm.Close();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
        }
        #endregion


        #region Możliwość przesuwania głównego okna

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        
    }
}
