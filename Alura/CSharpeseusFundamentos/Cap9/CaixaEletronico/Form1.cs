using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // iniciliza a conta
            Conta c = new Conta();
            c.Deposita(100.0);

            // agora vamos testar o saque
            if (c.Saca(150.0))
            {
                MessageBox.Show("Saque realizado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Não foi possível realizar a operação de saque");
            }
        }
    }
}
