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



namespace Ingeníeria_y_servicios_industriales //Declaración del nombre del proyecto
{
    public partial class ucOrdenCompra : UserControl //Creación de la clase parcial ucOrdenCompra, que extiende a control de usuario
    {
        //creación de instancias tipo pública y privada de ucOrdenCompra
        private static ucOrdenCompra _instance;
        public static ucOrdenCompra Instance
        
        {
            get //inicialización del menú instanciándolo a una del mismo tipo
            {
                if (_instance == null)
                    _instance = new ucOrdenCompra();
                return _instance;

            }
        }

        //declaración de variables a utilizar para el export a PDF
        public string nombreprov = "", rfc = "", correo = "", telefono = "", colonia = "", calle = "", numero = "";
        public int numOrden = 0, numProy = 0;

        private void txt_numeroPOC_TextChanged(object sender, EventArgs e)
        {

        }

        //Declaración del método del combobox, si la selección del nombre del proyecto cambia, ejecutará lo siguiente
        private void cmb_nproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" + "ted Security=True");//Creamos conexión a la BD
            con4.Open();//Abrimos la conexión
            string str = "select * from Proyecto where NombreProyecto='" + cmb_nproyecto.Text + "'"; //Establecemos el query a ejecutar
            SqlCommand cmd = new SqlCommand(str, con4); //Mandamos los parámetros en un comando SQL con nuestro respectivo query y conexión
            SqlDataReader dr = cmd.ExecuteReader(); //ejecutamos nuestro query
            if (dr.Read()) //en caso de respuesta, haremos lo siguiente
            {
                txt_numeroPOC.Text = dr["NumeroProyecto"].ToString();//Guarda lo obtenido en la variable
            }
        }

        public int idProveedorBD = 0; //inicializamos nuestra variable que nos servirá para obtener datos de la BD

        //Aquí se establece el contenido del menú con sus respectivas acciones
        public ucOrdenCompra()
        {
            InitializeComponent();//Inicializamos todos los componentes gráficos
            Capa.DATOS.Proveedor proveedor = null; //creamos una capa tipo proveedor y la inicializamos 
            Capa.BL.Interfaces.IProveedor iproveedor = new Capa.BL.Clases.Proveedor();//Creamos una capa de interfaz tipo IProveedor
            List<Capa.DATOS.Proveedor> lista = iproveedor.listarProveerdor();//Creamos una lista con nuestro contenido de proveedor en la capa de datos
            for (int i = 0; i < lista.Count; i++)//Iniciamos nuestro ciclo para obtener datos
            {
                proveedor = lista[i];//Nos guarda todos los proveedores en una lista
                cmb_proveedor.Items.Add(proveedor.nombrePro);//Nos añade los proveedores a nuestra lista
            }
            Capa.DATOS.Proyecto proyecto = null;//Creamos una capa tipo proyecto
            Capa.BL.Interfaces.IProyecto iproyecto = new Capa.BL.Clases.Proyecto();//Creamos una capa de intergaz tipo IProyecto
            List<Capa.DATOS.Proyecto> lista2 = iproyecto.listarProyecto();//Creamos una lista con nuestro contenido de proyecto en la capa de datos
            for (int i = 0; i < lista.Count; i++)//Iniciamos nuestro ciclo para obtener datos
            {
                proyecto = lista2[i];//Guarda todos los proyectos en una lista
                cmb_nproyecto.Items.Add(proyecto.nombreProyecto);//Nos añade los proyectos a nuestra lista
            }
        }

