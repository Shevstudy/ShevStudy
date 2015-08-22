using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaEletronico
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }

        public Cliente Titular { get; set; }

        public bool Saca(double valor)
        {
            if (valor <= Saldo)
            {
                if (Titular.EhMaiorDeIdade())
                {
                    this.Saldo -= valor + 0.1;
                    return true;
                }
                else if (valor <= 200)
                {
                    this.Saldo -= valor + 0.1;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }

}
