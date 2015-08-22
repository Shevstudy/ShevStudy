using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tabelaM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string table = "";

            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    table += x * i + " ";
                }

                table += "\n";
            }

            MessageBox.Show(table);
        }
    }
}
