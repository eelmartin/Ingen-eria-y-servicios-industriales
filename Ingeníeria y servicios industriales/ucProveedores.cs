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
    public partial class ucProveedores : UserControl
    {


        private static ucProveedores _instance;

        public static ucProveedores Instance
        {

            get
            {
                if(_instance == null)
                    _instance = new ucProveedores();
                return _instance;
                
            }
        }




        public ucProveedores()
        {
            InitializeComponent();
            Capa.BL.Interfaces.IProveedor iProveedor = new Capa.BL.Clases.Proveedor();
            BindingSource bs = new BindingSource();
            bs.DataSource = iProveedor.listarProveerdor();            
            dgvProveedor.DataSource = bs;
            bs.ResetBindings(false);

        }

        private void ucProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btn_consultaP_Click(object sender, EventArgs e)
        {
            
        }
        Validacion val = new Validacion();
        private void btn_registrarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombrePro.Text == "" || mtb_PR.Text == "" || txt_coloniaPro.Text == "" || txt_callePro.Text == "" || txt_numeroLocalPro.Text == "" || txt_telefonoPro.Text == "" || txt_correoElecPro.Text == "")
                {
                    MessageBox.Show("Ha dejado un campo vacio ");
                }
                else
                {
                    Capa.BL.Interfaces.IProveedor iProveedor = new Capa.BL.Clases.Proveedor();
                    Capa.DATOS.Proveedor proveedor = new Capa.DATOS.Proveedor
                    {
                        idProveedor = 0,
                        nombrePro = txt_nombrePro.Text,
                        rfcPro = mtb_PR.Text,
                        coloniaPro = txt_coloniaPro.Text,
                        callePro = txt_callePro.Text,
                        numeroLocalPro = txt_numeroLocalPro.Text,
                        telefonoPro = txt_telefonoPro.Text,
                        correoElecPro = txt_correoElecPro.Text
                    };
                    iProveedor.insertarProveedor(proveedor);
                    MessageBox.Show("Proveedor registrado");


                    txt_nombrePro.Text = "";
                    mtb_PR.Text = "";
                    txt_coloniaPro.Text = "";
                    txt_callePro.Text = "";
                    txt_numeroLocalPro.Text = "";
                    txt_telefonoPro.Text = "";
                    txt_correoElecPro.Text = "";
                }
            }catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void btn_modificarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nomPM.Text=="")
                {
                    MessageBox.Show("Ha dejado un campo vacio ");
                }
                else
                {
                    String rfc="";
                    rfc = mtb_PM.Text;
                    Capa.BL.Interfaces.IProveedor iProveedor = new Capa.BL.Clases.Proveedor();
                    Capa.DATOS.Proveedor proveedoraux = iProveedor.buscarProveedor(txt_nombrePM.Text);
                    Capa.DATOS.Proveedor proveedor = new Capa.DATOS.Proveedor
                    {
                        idProveedor = proveedoraux.idProveedor,
                        nombrePro = txt_nomPM.Text,
                        rfcPro = rfc,
                        coloniaPro = txt_colPM.Text,
                        callePro = txt_callePM.Text,
                        numeroLocalPro = txt_numPM.Text,
                        telefonoPro = txt_telPM.Text,
                        correoElecPro = txt_correoPM.Text
                    };
                    iProveedor.modificarProveedor(proveedor);
                    MessageBox.Show("Proveedor modificado");
                    txt_nomPM.Enabled = false;
                    mtb_PR.Enabled = false;
                    txt_colPM.Enabled = false;
                    txt_callePM.Enabled = false;
                    txt_numPM.Enabled = false;
                    txt_telPM.Enabled = false;
                    txt_correoPM.Enabled = false;
                    txt_nomPM.Text = "";
                    mtb_PR.Text = "";
                    txt_colPM.Text = "";
                    txt_callePM.Text = "";
                    txt_numPM.Text = "";
                    txt_telPM.Text = "";
                    txt_correoPM.Text = "";
                    txt_nombrePM.Text = "";
                    txt_nombrePM.Enabled = true;
                    mtb_PM.Enabled = false;
                    mtb_PM.Text = "";
                }
            }catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }


        private void btn_buscarPM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombrePM.Text=="")
                {
                    MessageBox.Show("Ha dejado un campo vacio ");
                }
                else
                {
                    Capa.BL.Interfaces.IProveedor iProveedor = new Capa.BL.Clases.Proveedor();
                    Capa.DATOS.Proveedor proveedor = iProveedor.buscarProveedor(txt_nombrePM.Text);
                    if (proveedor == null)
                    {
                        MessageBox.Show("Proveedor No Encontrado");
                        txt_nomPM.Text = "";
                        txt_colPM.Text = "";
                        txt_callePM.Text = "";
                        txt_numPM.Text = "";
                        txt_telPM.Text = "";
                        txt_correoPM.Text = "";
                        mtb_PM.Text = "";
                    }
                    else
                    {
                        txt_nomPM.Text = proveedor.nombrePro;
                        txt_colPM.Text = proveedor.coloniaPro;
                        txt_callePM.Text = proveedor.callePro;
                        txt_numPM.Text = proveedor.numeroLocalPro;
                        txt_telPM.Text = proveedor.telefonoPro;
                        txt_correoPM.Text = proveedor.correoElecPro;
                        mtb_PM.Text = proveedor.rfcPro;
                        txt_nomPM.Enabled = true;
                        txt_colPM.Enabled = true;
                        txt_callePM.Enabled = true;
                        txt_numPM.Enabled = true;
                        txt_telPM.Enabled = true;
                        txt_correoPM.Enabled = true;
                        mtb_PM.Enabled = true;
                        txt_nombrePM.Enabled = false;
                        mtb_PM.Enabled = true;
                    }
                }
            }catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void txt_nombrePro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_coloniaPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_callePro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_numeroLocalPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNmuero(e);
        }

        private void txt_telefonoPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNmuero(e);
        }

        private void txt_nomPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_colPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_callePM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_numPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNmuero(e);
        }
    }
}
