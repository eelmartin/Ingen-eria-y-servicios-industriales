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
    public partial class ucCarteraP : UserControl
    {

        private static ucCarteraP _instance;

        public static ucCarteraP Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new ucCarteraP();
                return _instance;

            }
        }
        public ucCarteraP()
        {
            InitializeComponent();
            Capa.DATOS.Cliente cliente = null;
            Capa.BL.Interfaces.ICliente icliente = new Capa.BL.Clases.Cliente();
            List<Capa.DATOS.Cliente> lista = icliente.listarCliente();
            for (int i = 0; i < lista.Count; i++)
            {
                cliente = lista[i];
                cmb_cliente.Items.Add(cliente.nombreCliente);
            }
            Capa.BL.Interfaces.IProyecto iproyecto = new Capa.BL.Clases.Proyecto();
            dataG_ConsultaGProyectos.DataSource = iproyecto.listarProyecto();
        }

        private void txt_nomp_TextChanged(object sender, EventArgs e)
        {

        }
        Validacion val = new Validacion();
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nomp.Text=="" || cb_tipo.SelectedIndex == -1 || txtb_descripcion.Text=="" || cmb_cliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Ha dejado un campo vacio ");
                }
                else
                {
                    Capa.BL.Interfaces.ICliente icliente = new Capa.BL.Clases.Cliente();
                    Capa.DATOS.Cliente clienteaux = icliente.buscarCliente(cmb_cliente.SelectedItem.ToString());


                    Capa.BL.Interfaces.IProyecto iproyecto = new Capa.BL.Clases.Proyecto();
                    Capa.DATOS.Proyecto proyecto = new Capa.DATOS.Proyecto
                    {
                        numeroProyecto = 1,
                        nombreProyecto = txt_nomp.Text,
                        descripcion = txtb_descripcion.Text,
                        idCliente = clienteaux.idCliente,
                        estadoProyecto = "Activo",
                        tipoProyecto = cb_tipo.SelectedItem.ToString(),
                        fechaInicio = dt_fecha.Value,
                        fechaFinal = dt_fecha.Value,
                        abono = 0,
                        manodeObra = 0,
                    };
                    iproyecto.insertarProyecto(proyecto);
                    MessageBox.Show("Proyecto registrado");
                    txt_nomp.Text = "";
                    txtb_descripcion.Text = "";
                    cb_tipo.SelectedIndex = -1;
                    cmb_cliente.SelectedIndex = -1;
                }
            }catch(Exception a)
            {
                MessageBox.Show("Error: " + a.ToString());
            }
        }

        private void btn_Actu_Click(object sender, EventArgs e)
        {
            Capa.BL.Interfaces.IProyecto iproyecto = new Capa.BL.Clases.Proyecto();
            dataG_ConsultaGProyectos.DataSource = iproyecto.listarProyecto();
        }

        private void txt_nomp_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
