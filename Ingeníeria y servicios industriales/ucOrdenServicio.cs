using System;
using Capa.DATOS.Templates;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Ingeníeria_y_servicios_industriales
{
    public partial class ucOrdenServicio : UserControl
    {
        private static ucOrdenServicio _instance;
        public static ucOrdenServicio Instance
            
        {

            get
            {
                if (_instance == null)
                    _instance = new ucOrdenServicio();
                return _instance;

            }

        }
        public int idProveedorBD = 0;

        public ucOrdenServicio()
        {
            InitializeComponent();
            Capa.DATOS.Proveedor proveedor = null;
            Capa.BL.Interfaces.IProveedor iproveedor = new Capa.BL.Clases.Proveedor();
            List<Capa.DATOS.Proveedor> lista = iproveedor.listarProveerdor();
            for (int i = 0; i < lista.Count; i++)
            {
                proveedor = lista[i];
                cmb_proveedor.Items.Add(proveedor.nombrePro);
            }
            Capa.DATOS.Proyecto proyecto = null;
            Capa.BL.Interfaces.IProyecto iproyecto = new Capa.BL.Clases.Proyecto();
            List<Capa.DATOS.Proyecto> lista2 = iproyecto.listarProyecto();
            for (int i = 0; i < lista.Count; i++)
            {
                proyecto = lista2[i];
                cmb_nproyecto.Items.Add(proyecto.nombreProyecto);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int r1 = 0, r2 = 0, t = 0;
            r1 = int.Parse(txt_precio.Text);
            t = r1 * r2;
            dgv_servicios.Rows.Insert(0, txt_concepto.Text, txt_precio.Text, comboBox1.Text, txt_precio.Text);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" + "ted Security=True");
            con3.Open();
            string str = "select * from Proveedor where NombrePro='" + cmb_proveedor.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con3);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_rfc.Text = dr["NombrePro"].ToString();//column name should be that you want to show on textbox
                txt_colonia.Text = dr["ColoniaPro"].ToString();
                txt_telefono.Text = dr["TelefonoPro"].ToString();
                txt_calle.Text = dr["CallePro"].ToString();
                txt_numero.Text = dr["NumeroLocalPro"].ToString();
                txt_correo.Text = dr["CorreoElecPro"].ToString();
                idProveedorBD = int.Parse(dr["idProveedor"].ToString());
            }
        }

        private void btn_generarorden_Click(object sender, EventArgs e)
        {
            Capa.BL.Interfaces.IProveedor iProveedor = new Capa.BL.Clases.Proveedor();
            Capa.DATOS.Proveedor proveedor = iProveedor.buscarProveedor(cmb_proveedor.SelectedIndex.ToString());
            Capa.BL.Interfaces.IOrdendeServicio iorden = new Capa.BL.Clases.OrdendeServicio();
            Capa.DATOS.OrdendeServicio orden1 = new Capa.DATOS.OrdendeServicio
            {
                idOrdendeServicio = 0,
                IdProveedor = proveedor.idProveedor,
                NumProyecto = Int32.Parse(txt_numproyecto.Text)
            };
            iorden.insertarOrdendeServicio(orden1);

            for (int i = 0; i < dgv_servicios.RowCount; i++)
            {

            }


            try
            {


                Capa.BL.Interfaces.IServicios iservicios = new Capa.BL.Clases.Servicios();
                Capa.BL.Interfaces.IOrdendeServicio iordendeServicio = new Capa.BL.Clases.OrdendeServicio();

                Capa.DATOS.OrdendeServicio orden = new Capa.DATOS.OrdendeServicio
                {
                    idOrdendeServicio = 1,
                    IdProveedor = idProveedorBD,
                    NumProyecto = 2,
                    totalS = 500,
                };
                iordendeServicio.insertarOrdendeServicio(orden);
                Capa.DATOS.Materiales material = new Capa.DATOS.Materiales
                {

                };
                List<int> lst = new List<int>();
                SqlConnection con = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" + "ted Security=True");
                SqlConnection con2 = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" + "ted Security=True");
                string consulta = "SELECT idOrdenDeCompra FROM OrdenDeCompra WHERE idOrdenDeCompra = (SELECT MAX(idOrdenDeCompra) FROM OrdenDeCompra) ORDER BY idOrdenDeCompra";
                SqlCommand cm1 = new SqlCommand(consulta, con2);
                con2.Open();
                SqlDataReader reader = cm1.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(reader.GetInt32(0));
                }
                reader.Close();
                con2.Close();
                int valorDB = lst[0];
                //int idOrdendeCompra = Convert.ToInt32(consulta);
                for (int i = 0; i < dgv_servicios.Rows.Count - 1; i++)
                {
                    //SqlCommand OrdenCompraBD = new SqlCommand(@"SELECT idOrdenDeCompra FROM OrdenDeCompra WHERE idOrdenDeCompra = (SELECT MAX(idOrdenDeCompra) FROM OrdenDeCompra) ORDER BY idOrdenDeCompra",con);
                    //String aux = OrdenCompraBD.ToString();
                    //int idOrden = int.Parse(aux);
                    string str = dgv_servicios.Rows[i].Cells[0].Value.ToString();
                    int val2 = Convert.ToInt32(dgv_servicios.Rows[i].Cells[1].Value.ToString());
                    String val3 = dgv_servicios.Rows[i].Cells[2].Value.ToString();
                    String val4 = dgv_servicios.Rows[i].Cells[3].Value.ToString();
                    String val5 = dgv_servicios.Rows[i].Cells[4].Value.ToString();
                    //String val1 = dgv_materiales.Rows[i].Cells[0].Value.ToString();
                    //int val2= (int)dgv_materiales.Rows[i].Cells[1].Value;
                    //int val3= (int)dgv_materiales.Rows[i].Cells[2].Value;
                    //int val5 = (int)dgv_materiales.Rows[i].Cells[3].Value;
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Servicios (NomServicio, CantidadMat, PrecioMat, idOrdenCompra, Unidad, TotalCant) VALUES ('" + str + "','" + val2 + "','" + val3 + "','" + valorDB + "','" + val4 + "','" + val5 + "')", con);
                    //SqlCommand cmd = new SqlCommand(@"INSERT INTO Materiales (NomMateriales, CantidadMat, PrecioMat, idOrdenCompra, TotalCant) VALUES ('" + dgv_materiales.Rows[i].Cells[0].Value + "','" + (int)(dgv_materiales.Rows[i].Cells[1].Value) + "','" + (float)dgv_materiales.Rows[i].Cells[2].Value + "','" + idOrdendeCompra + "','" + (float)dgv_materiales.Rows[i].Cells[3].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

                MessageBox.Show("Orden registrada");
                dgv_servicios.Rows.Clear();


            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.ToString());
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_nproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" + "ted Security=True");
            con4.Open();
            string str = "select * from Proyecto where NombreProyecto='" + cmb_nproyecto.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con4);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_numproyecto.Text = dr["NumeroProyecto"].ToString();//column name should be that you want to show on textbox
            }
        }
    }
}
