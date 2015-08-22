using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 4;
            int b = 5;
            int c = 6;

            double delta, a1, a2;

            delta = b * b - 4 * a * c;

            a1 = (-b + Math.Sqrt(1/delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(1/delta)) / (2 * a);

            MessageBox.Show("a1: " + a1 + "a2: " + a2);
        }
    }
}
