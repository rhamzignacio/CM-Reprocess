using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CM_Reprocess
{
    public partial class ViewAirfile : Form
    {
        public ViewAirfile(ViewAirfileModel _airModel)
        {
            InitializeComponent();

            lblHeader.Text = "Client Magic Reprocess - " + _airModel.FileName;

            ViewContent(_airModel.Content);
        }

        private void ViewContent(string _airfileContent)
        {
            richTxtBoxContent.Text = _airfileContent;
        }
    }
}
