using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FimDoMundo
{
    public partial class Form1 : Form
    {
        double SalarioEntrada, Filhos, fodaseINSS,CudoIRPF;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsNumber(e.KeyChar) ||
                Char.IsPunctuation(e.KeyChar))
                {
                    MessageBox.Show("caracter inválido"); SendKeys.Send("{BACKSPACE}");
                }
            }
        }

        private void lblDescIRPF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NÂO CLICA AQUI!");
        }

        private void txtbNome_Validating(object sender, CancelEventArgs e)
        {
        }

        private void mskbxSalBruto_Validating(object sender, CancelEventArgs e)
        {
           
            if (!double.TryParse(mskbxSalBruto.Text,out SalarioEntrada))
            {
                MessageBox.Show("Faz isso comigo não vhei");
                e.Cancel=true;
            }

        }

        private void btnQualquercoisa_Click(object sender, EventArgs e)
        {
            if (SalarioEntrada < 800.48)
                fodaseINSS = (SalarioEntrada * 0.0765);
            else if (SalarioEntrada < 1050.01)
                fodaseINSS = (SalarioEntrada * 0.0865);
            else if (SalarioEntrada < 1400.78)
                fodaseINSS = (SalarioEntrada * 0.09);
            else if (SalarioEntrada < 2801.56)
                fodaseINSS = (SalarioEntrada * 0.11);
            else fodaseINSS = 308.17;
            if (SalarioEntrada < 1257.13)
                CudoIRPF=0;
            else if ()
        }
    }
}
