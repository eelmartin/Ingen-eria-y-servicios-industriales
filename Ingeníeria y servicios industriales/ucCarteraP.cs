using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ingeníeria_y_servicios_industriales
{
    public partial class ucCarteraP : UserControl
    {
        string idCliente = "";
        int mt = 0;
        int mo = 0;
        int st = 0;
        int totalFinal = 0;

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
                cmb_cliente2.Items.Add(cliente.nombreCliente);
            }
            Capa.BL.Interfaces.IProyecto iproyecto = new Capa.BL.Clases.Proyecto();
            dataG_ConsultaGProyectos.DataSource = iproyecto.listarProyecto();

            Capa.DATOS.Proyecto proyecto = null;//Creamos una capa tipo proyecto
            List<Capa.DATOS.Proyecto> lista2 = iproyecto.listarProyecto();//Creamos una lista con nuestro contenido de proyecto en la capa de datos
            for (int i = 0; i < lista2.Count; i++)//Iniciamos nuestro ciclo para obtener datos
            {
                proyecto = lista2[i];//Guarda todos los proyectos en una lista
                cmb_proyecto.Items.Add(proyecto.nombreProyecto);//Nos añade los proyectos a nuestra lista
            }


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
            dataG_ConsultaGProyectos.DataSource = null;
            dataG_ConsultaGProyectos.Refresh();
            dataG_ConsultaGProyectos.Rows.Clear();
            Capa.BL.Interfaces.IProyecto iProyecto = new Capa.BL.Clases.Proyecto();
            dataG_ConsultaGProyectos.DataSource = iProyecto.listarProyecto();
        }

        private void btn_Actu_Click(object sender, EventArgs e)
        {
            //Capa.BL.Interfaces.IProyecto iproyecto = new Capa.BL.Clases.Proyecto();
            //dataG_ConsultaGProyectos.DataSource = iproyecto.listarProyecto();
        }

        private void txt_nomp_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.valNumerosLetras(e);
        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_proyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_compra.DataSource = null;
            dgv_compra.Refresh();
            dgv_compra.Rows.Clear();
            mt = 0;
            mo = 0;
            st = 0;
            totalFinal = 0;

            string nProyecto = "";
            SqlConnection con3 = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" + "ted Security=True");//Establecemos parámetros de conexión
            con3.Open();//Iniciamos la conexión
            string str = "select * from Proyecto where NombreProyecto='"+cmb_proyecto.Text+"'";//establecemos el query a ejecutar            
            SqlCommand cmd = new SqlCommand(str, con3);//Ejecutamos el query en la conexión establecidas
            SqlDataReader dr=cmd.ExecuteReader();//Establecemos un datareader, que leerá los datos extraidos de la consulta
            if(dr.Read())//Mientras exista contenido que leer, realizará lo siguiente
            {
                txt_nombre.Text=dr["NombreProyecto"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_rfc
                txt_descripcion.Text = dr["Descripcion"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_colonia
                txt_monto.Text = dr["Abono"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_telefono
                txt_fechaInicio.Text = dr["FechaInicio"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_calle
                txt_fechaFin.Text = dr["FechaFinal"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_numero
                txt_tipo.Text = dr["TipoProyecto"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_correo
                txt_estado.Text = dr["EstadoProyecto"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_correo
                idCliente = dr["idCliente"].ToString();
                nProyecto = dr["NumeroProyecto"].ToString();

            }
            dr.Close();

            string str2 = "select * from Cliente where idCliente='" + idCliente + "'";//establecemos el query a ejecutar
            SqlCommand cmd2 = new SqlCommand(str2, con3);//Ejecutamos el query en la conexión establecidas
            SqlDataReader dr2 = cmd2.ExecuteReader();//Establecemos un datareader, que leerá los datos extraidos de la consulta
            if (dr2.Read())//Mientras exista contenido que leer, realizará lo siguiente
            {
                txt_nombreCliente.Text = dr2["NombreCliente"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_rfc
                
            }
            dr2.Close();

            string strx = "select count(*) from OrdenDeCompra where NumProyecto='" + nProyecto + "'";
            cmd.CommandText = "select count(*) from OrdenDeCompra where NumProyecto='" + nProyecto + "'";
            Int32 count = (Int32)cmd.ExecuteScalar();

            string str3 = "select * from OrdenDeCompra where NumProyecto='" + nProyecto + "'";//establecemos el query a ejecutar
            SqlCommand cmd3 = new SqlCommand(str3, con3);//Ejecutamos el query en la conexión establecidas
            SqlDataReader dr3 = cmd3.ExecuteReader();//Establecemos un datareader, que leerá los datos extraidos de la consulta
            if (dr3.Read())//Mientras exista contenido que leer, realizará lo siguiente
            {
                mt = mt + int.Parse(dr3["TotalC"].ToString());
            }
            var dataTable = new DataTable();
            dataTable.Load(dr3);

            dgv_compra.DataSource = dataTable;
            dr3.Close();

            string str4 = "select * from OrdenDeServicio where NumProyecto='" + nProyecto + "'";//establecemos el query a ejecutar
            SqlCommand cmd4 = new SqlCommand(str4, con3);//Ejecutamos el query en la conexión establecidas
            SqlDataReader dr4 = cmd4.ExecuteReader();//Establecemos un datareader, que leerá los datos extraidos de la consulta
            if (dr4.Read())//Mientras exista contenido que leer, realizará lo siguiente
            {
                mt = mt + int.Parse(dr4["TotalS"].ToString());
            }
            var dataTable2 = new DataTable();
            dataTable2.Load(dr4);

            dgv_servicio.DataSource = dataTable2;
            dr4.Close();
            lbl_mto.Text = mt.ToString();


        }

        private void btn_CEbuscar_Click(object sender, EventArgs e)
        {

        }

        private void cmb_cliente2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" + "ted Security=True");//Establecemos parámetros de conexión
            con3.Open();
            string str2 = "select * from Cliente where NombreCliente='" + cmb_cliente2.Text + "'";//establecemos el query a ejecutar
            SqlCommand cmd6 = new SqlCommand(str2, con3);//Ejecutamos el query en la conexión establecidas
            SqlDataReader dr6 = cmd6.ExecuteReader();//Establecemos un datareader, que leerá los datos extraidos de la consulta
            if (dr6.Read())//Mientras exista contenido que leer, realizará lo siguiente
            {
                idCliente = dr6["idCliente"].ToString();
            }
            dr6.Close();

           
            string str4 = "select * from Proyecto where idCliente='" + idCliente + "'";//establecemos el query a ejecutar
            SqlCommand cmd4 = new SqlCommand(str4, con3);//Ejecutamos el query en la conexión establecidas
            SqlDataReader dr4 = cmd4.ExecuteReader();//Establecemos un datareader, que leerá los datos extraidos de la consulta
            
            var dataTable2 = new DataTable();
            dataTable2.Load(dr4);

            dgv_proyecto2.DataSource = dataTable2;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
