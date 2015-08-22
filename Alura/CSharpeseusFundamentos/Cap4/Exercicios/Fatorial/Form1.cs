using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int fatorial;         

            //for (int i = 1; i <= 10; i++)
            //{
            //    fatorial = i;

            //    for (int n = i; n > 1; n--)
            //    {

            //        fatorial *= n - 1;

            //    }

            //    MessageBox.Show("Fatorial de " + i + "e: " + fatorial);
            //}

            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;
                MessageBox.Show("fat(" + n + ") = " + fatorial);
            }
        }
    }
}
