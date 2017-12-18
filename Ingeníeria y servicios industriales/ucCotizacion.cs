using System;
using System.Collections.Generic;
using Capa.DATOS.Templates;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Ingeníeria_y_servicios_industriales
{
    public partial class ucCotizacion : UserControl
    {
        int totalGeneral = 0;
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

        //declaración de variables a utilizar para el export a PDF
        public string nombrecliente = "", rfc = "", correo = "", telefono = "", colonia = "", calle = "", numero = "", descripcion="";
        public string concepto = "", cantidad = "", precio = "", total = "";

        public ucCotizacion()
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
        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=MARTINSOTOPC;Initial Catalog=IngenieriayServiciosIndustriales;Integra" + "ted Security=True");
            con3.Open();
            string str = "select * from Cliente where NombreCliente='" + cmb_cliente.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con3);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_rfc.Text = dr["RfcCliente"].ToString();//column name should be that you want to show on textbox
                txt_colonia.Text = dr["ColoniaCliente"].ToString();
                txt_telefono.Text = dr["TelefonoCliente"].ToString();
                txt_calle.Text = dr["CalleCliente"].ToString();
                txt_numero.Text = dr["NumeroLocalCliente"].ToString();
                txt_correo.Text = dr["CorreoElectronicoCliente"].ToString();               
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int r1 = 0, r2 = 0, t = 0;
            r1 = int.Parse(txt_precio.Text);
            r2 = int.Parse(txt_cantidad.Text);
            t = r1 * r2;
            totalGeneral = totalGeneral + t;
            lbl_total.Text = totalGeneral.ToString();
            dgv_materialservicio.Rows.Insert(0, txt_concepto.Text, txt_cantidad.Text, txt_precio.Text, t);
            concepto = concepto + txt_concepto.Text + "\n";
            cantidad = cantidad + txt_cantidad.Text + "\n";
            precio = precio + txt_precio.Text + "\n";
            total = total + t + "\n";
        }

        private void btn_generarcotizacion_Click(object sender, EventArgs e)
        {
            int no = 0;
            Random r = new Random();

            nombrecliente = cmb_cliente.Text;
            rfc = txt_rfc.Text;
            correo = txt_correo.Text;
            telefono = txt_telefono.Text;
            colonia = txt_colonia.Text;
            calle = txt_calle.Text;
            numero = txt_numero.Text;
            descripcion = txt_descripcion.Text;
            var TEST_OBJECT = new FormatoCotizacion(nombrecliente, rfc, telefono, correo, colonia, calle, numero, descripcion,  concepto, cantidad, precio, total, totalGeneral);//Creamos un objeto para el formato de compra que irá al archivo pdf
            // string TEST_PATH = Path.GetTempFileName();
            no = r.Next(1,999);
            String nombre = "Cotizacion-" + nombrecliente +"-"+ no + ".pdf";
            string TEST_PATH = "C:/Users/Ed/Desktop/" + nombre;
            Capa.BL.Helpers.PdfHandler.CrearPDF(TEST_OBJECT, TEST_PATH);

            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("david_osoxd@hotmail.com");
            mail.To.Add("martin_antonio_@hotmail.com");
            mail.Subject = "Envio de Cotización";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = "Envío de orden de compra generado";
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("david_osoxd@hotmail.com", "Pedroputo1!");
            SmtpServer.EnableSsl = true;
            mail.Attachments.Add(new Attachment(TEST_PATH));


            try
            {
                SmtpServer.Send(mail);
                MessageBox.Show("Cotización enviada con éxito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar");
            }
        }
    }
}
