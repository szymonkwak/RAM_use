using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAM_use.Properties;

namespace RAM_use
{
    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();

            //Pobiera z ustawień programu wartości które są ustalone przez użytkownika i pokazuje je
            comboBoxPercent.Text = ($"{Settings.Default["WarningValue"].ToString()}%");
            comboBoxMinTime.Text = ($"{Settings.Default["WarningTime"].ToString()}min");

        }
        

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Zadaję wartość użycia RAM, kiedy wyskoczy powiadomienie i zapisuję do ustawień programu
            switch (comboBoxPercent.Text)
            {
                case "75%":
                    Settings.Default["WarningValue"] = 75;
                    break;
                case "80%":
                    Settings.Default["WarningValue"] = 80;
                    break;
                case "85%":
                    Settings.Default["WarningValue"] = 85;
                    break;
                case "90%":
                    Settings.Default["WarningValue"] = 90;
                    break;
                case "95%":
                    Settings.Default["WarningValue"] = 95;
                    break;
                default:
                    Settings.Default["WarningValue"] = 85;
                    break;
                    //                    
            }

            //Zadaję minimalny czas pomiędzy wyskokiem powiadomień i zapisuję do ustawień programu
            switch (comboBoxMinTime.Text)
            {
                case "1min":
                    Settings.Default["WarningTime"] = 1;
                    break;
                case "2min":
                    Settings.Default["WarningTime"] = 2;
                    break;
                case "5min":
                    Settings.Default["WarningTime"] = 5;
                    break;
                case "10min":
                    Settings.Default["WarningTime"] = 10;
                    break;
                default:
                    Settings.Default["WarningTime"] = 5;
                    break;
            }

            Settings.Default.Save(); //Zapisuję powyższe zmiany do ustawień programu
            this.Hide();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region Możliwość przesuwania okna

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void AppSettings_MouseDown(object sender, MouseEventArgs e)
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