        private void button1_Click(object sender, EventArgs e)//Establecemos lo que hará nuestro botón PDF
        {
              Capa.BL.Interfaces.IProveedor iProveedor = new Capa.BL.Clases.Proveedor();//Creamos una capa de interfaz IProveedor
              Capa.DATOS.Proveedor proveedor = iProveedor.buscarProveedor(cmb_proveedor.SelectedIndex.ToString());//Creamos una capa de datos para Proveedor
              Capa.BL.Interfaces.IOrdendeCompra iorden = new Capa.BL.Clases.OrdendeCompra();//Creamos una capa de interfaz para Orden de compra
              Capa.DATOS.OrdendeCompra orden1 = new Capa.DATOS.OrdendeCompra//Creamos una capa de datos para Orden de compra
              {
                  idOrdendeCompra = 0,//Inicializamos el valor de idOrdendeCompra, ya que al ser autoincremental es necesario mandarle una variable aunque esta no la tome
                  idProveedor = idProveedorBD,//Le damos valor a nuestro idProveedor que se registrará, tomando como valor el idProveedor de una consulta que hacemos en nuestra BD
                  NumProyecto = Int32.Parse(txt_numeroPOC.Text)//Obtenemos el número de proyecto del campo de texto numeroPOC
              };
              iorden.insertarOrdendeCompra(orden1);//Insertamos los elementos en la orden de compra

            
            /*
            try//Iniciamos nuestro try/catch
            {


                Capa.BL.Interfaces.IMateriales imateriales = new Capa.BL.Clases.Materiales();//Creamos nuestra capa de interfaces para IMateriales
                Capa.BL.Interfaces.IOrdendeCompra iordendeCompra = new Capa.BL.Clases.OrdendeCompra();//Creamos nuestra capa de interfaces para IOrdendeCompra
               
                Capa.DATOS.OrdendeCompra orden = new Capa.DATOS.OrdendeCompra//Creamos nuestra capa de datos para OrdendeCompra         
                {
                    idOrdendeCompra = 1,//Le asignamos valor a nuestra orden de compra, en este caso lo establecemos con un valor por default ya que la BD de igual manera lo hace autoincremental, pero es necesario mandar el parámetro
                    idProveedor = idProveedorBD,//Le damos valor a nuestro idProveedor que se registrará, tomando como valor el idProveedor de una consulta que hacemos en nuestra BD
                    NumProyecto = 2,
                    totalC = 500,
                    };
                iordendeCompra.insertarOrdendeCompra(orden);
                Capa.DATOS.Materiales material = new Capa.DATOS.Materiales
            {
            

            };
             */   

            List<int> lst = new List<int>();//Creamos una lista con el nombre lst
            SqlConnection con = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" +"ted Security=True");//Establecemos el nombre de la conexión y la BD a usar para una consulta
            SqlConnection con2 = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" + "ted Security=True");//Establecemos el nombre de la conexión y la BD a usar para una segunda consulta
            string consulta = "SELECT idOrdenDeCompra FROM OrdenDeCompra WHERE idOrdenDeCompra = (SELECT MAX(idOrdenDeCompra) FROM OrdenDeCompra) ORDER BY idOrdenDeCompra";//Establecemos los criterios de nuestra consulta en un string
            SqlCommand cm1 = new SqlCommand(consulta, con2);//Realizamos nuestra consulta
            con2.Open();//abrimos la conexión
            SqlDataReader reader = cm1.ExecuteReader();//ejecutamos la consulta
            while (reader.Read())//Mientras lea datos, va a realizar lo siguiente
            {
                lst.Add(reader.GetInt32(0));//Agrega nuestro valor a la lista, según lo obtenido por la consulta
            }
            reader.Close();//cierra nuestra lectura del while
            con2.Close();//cierra la conexión
            int valorDB = lst[0];//inicializamos nuestro valorDB y le asignamos el valor de la posición 0 de nuestra lista
            for (int i=0; i< dgv_materiales.Rows.Count-1; i++)//inicia cilo para insertar datos de un DataGridView
            {
                string str = dgv_materiales.Rows[i].Cells[0].Value.ToString();//le damos valor al string str de la posición 0 de nuestro DataGridView
                int val2 = Convert.ToInt32(dgv_materiales.Rows[i].Cells[1].Value.ToString());//le damos valor al int val2 de la posición 1 de nuestro DataGridView
                String val3 = dgv_materiales.Rows[i].Cells[2].Value.ToString();//le damos valor al string val3 de la posición 2 de nuestro DataGridView
                String val4 = dgv_materiales.Rows[i].Cells[3].Value.ToString(); //le damos valor al string val4 de la posición 3 de nuestro DataGridView
                String val5 = dgv_materiales.Rows[i].Cells[4].Value.ToString(); //le damos valor al string val5 de la posición 4 de nuestro DataGridView
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Materiales (NomMateriales, CantidadMat, PrecioMat, idOrdenCompra, Unidad, TotalCant) VALUES ('"+ str+"','"+ val2+"','" + val3 + "','" + valorDB + "','" + val4 + "','" + val5 + "')", con);//Establecemos nuestro query de insert según los valores obtenidos de nuestro DataGridView
                con.Open();//Abrimos nuestra conexión
                cmd.ExecuteNonQuery();//ejecutamos el query
                con.Close();//cerramos conexión
                
            }

                    MessageBox.Show("Orden registrada");//Mostramos el mensaje de orden registrada
                    dgv_materiales.Rows.Clear();//Limpiamos el DataGridView

            /*
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.ToString());
            }
            */

        }

