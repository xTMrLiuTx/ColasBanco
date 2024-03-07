using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ColasBanco
{
    public partial class Form1 : Form
    {
        Queue<string> colaDepositos = new Queue<string>();
        Queue<string> colaRetiros = new Queue<string>();
        Queue<string> colaConsultas = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cliente = txtCliente.Text;

            if (cliente != "")
            {
                if (rbDeposito.Checked)
                {
                    colaDepositos.Enqueue(cliente);
                }
                else if (rbRetiro.Checked)
                {
                    colaRetiros.Enqueue(cliente);
                }
                else if (rbConsulta.Checked)
                {
                    colaConsultas.Enqueue(cliente);
                }

                ActualizarListBoxes();
                txtCliente.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
            }
        }







        private void rbConsulta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (colaDepositos.Count > 0)
            {
                MessageBox.Show($"Atendiendo depósito de: {colaDepositos.Dequeue()}");
            }
            else if (colaRetiros.Count > 0)
            {
                MessageBox.Show($"Atendiendo retiro de: {colaRetiros.Dequeue()}");
            }
            else if (colaConsultas.Count > 0)
            {
                MessageBox.Show($"Atendiendo consulta de: {colaConsultas.Dequeue()}");
            }
            else
            {
                MessageBox.Show("No hay clientes en espera.");
            }

            ActualizarListBoxes();
        }
        private void ActualizarListBoxes()
        {
            listBoxDepositos.Items.Clear();
            listBoxRetiros.Items.Clear();
            listBoxConsultas.Items.Clear();

            foreach (string cliente in colaDepositos)
            {
                listBoxDepositos.Items.Add(cliente);
            }

            foreach (string cliente in colaRetiros)
            {
                listBoxRetiros.Items.Add(cliente);
            }

            foreach (string cliente in colaConsultas)
            {
                listBoxConsultas.Items.Add(cliente);
            }

        }

        private void ActualizarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


