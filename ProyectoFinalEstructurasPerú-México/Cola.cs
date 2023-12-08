using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProyectoFinalEstructurasPerú_México
{

    public class Cola
    {
        private Nodo inicio;
        private Nodo final;
        public int count;

        public Cola()
        {
            inicio = null;
            final = null;
            count = 0;
        }

        public void Encolar(string producto, int numpedido, double preciobebida, double preciocombo, string fechahora)
        {
            Nodo nuevo = new Nodo(producto, numpedido, preciobebida, preciocombo, fechahora, null);

            if (inicio == null && final == null)
            {
                inicio = nuevo;
            }
            else
            {
                final.Siguinte = nuevo;
            }
            final = nuevo;
            count++;
        }

        public string MostrarcolaProductoGeneral()
        {
            string datos = "";
            Nodo temp = inicio;
            while (temp != null)
            {

                datos = temp.Producto + "|" + (temp.Preciobebida * temp.Preciocombo).ToString() + "|" + temp.Numeropedido.ToString() + "|" + temp.Fechahora;
                temp = temp.Siguinte;
            }
            return datos;
        }

        public string Desencolar()
        {
            string datos = "";
            Nodo temp = inicio;
            inicio = inicio.Siguinte;
            temp.Siguinte = null;
            count--;
            datos = temp.Producto + "|" + (temp.Preciobebida * temp.Preciocombo).ToString() + "|" + temp.Numeropedido.ToString() + "|" + temp.Fechahora + "|" + "Atendido";
            return datos;
        }


        public bool Vacio()
        {
            return (count == 0) ? true : false;
        }

    }
}
