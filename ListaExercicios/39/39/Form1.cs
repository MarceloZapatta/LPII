using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] matrizA = new int[10];
            int[] matrizB = new int[10];

            Random rb = new Random();
            for(int i = 0; i < 10; i++)
            {
                matrizA[i] = rb.Next(0, 10);
                if (i % 2 == 0)
                {
                    matrizB[i] = matrizA[i] * 5;
                } else
                {
                    matrizB[i] = matrizA[i] + 5;
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("Matriz A: \n");
            foreach (var item in matrizA)
            {
                sb.Append(item.ToString() + " | ");
            }
            sb.Append("\nMatriz B: \n");
            foreach (var item in matrizB)
            {
                sb.Append(item.ToString() + " | ");
            }

            MessageBox.Show("Valores das matrizes: \n" + sb.ToString());

            // Fecha o form atual
            Close();
        }
    }
}
