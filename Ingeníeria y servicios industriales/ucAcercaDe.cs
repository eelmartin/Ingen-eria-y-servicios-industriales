using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingeníeria_y_servicios_industriales
{
    public partial class ucAcercaDe : UserControl
    {
        private static ucAcercaDe _instance;

        public static ucAcercaDe Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new ucAcercaDe();
                return _instance;

            }
        }


        public ucAcercaDe()
        {
            InitializeComponent();
        }


        private void lbl_martin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:martin.soto11@uabc.edu.mx");
        }

        private void lbl_abraham_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:abraham.miranda@uabc.edu.mx");
        }

        private void lbl_jesus_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:jesus.miranda8@uabc.edu.mx");
        }
    }
}
