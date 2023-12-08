using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructurasPerú_México
{
    internal class Nodolista
    {
        private string producto;
        private double total;
        private int idorden;
        private string fechahora;
        private string estado;
        private Nodolista siguiente;

        public Nodolista() { }

        public Nodolista(string producto, double total, int idorden, string fechahora, string estado, Nodolista siguiente)
        {
            this.producto = producto;
            this.total = total;
            this.idorden = idorden;
            this.fechahora = fechahora;
            this.estado = estado;
            this.siguiente = siguiente;
        }


        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public int Idorden
        {
            get { return idorden; }
            set { idorden = value; }
        }

        public string Fechahora
        {
            get { return fechahora; }
            set { fechahora = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public Nodolista Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }


    }
}
