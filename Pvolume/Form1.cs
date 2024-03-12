using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            double TesteRaio;
            if (!double.TryParse(txtRaio.Text, out TesteRaio))
            {
                MessageBox.Show("Raio Invalido");
            }
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            double TesteAltura;
            if (!double.TryParse(txtAltura.Text, out TesteAltura))
            {
                MessageBox.Show("Altura Invalida");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double TesteRaio, TesteAltura;
            if ((!double.TryParse(txtRaio.Text, out TesteRaio)) || (!double.TryParse(txtAltura.Text, out TesteAltura)))
            {
                MessageBox.Show("Valores Invalidos");
                txtRaio.Focus();
            }
            else
            {
                double volume;
                volume = Math.PI * Math.Pow(TesteRaio, 2) * TesteAltura;
                txtVolume.Text = volume.ToString("N2");
            }
        }
    }
}
