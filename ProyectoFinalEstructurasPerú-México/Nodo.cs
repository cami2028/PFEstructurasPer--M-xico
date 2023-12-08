using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructurasPerú_México
{
    public class Nodo
    {
        public string producto;
        public int numeropedido;
        public double preciobebida;
        public double preciocombo;
        public string fechahora;

        public Nodo siguiente;


        public Nodo() { }
        public Nodo(string producto, int numeropedido, double preciobebida, double preciocombo, string fechahora, Nodo siguiente)
        {
            this.producto = producto;
            this.numeropedido = numeropedido;
            this.preciobebida = preciobebida;
            this.preciocombo = preciocombo;
            this.fechahora = fechahora;
            this.siguiente = siguiente;
        }

        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int Numeropedido
        {
            get { return numeropedido; }
            set { numeropedido = value; }
        }

        public double Preciobebida
        {
            get { return preciobebida; }
            set { preciobebida = value; }
        }

        public double Preciocombo
        {
            get { return preciocombo; }
            set { preciocombo = value; }
        }

        public string Fechahora
        {
            get { return fechahora; }
            set { fechahora = value; }
        }

        public Nodo Siguinte
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

    }
}
