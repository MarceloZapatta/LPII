using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double[,] matriz = new double[7,5];
            double[] totalPorDia = new double[7];
            double totalGeral = 0;

            Random rd = new Random();

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rd.Next(0, 100);
                }
            }

            for (int i = 0; i < 7; i++)
			{
                totalPorDia[i] = 0;
                for (int j = 0; j < 5; j++)
			    {
                    totalPorDia[i] += matriz[i,j];
                }
			}

            for (int i = 0; i < 7; i++)
            {
                totalGeral += totalPorDia[i];
            }

            for (int i = 0; i < 7; i++)
            {
                lbxLista.Items.Add("Dia " + (i + 1).ToString() + ": " + totalPorDia[i].ToString());
            }

            lbxLista.Items.Add("Total geral: " + totalGeral.ToString());
        }
    }
}
