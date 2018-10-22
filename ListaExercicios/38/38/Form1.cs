using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N, k = 0;
                double soma = 0;

                N = Convert.ToInt32(txtN.Text);

                for (k = 1; k <= N; k++)
                {
                    soma += k / (double) (k + 1);
                }

                MessageBox.Show("A soma da sequência é: " + soma.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Dados inserido inválido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
