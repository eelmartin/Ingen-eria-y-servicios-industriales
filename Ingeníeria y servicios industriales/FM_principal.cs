using System;
using Capa.DATOS.Templates;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingeníeria_y_servicios_industriales
{
    public partial class Pantalla : Form
    {
        public Pantalla()
        {
            InitializeComponent();
            
            pn_principal.Controls.Add(ucInicio.Instance);
            ucInicio.Instance.Dock = DockStyle.Fill;
            ucInicio.Instance.BringToFront();
        }

        private void btn_CDP_MouseMove(object sender, MouseEventArgs e) { }
        private void btn_CDP_MouseLeave(object sender, EventArgs e) { }
        private void btn_cliente_MouseMove(object sender, MouseEventArgs e) {}
        private void btn_cliente_MouseLeave(object sender, EventArgs e){}
        private void btn_proveedores_MouseMove(object sender, MouseEventArgs e){ }
        private void btn_proveedores_MouseLeave(object sender, EventArgs e){}
        private void btn_OrdenC_MouseMove(object sender, MouseEventArgs e) {}
        private void btn_OrdenC_MouseLeave(object sender, EventArgs e){}
        private void btn_OrdenS_MouseMove(object sender, MouseEventArgs e){}
        private void btn_OrdenS_MouseLeave(object sender, EventArgs e) {}
        private void btn_cotizacion_MouseMove(object sender, MouseEventArgs e) {}
        private void btn_cotizacion_MouseLeave(object sender, EventArgs e) {}


        private void btn_CDP_Click(object sender, EventArgs e)
        {
            //Cambiar color del boton
            btn_CDP.BackColor = Color.FromArgb(34, 111, 238);
            pintarBotones(2);
            //activar boton de regresar
            btn_regresar.Visible = true;
            //Mostrar el control de cartera de proyectos
            if (!pn_principal.Controls.Contains(ucCarteraP.Instance))
            {
                pn_principal.Controls.Add(ucCarteraP.Instance);
                ucCarteraP.Instance.Dock = DockStyle.Fill;
                ucCarteraP.Instance.BringToFront();

            }
            else {
                ucCarteraP.Instance.BringToFront();
            }
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            //Cambiar color del boton
            btn_cliente.BackColor = Color.FromArgb(34, 111, 238);
            pintarBotones(3);
            //activar boton de regresar
            btn_regresar.Visible = true;
            //Mostrar el control de clientes
            if (!pn_principal.Controls.Contains(ucClientes.Instance))
            {
                pn_principal.Controls.Add(ucClientes.Instance);
                ucClientes.Instance.Dock = DockStyle.Fill;
                ucClientes.Instance.BringToFront();
                
            }
            else {
                ucClientes.Instance.BringToFront();
            }
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            //Cambiar color del boton
            btn_proveedores.BackColor = Color.FromArgb(34, 111, 238);
            pintarBotones(4);
            //activar boton de regresar
            btn_regresar.Visible = true;
            //Mostrar el control de proveedores
            if (!pn_principal.Controls.Contains(ucProveedores.Instance))
            {
                pn_principal.Controls.Add(ucProveedores.Instance);
                ucProveedores.Instance.Dock = DockStyle.Fill;
                ucProveedores.Instance.BringToFront();
                
            }
            else {
                ucProveedores.Instance.BringToFront();
                
            }
        }

        private void btn_OrdenS_Click(object sender, EventArgs e)
        {
            //Cambiar color del boton
            btn_OrdenS.BackColor = Color.FromArgb(34, 111, 238);
            pintarBotones(6);
            //activar boton de regresar
            btn_regresar.Visible = true;
            //Mostrar el control Orden de Servicio
            if (!pn_principal.Controls.Contains(ucOrdenServicio.Instance))
            {
                pn_principal.Controls.Add(ucOrdenServicio.Instance);
                ucOrdenServicio.Instance.Dock = DockStyle.Fill;
                ucOrdenServicio.Instance.BringToFront();

            }
            else
            {
                ucOrdenServicio.Instance.BringToFront();

            }


        }

        private void btn_OrdenC_Click(object sender, EventArgs e)
        {
            //Cambiar color del boton
            btn_OrdenC.BackColor = Color.FromArgb(34, 111, 238);
            pintarBotones(5);
            //activar boton de regresar
            btn_regresar.Visible = true;
            //Mostrar el control de orden de compra
            if (!pn_principal.Controls.Contains(ucOrdenCompra.Instance))
            {
                pn_principal.Controls.Add(ucOrdenCompra.Instance);
                ucOrdenCompra.Instance.Dock = DockStyle.Fill;
                ucOrdenCompra.Instance.BringToFront();

            }
            else {
                ucOrdenCompra.Instance.BringToFront();

            }
        }

        private void btn_cotizacion_Click(object sender, EventArgs e)
        {
            //Cambiar color del boton
            btn_cotizacion.BackColor = Color.FromArgb(34, 111, 238);
            pintarBotones(7);
            //activar boton de regresar
            btn_regresar.Visible = true;
            //Mostrar el control de Cotización
            if (!pn_principal.Controls.Contains(ucCotizacion.Instance))
            {
                pn_principal.Controls.Add(ucCotizacion.Instance);
                ucCotizacion.Instance.Dock = DockStyle.Fill;
                ucCotizacion.Instance.BringToFront();

            }
            else
            {
                ucCotizacion.Instance.BringToFront();

            }

        }

        private void pn_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            //Cambiar color del boton
            btn_inicio.BackColor = Color.FromArgb(34, 111, 238);
            pintarBotones(1);

            btn_regresar.Visible = false;
            //Mostrar el control de Inicio
            if (!pn_principal.Controls.Contains(ucInicio.Instance))
            {
                pn_principal.Controls.Add(ucInicio.Instance);
                ucInicio.Instance.Dock = DockStyle.Fill;
                ucInicio.Instance.BringToFront();

            }
            else {
                ucInicio.Instance.BringToFront();

            }
        }

        private void pintarBotones(int op)
        {
            if (op == 1)
            {
                btn_CDP.BackColor = Color.Transparent;
                btn_cliente.BackColor = Color.Transparent;
                btn_proveedores.BackColor = Color.Transparent;
                btn_OrdenC.BackColor = Color.Transparent;
                btn_OrdenS.BackColor = Color.Transparent;
                btn_cotizacion.BackColor = Color.Transparent;
            }
            if(op == 2)
            {
                btn_inicio.BackColor = Color.Transparent;
                btn_cliente.BackColor = Color.Transparent;
                btn_proveedores.BackColor = Color.Transparent;
                btn_OrdenC.BackColor = Color.Transparent;
                btn_OrdenS.BackColor = Color.Transparent;
                btn_cotizacion.BackColor = Color.Transparent;
            }
            if (op == 3)
            {
                btn_CDP.BackColor = Color.Transparent;
                btn_inicio.BackColor = Color.Transparent;
                btn_proveedores.BackColor = Color.Transparent;
                btn_OrdenC.BackColor = Color.Transparent;
                btn_OrdenS.BackColor = Color.Transparent;
                btn_cotizacion.BackColor = Color.Transparent;
            }
            if (op == 4)
            {
                btn_CDP.BackColor = Color.Transparent;
                btn_cliente.BackColor = Color.Transparent;
                btn_inicio.BackColor = Color.Transparent;
                btn_OrdenC.BackColor = Color.Transparent;
                btn_OrdenS.BackColor = Color.Transparent;
                btn_cotizacion.BackColor = Color.Transparent;
            }
            if (op == 5)
            {
                btn_CDP.BackColor = Color.Transparent;
                btn_cliente.BackColor = Color.Transparent;
                btn_proveedores.BackColor = Color.Transparent;
                btn_inicio.BackColor = Color.Transparent;
                btn_OrdenS.BackColor = Color.Transparent;
                btn_cotizacion.BackColor = Color.Transparent;
            }
            if (op == 6)
            {
                btn_CDP.BackColor = Color.Transparent;
                btn_cliente.BackColor = Color.Transparent;
                btn_proveedores.BackColor = Color.Transparent;
                btn_OrdenC.BackColor = Color.Transparent;
                btn_inicio.BackColor = Color.Transparent;
                btn_cotizacion.BackColor = Color.Transparent;
            }
            if (op == 7)
            {
                btn_CDP.BackColor = Color.Transparent;
                btn_cliente.BackColor = Color.Transparent;
                btn_proveedores.BackColor = Color.Transparent;
                btn_OrdenC.BackColor = Color.Transparent;
                btn_OrdenS.BackColor = Color.Transparent;
                btn_inicio.BackColor = Color.Transparent;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            pn_principal.Controls.Add(ucInicio.Instance);
            ucInicio.Instance.Dock = DockStyle.Fill;
            ucInicio.Instance.BringToFront();
            btn_regresar.Visible = false;
            btn_inicio.BackColor = Color.FromArgb(34, 111, 238);
            pintarBotones(1);
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {
         
        }

        
    }
}
