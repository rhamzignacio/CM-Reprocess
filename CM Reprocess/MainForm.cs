using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CM_Reprocess
{
    public partial class MainForm : Form
    {
        string type = "";

        bool direct = false;
       
        //For menu border style
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public MainForm()
        {
            InitializeComponent();

            btnReprocess.Enabled = false;

            btnReprocess.BackColor = Color.Gray;

            pictureBoxType.Image = null;
        }

        private void MenuMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        public void Search(bool ifReprocess = true)
        {
            List<ViewAirfileModel> airfileContent = new List<ViewAirfileModel>();

            try
            {
                StartProgress();
      
                    string path = "";
                    if (type == "AMADEUS")
                    {
                        path = Properties.Settings.Default.AmadeusPath;
                    }
                    else if (type == "ABACUS")
                    {
                        path = Properties.Settings.Default.AbacusPath;
                    }
                    else if (type == "CEBUPAC")
                    {
                        path = Properties.Settings.Default.CebuPacPath;
                    }

                    //using (StreamReader readText = new StreamReader(path))
                    //{
                    string[] paths = File.ReadAllLines(path);

                    foreach (var currentPath in paths)
                    {
                        string[] MyFileList = Directory.GetFiles(@currentPath, "*.txt");

                        foreach (string file in MyFileList)
                        {
                            string textFile = File.ReadAllText(file);

                            if (textFile.Contains(txtBoxSearchKey.Text))
                            {
                                listBoxAirFile.Items.Add(file);

                                if (ifReprocess)
                                {
                                    string fileName = "";

                                    fileName = file.Replace(currentPath, "");
                                    fileName = fileName.Replace(".Txt", "");
                                    fileName = fileName.Replace(".txt", "");

                                    fileName += "REPROCESSED.Txt";

                                    //transfer to processing path
                                    if (type == "AMADEUS")
                                    {
                                        //Delete exisitng file
                                        if (direct)
                                        {
                                            File.Delete(Properties.Settings.Default.DirectAmadeusPath + "\\" + fileName);
                                            //Copy File to processing Path
                                            File.Copy(file, Properties.Settings.Default.DirectAmadeusPath + "\\" + fileName);
                                        }
                                        else
                                        {
                                            File.Delete(Properties.Settings.Default.AmadeusProcessing + "\\" + fileName);
                                            //Copy File to processing Path
                                            File.Copy(file, Properties.Settings.Default.AmadeusProcessing + "\\" + fileName);
                                        }
                                    }
                                    else if (type == "CEBUPAC")
                                    {
                                        //Delete Existing File
                                        File.Delete(Properties.Settings.Default.CebuPacProcessing + "\\" + fileName);
                                        //Copy file to processing path
                                        File.Copy(file, Properties.Settings.Default.CebuPacProcessing + "\\" + fileName);
                                    }
                                    else //Abacus
                                    {
                                        File.Delete(Properties.Settings.Default.AbacusProcessing + "\\" + fileName);
                                        //Copy File to processing Path
                                        File.Copy(file, Properties.Settings.Default.AbacusProcessing + "\\" + fileName);
                                    }

                                }//ifReprocess
                                else
                                {
                                    ViewAirfileModel airmodel = new ViewAirfileModel
                                    {
                                        FileName = file,
                                        Content = textFile
                                    };

                                    airfileContent.Add(airmodel);
                                }
                            }
                        }
                        //Exist while loop if an AirFile is found

                    }//end of while loop
                    
                CloseProgress();

                airfileContent.ForEach(item =>
                {
                    ViewAirfile viewAir = new ViewAirfile(item);

                    viewAir.Show();
                });
            }
            catch (Exception error)
            {
                CloseProgress();
                MessageBox.Show(error.Message, "Error");
            }   
              
        }

        private void ToggleSelectedButton(string _type)
        {
            btnReprocess.BackColor = Color.PaleGreen;

            btnAmadeus.BackColor = Color.FromArgb(2, 169, 224);
            btnAbacus.BackColor = Color.Red;
            btnCebuPac.BackColor = Color.Yellow;
            pictureBoxType.Image = null;

            if (_type == "AMADEUS")
            {
                btnAmadeus.BackColor = Color.DarkGray;
                pictureBoxType.Image = Properties.Resources.download; //Amadeus Logo
            }
            else if(_type == "ABACUS")
            {
                btnAbacus.BackColor = Color.DarkGray;
                pictureBoxType.Image = Properties.Resources.Sabre_logo_RGB_RED; //Abacus Logo
            }
            else if(_type == "CEBUPAC")
            {
                btnCebuPac.BackColor = Color.DarkGray;
                pictureBoxType.Image = Properties.Resources.cebu_pacific_airlines; //CebuPac Logo
            }
        }

        private void SelectType(string _type)
        {
            btnReprocess.Enabled = true;

            type = _type;

            ToggleSelectedButton(_type); 
        }

        private void btnAmadeus_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AmadeusPath != "")
                SelectType("AMADEUS");
            else
                MessageBox.Show("No path selected for Amadeus", "Warning");
        }

        private void btnAbacus_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AbacusPath != "")
                SelectType("ABACUS");
            else
                MessageBox.Show("No path selected for Abacus", "Warning");
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Option form = new Option();
            form.ShowDialog();
        }

        private void btnReprocess_Click(object sender, EventArgs e)
        {            

                btnReprocess.Enabled = false;

                listBoxAirFile.Items.Clear();

                lblErrorMessage.Visible = false;

                Search();

                if (listBoxAirFile.Items.Count == 0)
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.ForeColor = Color.Red;
                }
                else
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = "Reprocessing finished...";
                    lblErrorMessage.ForeColor = Color.Green;
                }
        }
        Loading loadingForm;

        //Loading....
        private void StartProgress()
        {
            loadingForm = new Loading(this);
            ShowProgress();
        }

        public void CloseProgress()
        { 
            btnReprocess.Enabled = true;

            Thread.Sleep(200);

            loadingForm.Invoke(new Action(loadingForm.Close));

            Visible = true;
        }

        private void ShowProgress()
        {
            try
            {
                if(this.InvokeRequired)
                {
                    try
                    {
                        loadingForm.ShowDialog();             
                    }
                    catch
                    {

                    }
                }
                else
                {
                    Thread th = new Thread(ShowProgress);
                    th.IsBackground = false;
                    th.Start();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void txtBoxSearchKey_Enter(object sender, EventArgs e)
        {
            listBoxAirFile.Items.Clear();
            lblErrorMessage.Visible = false;
        }

        private void btnDirectAmadeus_Click(object sender, EventArgs e)
        {
               
            if( type=="AMADEUS" || type == "OLD-AMADEUS")
            {
                if (Properties.Settings.Default.DirectAmadeusPath != "")
                {
                    if (btnDirectAmadeus.BackColor == Color.DarkGray)
                    {
                        btnDirectAmadeus.BackColor = Color.Red;
                        direct = false;
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to direct transfer to amadeus folder?", "Confirmation", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            btnDirectAmadeus.BackColor = Color.DarkGray;
                            direct = true;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No path selected for Direct-Amadeus", "Warning");
                }

            }
            else
            {
                MessageBox.Show("Please select amadeus to proceed", "Warning");
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCebuPac_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CebuPacPath != "")
                SelectType("CEBUPAC");
            else
                MessageBox.Show("No path selected for Cebu Pacific", "Warning");
        }

        private void txtBoxSearchKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }

        private void Add()
        {
            string errorMessage = "";

            if (txtBoxSearchKey.Text == "")
                errorMessage += "Record locator or ticket no is required\n";

            if(txtBoxSearchKey.Text.Length != 6 && txtBoxSearchKey.Text.Length != 10)
                errorMessage += "Invalid Record locator or Ticket No\n";

            if (errorMessage == "")
            {
                txtBoxSearchKey.Text = "";
            }
            else
                MessageBox.Show(errorMessage, "Error");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtBoxSearchKey.Text = txtBoxSearchKey.Text.Replace(" ", "").ToUpper();

            Add();
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Search(false);
        }
    }
}
