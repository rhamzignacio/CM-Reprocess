using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CM_Reprocess
{
    public partial class Option : Form
    {
        //For menu border style
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public Option()
        {
            InitializeComponent();

            //Properties.Settings.Default.AmadeusProcessing = "\\\\192.168.0.6\\GDS Air Files\\Amadeus";
            //Properties.Settings.Default.AbacusProcessing = "\\\\192.168.0.6\\GDS Air Files\\Abacus";
            //Properties.Settings.Default.AbacusPath = "\\\\192.168.0.102\\iur";
            //Properties.Settings.Default.AmadeusPath = "\\\\192.168.0.104\\Copy";
            //Properties.Settings.Default.OldAmadeusPath = "\\\\192.168.0.104\\Airfile backup\\Amadeus\\2015";
            //Properties.Settings.Default.OldAbacusPath = "\\\\192.168.0.102\\2015 Air Files";

            Properties.Settings.Default.Save();

            GetPath();
        }
        private void MenuMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void GetPath()
        {
            //Abacus Path
            txtBoxAbacusPath.Text = Properties.Settings.Default.AbacusPath;
            //Amadeus Path
            txtBoxAmadeusPath.Text = Properties.Settings.Default.AmadeusPath;
            //Amadeus Processing
            txtBoxAmadeusProcessing.Text = Properties.Settings.Default.AmadeusProcessing;
            //Abacus Processing
            txtBoxAbacusProcessing.Text = Properties.Settings.Default.AbacusProcessing;
            //Direct Amadeus Path
            txtBoxDirectAmadeus.Text = Properties.Settings.Default.DirectAmadeusPath;
            //Cebu Pacific Path
            txtBoxOldAmadeusPath.Text = Properties.Settings.Default.CebuPacPath;
            //Cebu Pacific Processing Path
            txtBoxOldAbacusPath.Text = Properties.Settings.Default.CebuPacProcessing;
        }

        private string SelectPath()
        {
            FolderBrowserDialog result = new FolderBrowserDialog();

            if (result.ShowDialog() == DialogResult.OK)
            {
                return result.SelectedPath;
            }
            else
                return "";
        }

        private void btnAmadeusPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxAmadeusPath.Text = fileDialog.FileName;

                Properties.Settings.Default.AmadeusPath = fileDialog.FileName;

                Properties.Settings.Default.Save();
            }
        }

        private void btnAbacusPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxAbacusPath.Text = fileDialog.FileName;

                Properties.Settings.Default.AbacusPath = fileDialog.FileName;

                Properties.Settings.Default.Save();
            }
        }

        private void btnOldAmadeusPath_Click(object sender, EventArgs e) //Cebu Pacific Path
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxOldAmadeusPath.Text = fileDialog.FileName;

                Properties.Settings.Default.CebuPacPath = fileDialog.FileName;

                Properties.Settings.Default.Save();
            }
        }

        private void btnOldAbacusPath_Click(object sender, EventArgs e) //Cebu Pacific Processing Path
        {
            string path = SelectPath();

            if (path != "")
            {
                txtBoxOldAbacusPath.Text = path;

                Properties.Settings.Default.CebuPacProcessing = path;

                Properties.Settings.Default.Save();
            }
        }

        private void btnAmadeusProcessing_Click(object sender, EventArgs e)
        {
            string path = SelectPath();

            if (path != "")
            {
                txtBoxAmadeusProcessing.Text = path;

                Properties.Settings.Default.AmadeusProcessing = path;

                Properties.Settings.Default.Save();
            }
        }

        private void btnAbacusProcessing_Click(object sender, EventArgs e)
        {
            string path = SelectPath();

            if (path != "")
            {
                txtBoxAbacusProcessing.Text = path;

                Properties.Settings.Default.AbacusProcessing = path;

                Properties.Settings.Default.Save();
            }
        }

        private void txtBoxAmadeusPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AmadeusPath = txtBoxAmadeusPath.Text;

            Properties.Settings.Default.Save();
        }

        private void txtBoxAbacusPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AbacusPath = txtBoxAbacusPath.Text;

            Properties.Settings.Default.Save();
        }

        private void txtBoxOldAmadeusPath_TextChanged(object sender, EventArgs e) //Cebu Pacific Path
        {
            Properties.Settings.Default.CebuPacPath = txtBoxOldAmadeusPath.Text;

            Properties.Settings.Default.Save();
        }

        private void txtBoxOldAbacusPath_TextChanged(object sender, EventArgs e) //Cebu Pacific Processing Path
        {
            Properties.Settings.Default.CebuPacProcessing = txtBoxOldAbacusPath.Text;

            Properties.Settings.Default.Save();
        }

        private void txtBoxAmadeusProcessing_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AmadeusProcessing = txtBoxAmadeusProcessing.Text;

            Properties.Settings.Default.Save();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxAbacusProcessing_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AbacusProcessing = txtBoxAbacusProcessing.Text;

            Properties.Settings.Default.Save();
        }

        private void txtBoxDirectAmadeus_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DirectAmadeusPath = txtBoxDirectAmadeus.Text;

            Properties.Settings.Default.Save();
        }

        private void btnDirectAmadeus_Click(object sender, EventArgs e)
        {
            string path = SelectPath();

            if (path != "")
            {
                txtBoxDirectAmadeus.Text = path;

                Properties.Settings.Default.DirectAmadeusPath = path;

                Properties.Settings.Default.Save();
            }
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
