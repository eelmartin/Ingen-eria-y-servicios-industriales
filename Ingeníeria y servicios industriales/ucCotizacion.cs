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
    public partial class ucCotizacion : UserControl
    {

        private static ucCotizacion _instance;
        public static ucCotizacion Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new ucCotizacion();
                return _instance;

            }
        }

        public ucCotizacion()
        {
            InitializeComponent();
        }

        
    }
}
