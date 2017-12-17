using Capa.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DATOS;

namespace Capa.BL.Clases
{
    public class Cliente : ICliente
    {
        public void insertarCliente(DATOS.Cliente cliente)
        {
            DS.Interfaces.ICliente icliente = new DS.Clases.Cliente();
            icliente.insertarCliente(cliente);
        }

        public List<DATOS.Cliente> listarCliente()
        {
            DS.Interfaces.ICliente icliente= new DS.Clases.Cliente();
            return icliente.listarCliente();
        }

        public void modificarCliente(DATOS.Cliente cliente)
        {
            DS.Interfaces.ICliente icliente = new DS.Clases.Cliente();
            icliente.modificarCliente(cliente);
        }

        public DATOS.Cliente buscarCliente(string nombre)
        {
            Capa.DATOS.Cliente cliente= null;
            DS.Interfaces.ICliente icliente = new DS.Clases.Cliente();
            List<DATOS.Cliente> lista = icliente.listarCliente();
            for (int i=0;i<lista.Count;i++)
            {
                cliente = lista[i];
                if(cliente.nombreCliente.CompareTo(nombre)==0)
                {
                    break;
                }
                else
                {
                    cliente = null;
                }
            }
            
            
            return cliente;
        }

               

    }
}
