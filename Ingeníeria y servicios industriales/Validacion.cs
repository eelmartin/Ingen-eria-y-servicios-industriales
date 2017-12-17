using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingeníeria_y_servicios_industriales
{
    class Validacion
    {
        public void valNumerosLetras(KeyPressEventArgs e)
        {
            try
            {
                //Aqui estamos comparando las teclas que se estan precionando

                if (char.IsLetter(e.KeyChar))//Aqui comparamos las teclas que sean letras
                {
                    //Con esta opcion deja que se muestre en el texbox
                    e.Handled = false;
                }
                else
                {
                    if (char.IsControl(e.KeyChar))//Aqui comparamos que sea la tecla de borrar
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))//Aqui comparamos que sea la tecla de espacio
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            if (char.IsNumber(e.KeyChar))//Aqui comparamos las teclas que sean numeros
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                e.Handled = true;//Aqui no le permitimos que aparesca en el texbox
                            }
                        }
                    }
                }
            }
            catch (Exception w)
            {

            }
        }
        public void valNmuero(KeyPressEventArgs e)
        {
            try
            {
                //Aqui estamos comparando las teclas que se estan precionando

                if (char.IsNumber(e.KeyChar))//Aqui comparamos las teclas que sean numeros
                {
                    //Con esta opcion deja que se muestre en el texbox
                    e.Handled = false;
                }
                else
                {
                    if (char.IsControl(e.KeyChar))//Aqui comparamos que sea la tecla de borrar
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))//Aqui comparamos que sea la tecla de espacio
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;//Aqui no le permitimos que aparesca en el texbox
                        }
                    }
                }
            }
            catch (Exception w)
            {

            }
        }
        public void valLetra(KeyPressEventArgs e)
        {
            try
            {
                //Aqui estamos comparando las teclas que se estan precionando

                if (char.IsLetter(e.KeyChar))//Aqui comparamos las teclas que sean letras
                {
                    //Con esta opcion deja que se muestre en el texbox
                    e.Handled = false;
                }
                else
                {
                    if (char.IsControl(e.KeyChar))//Aqui comparamos que sea la tecla de borrar
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))//Aqui comparamos que sea la tecla de espacio
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;//Aqui no le permitimos que aparesca en el texbox
                        }
                    }
                }
            }
            catch (Exception w)
            {

            }
        }
    }
}
