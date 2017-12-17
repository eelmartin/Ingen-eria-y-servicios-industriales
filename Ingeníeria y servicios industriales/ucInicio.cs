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
    public partial class ucInicio : UserControl
    {

        private static ucInicio _instance;

        public static ucInicio Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new ucInicio();
                return _instance;

            }
        }
        public ucInicio()
        {
            InitializeComponent();
        }
    }
}
