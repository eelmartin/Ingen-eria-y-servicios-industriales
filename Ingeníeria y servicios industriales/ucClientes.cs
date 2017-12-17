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
    public partial class ucClientes : UserControl
    {


        private static ucClientes _instance;

        public static ucClientes Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new ucClientes();
                return _instance;

            }
        }

        public ucClientes()
        {
            InitializeComponent();
        }

        private void btn_consultarC_Click(object sender, EventArgs e)
        {
            Capa.BL.Interfaces.ICliente icliente = new Capa.BL.Clases.Cliente();
            dgv_ConsultaC.DataSource = icliente.listarCliente();

        }
        Validacion val = new Validacion();
        private void btn_regCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nomC.Text == "" || txt_colC.Text == "" || txt_calleC.Text == "" || txt_numC.Text == "" || txt_telC.Text == "" || txt_correoC.Text == "" || mtb_CR.Text == "")
                {
                    MessageBox.Show("Ha dejado un campo vacio ");
                }
                else
                {
                    Capa.BL.Interfaces.ICliente icliente = new Capa.BL.Clases.Cliente();
                    Capa.DATOS.Cliente cliente = new Capa.DATOS.Cliente
                    {
                        idCliente = 0,
                        nombreCliente = txt_nomC.Text,
                        coloniaCliente = txt_colC.Text,
                        calleCliente = txt_calleC.Text,
                        numeroLocalCliente = txt_numC.Text,
                        telefonoCliente = txt_telC.Text,
                        correoElectronicoCliente = txt_correoC.Text,
                        rfcCliente = mtb_CR.Text
                    };
                    icliente.insertarCliente(cliente);
                    MessageBox.Show("Cliente registrado");
                    txt_nomC.Text = "";
                    txt_colC.Text = "";
                    txt_calleC.Text = "";
                    txt_numC.Text = "";
                    txt_telC.Text = "";
                    txt_correoC.Text = "";
                    mtb_CR.Text = "";
                }
            }catch(Exception x)
            {
                MessageBox.Show("Error: "+x.ToString());
            }
        }

        private void btn_modificarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nomCM.Text == "" || txt_colCM.Text == "" || txt_calleCM.Text == "" || txt_numCM.Text == "" || txt_telCM.Text == "" || txt_correoCM.Text == "" || mtb_CM.Text == "")
                {
                    MessageBox.Show("Ha dejado un campo vacio ");
                }
                else
                {
                    Capa.BL.Interfaces.ICliente icliente = new Capa.BL.Clases.Cliente();
                    Capa.DATOS.Cliente clienteaux = icliente.buscarCliente(txt_nombreCM.Text);
                    Capa.DATOS.Cliente cliente = new Capa.DATOS.Cliente
                    {
                        idCliente = clienteaux.idCliente,
                        nombreCliente = txt_nomCM.Text,
                        coloniaCliente = txt_colCM.Text,
                        calleCliente = txt_calleCM.Text,
                        numeroLocalCliente = txt_numCM.Text,
                        telefonoCliente = txt_telCM.Text,
                        correoElectronicoCliente = txt_correoCM.Text,
                        rfcCliente = mtb_CM.Text
                    };
                    icliente.modificarCliente(cliente);
                    MessageBox.Show("Cliente modificado");
                    txt_nomCM.Enabled = false;
                    txt_colCM.Enabled = false;
                    txt_calleCM.Enabled = false;
                    txt_numCM.Enabled = false;
                    txt_telCM.Enabled = false;
                    txt_correoCM.Enabled = false;
                    mtb_CM.Enabled = false;
                    txt_nombreCM.Enabled = true;
                    txt_nombreCM.Text = "";
                    txt_nomCM.Text = "";
                    txt_colCM.Text = "";
                    txt_calleCM.Text = "";
                    txt_numCM.Text = "";
                    txt_telCM.Text = "";
                    txt_correoCM.Text = "";
                    mtb_CM.Text = "";
                    
                }
            }catch(Exception r)
            {
                MessageBox.Show("Error: " + r.ToString());
            }
        }


        private void btn_busCM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombreCM.Text=="")
                {
                    MessageBox.Show("Ha dejado un campo vacio ");
                }
                else
                {
                    Capa.BL.Interfaces.ICliente icliente = new Capa.BL.Clases.Cliente();
                    Capa.DATOS.Cliente cliente = icliente.buscarCliente(txt_nombreCM.Text);
                    if (cliente == null)
                    {
                        MessageBox.Show("Cliente No Encontrado");
                        txt_nomCM.Text = "";
                        txt_colCM.Text = "";
                        txt_calleCM.Text = "";
                        txt_numCM.Text = "";
                        txt_telCM.Text = "";
                        txt_correoCM.Text = "";
                        mtb_CM.Text = "";
                    }
                    else
                    {
                        txt_nomCM.Text = cliente.nombreCliente;
                        txt_colCM.Text = cliente.coloniaCliente;
                        txt_calleCM.Text = cliente.calleCliente;
                        txt_numCM.Text = cliente.numeroLocalCliente;
                        txt_telCM.Text = cliente.telefonoCliente;
                        txt_correoCM.Text = cliente.correoElectronicoCliente;
                        mtb_CM.Text = cliente.rfcCliente;
                        txt_nomCM.Enabled = true;
                        txt_colCM.Enabled = true;
                        txt_calleCM.Enabled = true;
                        txt_numCM.Enabled = true;
                        txt_telCM.Enabled = true;
                        txt_correoCM.Enabled = true;
                        mtb_CM.Enabled = true;
                        txt_nombreCM.Enabled = false;
                     
                    }
                }
            }catch(Exception a)
            {
                MessageBox.Show("Error: " + a.ToString());
            }
        }

      

        private void dgv_ConsultaC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_nomC_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_colC_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_calleC_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_numC_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNmuero(e);
        }

        private void txt_telC_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNmuero(e);
        }

        private void txt_nomCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_colCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_calleCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void txt_numCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNmuero(e);
        }

        private void txt_telCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNmuero(e);
        }

        private void txt_idCM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
