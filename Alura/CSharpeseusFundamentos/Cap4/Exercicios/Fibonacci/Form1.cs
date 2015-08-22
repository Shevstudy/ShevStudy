using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string fibonnaci = "0, 1";
            //int iniFibo = 0;
            //int f1 = 1;
            //int valFibo = 0;

            //while (valFibo < 100)
            //{

            //    valFibo = iniFibo + f1;
            //    iniFibo = f1;
            //    f1 = valFibo;
                
            //    fibonnaci += ", " + valFibo;             
            //}

            //MessageBox.Show(fibonnaci);

            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibonacci);
        }
    }
}
