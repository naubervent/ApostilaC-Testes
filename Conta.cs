using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apostila01
{
    class Conta
    {
        private int numeroDaConta;
        private Cliente titular;
        private double saldo;
        private int idade;
        private bool menorDeIdade;

        public int NumeroDaConta { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }





        public bool Saca(double valor)
        {
            if(this.idade < 18 && valor > 200)
            {
                this.menorDeIdade = true;
            }
            else
            {
                if (this.saldo >= valor && this.saldo > 0.0)
                {
                    this.saldo -= valor;

                    return true;
                }
                this.menorDeIdade = false;
            }
            return false;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public bool Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
                return true;
            }
            return false;
        }

        
    }
}
