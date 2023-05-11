using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio() 
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(EPuesto.Caja1);
        }

        public Negocio(string nombre): this() 
        {
            this.nombre = nombre;
        }

        

        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            if (negocio != cliente) 
            {
                negocio.clientes.Enqueue(cliente);
                return true;
            }
            return false;
            
        }

        public Cliente Cliente
        {
            get { return this.clientes.Peek(); }
            set { bool clienteAgregado = this + value; }
        }

        public int ClientesPendientes 
        {
            get { return this.clientes.Count; }
        }

        public static bool operator ==(Negocio negocio, Cliente cliente) 
        {
            foreach (Cliente cliente2 in negocio.clientes)
            {
                if (cliente == cliente2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio negocio, Cliente cliente) 
        {
            return !(negocio == cliente);
        }

        public static bool operator ~(Negocio negocio) 
        {
            if (negocio.caja.Atender(negocio.Cliente)) 
            {
                negocio.clientes.Dequeue();
            }
            return true;
        }
    }
}
