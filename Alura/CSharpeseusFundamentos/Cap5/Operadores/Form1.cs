using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Operadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string divisivel = "";

            for (int i = 0; i <= 30; i++)
            {

                if (i % 3 == 0 || i % 4 == 0)
                    divisivel += i + " ";

            }

            MessageBox.Show(divisivel);
        }
    }
}
