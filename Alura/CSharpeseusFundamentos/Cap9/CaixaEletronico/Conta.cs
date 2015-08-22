using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaEletronico
{
    class Conta
    {
        public int numero;
        public double saldo;

        public Cliente titular;

        public bool Saca(double valor)
        {
            if (valor <= saldo)
            {
                if (titular.EhMaiorDeIdade())
                {
                    this.saldo -= valor;
                    return true;
                }
                else if (valor <= 200)
                {
                    this.saldo -= valor;
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
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);            
        }
    }

}