        private void cmb_proveedor_SelectedIndexChanged(object sender, EventArgs e) //Establecemos una acción para nuestro combobox cmb_proveedor en caso de que el contenido cambie
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" + "ted Security=True");//Establecemos parámetros de conexión
            con3.Open();//Iniciamos la conexión
            string str = "select * from Proveedor where NombrePro='"+cmb_proveedor.Text+"'";//establecemos el query a ejecutar
            SqlCommand cmd = new SqlCommand(str, con3);//Ejecutamos el query en la conexión establecidas
            SqlDataReader dr=cmd.ExecuteReader();//Establecemos un datareader, que leerá los datos extraidos de la consulta
            if(dr.Read())//Mientras exista contenido que leer, realizará lo siguiente
            {
                txt_rfc.Text=dr["NombrePro"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_rfc
                txt_colonia.Text = dr["ColoniaPro"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_colonia
                txt_telefono.Text = dr["TelefonoPro"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_telefono
                txt_calle.Text = dr["CallePro"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_calle
                txt_numero.Text = dr["NumeroLocalPro"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_numero
                txt_correo.Text = dr["CorreoElecPro"].ToString();//Extraemos valor de la BD y lo colocamos en nuestro txt_correo
                idProveedorBD = int.Parse(dr["idProveedor"].ToString());//Extraemos valor del idProveedor que utilizaremos para obtener el proveedor al cual le haremos el pedido de orden de compra
            }

        }


        public void obtenrDatos()
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            

            //obtener los datos para el archivo pdf a crear
            rfc = txt_rfc.Text;
            correo = txt_correo.Text;
            telefono = txt_telefono.Text;
            colonia = txt_colonia.Text;
            calle = txt_calle.Text;
            numero = txt_numero.Text;
            numProy = int.Parse(txt_numeroPOC.Text);
            nombreprov = cmb_proveedor.Text;
            String concepto = "concepto", unidad = "unidad", cantidad="cantidad", precio = "precio", total = "total";

            var TEST_OBJECT = new FormatoCompra(numProy, nombreprov, rfc, telefono, correo, colonia, calle, numero, concepto, cantidad, unidad, precio, total);//Creamos un objeto para el formato de compra que irá al archivo pdf
            // string TEST_PATH = Path.GetTempFileName();
            String nombre = "compra" + numProy + ".pdf";
            string TEST_PATH = "C:/Users/Ed/Desktop/" + nombre;
            Capa.BL.Helpers.PdfHandler.CrearPDF(TEST_OBJECT, TEST_PATH);
        }

        private void btn_agregar_Click(object sender, EventArgs e)//Establecemos lo que hará nuestro botón de agregar
        {
            // Insertamos las tuplas en la tabla
            int r1 = 0, r2 = 0, t=0;
            r1 = int.Parse(txt_precio.Text);
            r2 = int.Parse(txt_cantidad.Text);
            t = r1 * r2;
            dgv_materiales.Rows.Insert(0, txt_concepto.Text, txt_cantidad.Text, txt_precio.Text, comboBox1.Text, t);
        }
    }
}
