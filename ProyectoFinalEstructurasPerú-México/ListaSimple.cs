using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProyectoFinalEstructurasPerú_México
{
    internal class ListaSimple
    {
        private Nodolista raiz;
        public int count;

        public ListaSimple()
        {
            raiz = null;
            count = 0;
        }

        public bool Vacio()
        {
            return (count == 0) ? true : false;
        }


        public void InsertarEnLista(string producto, double total, int idorden, string fechahora, string estado)
        {

            Nodolista nuevo = new Nodolista(producto, total, idorden, fechahora, estado, null);
            Nodolista temp = new Nodolista();

            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                temp = raiz;
                while(temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
            }
            count++;
        }

        public string MostrarLista()
        {
            string info = "";
            Nodolista temp = raiz;
            if(temp != null)
            {
                while(temp != null)
                {
                    info  = temp.Producto + "|" + temp.Total.ToString() +"|"+temp.Idorden.ToString() +"|"+temp.Fechahora+"|"+temp.Estado;
                    temp = temp.Siguiente;
                }
            }
            return info;
        }

        public string BuscarInfo(int idorden)
        {
            string info = "";
            Nodolista temp = raiz;
            bool Encontrado = false;
            if (raiz != null)
            {
                while (temp != null && Encontrado != true)
                {
                    if (temp.Idorden == idorden)
                    {
                        info = "Producto: " + temp.Producto + "\n" + "Total :" + temp.Total.ToString() + "\n" + "ID Orden:" + temp.Idorden.ToString() + "\n" + "Fecha - Hora:" + temp.Fechahora + "\n" + "Estado:" + temp.Estado;
                        Encontrado = true;
                    }
                    temp =  temp.Siguiente;
                }
                if (!Encontrado)
                {
                    MessageBox.Show("ID producto ingresado no Encontrado");
                }
            }
            return info;
        }

        
        public void Vaciar()
        {
           
            Nodolista temp = raiz;
            Nodolista ant = null;
            if (temp != null)
            {
                while (temp != null)
                {
                    if(temp == raiz)
                    {
                        raiz = raiz.Siguiente;
                        Vaciar();
                    }
                    else if(raiz == temp)
                    {
                        ant.Siguiente = null;
                        temp = ant;
                    }
                    else
                    {
                        ant.Siguiente = raiz.Siguiente;
                    }

                    ant = raiz;
                    raiz = ant.Siguiente;
                }
                
            }
            count--;
        }
    }
}
