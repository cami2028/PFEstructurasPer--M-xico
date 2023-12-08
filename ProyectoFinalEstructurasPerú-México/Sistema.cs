using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalEstructurasPerú_México
{
    public partial class Sistema : Form
    {
        public string producto;
        public int numpedido;
        public double preciobebida;
        public double preciocombo;
        public string fechashora;

        public Cola cola = new Cola();
        ListaSimple lista = new ListaSimple();
        int n,i;


        public Sistema()
        {
            InitializeComponent();
            cbxLitros.Enabled = false;
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {

            Random ale = new Random();
            if (alitas.Checked)
            {
                producto = "Alitas a la BBQ";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 5.3;
                preciocombo = 13.5;
                fechashora = lblFecha.Text+"-"+lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }
            if (nuggets.Checked)
            {
                producto = "Nuggets";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 6.3;
                preciocombo = 14.5;
                fechashora = lblFecha.Text + "-" + lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }

            if (papafamiliar.Checked)
            {
                producto = "Papa Familiar";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 5.45;
                preciocombo = 15.6;
                fechashora = lblFecha.Text + "-" + lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }

            if (hotwings.Checked)
            {
                producto = "Hot Wings";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 2.36;
                preciocombo = 25.6;
                fechashora = lblFecha.Text + "-" + lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }


            if (ensalada.Checked)
            {
                producto = "Ensalada Familiar";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 4.20;
                preciocombo = 10.30;
                fechashora = lblFecha.Text + "-" + lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }


            if (combo1.Checked)
            {
                producto = "Combo 1";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 3.10;
                preciocombo = 30;
                fechashora = lblFecha.Text + "-" + lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }


            if (combo2.Checked)
            {
                producto = "Combo 2";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 1.50;
                preciocombo = 19.20;
                fechashora = lblFecha.Text + "-" + lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }

            if (combo3.Checked)
            {
                producto = "Combo 3";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 6.5;
                preciocombo = 25.6;
                fechashora = lblFecha.Text + "-" + lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }
            if (combo4.Checked)
            {
                producto = "Combo 4";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 2.6;
                preciocombo = 8.6;
                fechashora = lblFecha.Text + "-" + lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }
            if (incakola.Checked)
            {
                if (cbxLitros.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese los litros que desea");
                }
                else
                {
                    producto = "Inca Kola - " + cbxLitros.Text;
                    numpedido = ale.Next(0, 100);
                    lblPedido.Text = numpedido.ToString();
                    preciobebida = 3.5;
                    preciocombo = 7.5;
                    fechashora = lblFecha.Text + "-" + lblHora.Text;
                    cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                    MessageBox.Show("Pedido realizado con exito");
                    CargarCeldas();
                }
                
            }
            if (cocacola.Checked)
            {
                if (cbxLitros.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese los litros que desea");
                }
                else
                {
                    producto = "Coca Cola - " + cbxLitros.Text;
                    numpedido = ale.Next(0, 100);
                    lblPedido.Text = numpedido.ToString();
                    preciobebida = 4.5;
                    preciocombo = 9.8;
                    fechashora = lblFecha.Text + "-" + lblHora.Text;
                    cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                    MessageBox.Show("Pedido realizado con exito");
                    CargarCeldas();
                }
                
            }

            if (fanta.Checked)
            {
                if (cbxLitros.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese los litros que desea");
                }
                else
                {
                    producto = "Fanta - " + cbxLitros.Text;
                    numpedido = ale.Next(0, 100);
                    lblPedido.Text = numpedido.ToString();
                    preciobebida = 1.20;
                    preciocombo = 4.5;
                    fechashora = lblFecha.Text + "-" + lblHora.Text;
                    cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                    MessageBox.Show("Pedido realizado con exito");
                    CargarCeldas();
                }
                
            }
            if (coronas.Checked)
            {
                producto = "Six Pack Cerv. Corona";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 1.20;
                preciocombo = 4.5;
                fechashora = lblFecha.Text + "-" + lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }
            if (estrellita.Checked)
            {
                producto = "Six Pack Cerv. Estrellita";
                numpedido = ale.Next(0, 100);
                lblPedido.Text = numpedido.ToString();
                preciobebida = 1.20;
                preciocombo = 4.5;
                fechashora = lblFecha.Text + "-" + lblHora.Text;
                cola.Encolar(producto, numpedido, preciobebida, preciocombo, fechashora);
                MessageBox.Show("Pedido realizado con exito");
                CargarCeldas();
            }

            lblContador.Text = cola.count.ToString();
            limpiar();
        }

        public void CargarCeldas()
        {
            string[] datos;
            datos = cola.MostrarcolaProductoGeneral().Split('|');
            n = tabladatos.Rows.Add();

            tabladatos.Rows[n].Cells[0].Value = datos[0];
            tabladatos.Rows[n].Cells[1].Value = datos[1];
            tabladatos.Rows[n].Cells[2].Value = datos[2];
            tabladatos.Rows[n].Cells[3].Value = datos[3];
        }
        public void limpiar()
        {

            lblPedido.ResetText();
            cbxLitros.SelectedIndex  = 0;
            combo1.Checked = false;
            combo2.Checked = false;
            combo3.Checked = false;
            combo4.Checked = false;
            alitas.Checked = false;
            nuggets.Checked = false;
            papafamiliar.Checked = false;
            hotwings.Checked = false;
            ensalada.Checked = false;
            incakola.Checked = false;
            cocacola.Checked = false;
            fanta.Checked = false;
            coronas.Checked = false;
            estrellita.Checked = false;
        }
        private void bebida1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void btnAtender_Click(object sender, EventArgs e)
        {
            
            if (!cola.Vacio())
            {
                //ARREGLO PASAR DESENCOLADOS A LISTASIMPLE
                string[] datosdesencolados;
                datosdesencolados = cola.Desencolar().Split('|');
                string producto2 = datosdesencolados[0];
                double total2 = Convert.ToDouble(datosdesencolados[1]);
                int idorden2 = Convert.ToInt32(datosdesencolados[2]);
                string fechahora2 = datosdesencolados[3];
                string estado2 = datosdesencolados[4];
                lista.InsertarEnLista(producto2, total2, idorden2, fechahora2, estado2);


                //ARREGLO MOSTRA LISTASIMPLE
                string[] mostralista;
                mostralista = lista.MostrarLista().Split('|');

                i = tablaatendidos.Rows.Add();
                tablaatendidos.Rows[i].Cells[0].Value = mostralista[0];
                tablaatendidos.Rows[i].Cells[1].Value = mostralista[1];
                tablaatendidos.Rows[i].Cells[2].Value = mostralista[2];
                tablaatendidos.Rows[i].Cells[3].Value = mostralista[3];
                tablaatendidos.Rows[i].Cells[4].Value = mostralista[4];

                lblContador.Text = cola.count.ToString();
                lblcontlist.Text = lista.count.ToString();
                tabladatos.Rows.RemoveAt(tabladatos.CurrentRow.Index);
                MessageBox.Show("Cliente atendido");
            }
            else
            {
                MessageBox.Show("No hay mas pedidos por atender");
            }

        }

        private void tablaatendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (incakola.Checked == true)
            {
                cbxLitros.Enabled = true;
            }
            else
            {
                cbxLitros.Enabled = false;
            }
        }

        private void cocacola_CheckedChanged(object sender, EventArgs e)
        {
            if (cocacola.Checked == true)
            {
                cbxLitros.Enabled = true;
            }
            else
            {
                cbxLitros.Enabled = false;
            }
        }

        private void fanta_CheckedChanged(object sender, EventArgs e)
        {
            if (fanta.Checked == true)
            {
                cbxLitros.Enabled = true;
            }
            else
            {
                cbxLitros.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarid.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un ID de Orden");
                txtBuscarid.ResetText();
            }
            else
            {
                if (lista.Vacio())
                {
                    MessageBox.Show("No hay registro en el historial");
                    txtBuscarid.ResetText();
                }
                else
                {
                    int datobuscar = Convert.ToInt32(txtBuscarid.Text);
                    MessageBox.Show(lista.BuscarInfo(datobuscar));
                    txtBuscarid.ResetText();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lista.Vaciar();
            tablaatendidos.Rows.Clear();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}