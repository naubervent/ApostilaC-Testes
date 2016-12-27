using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apostila01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            Conta victor = new Conta();
            Conta guilherme = new Conta();

            Cliente cliente = new Cliente("Victor Hugo")
            {
                Cpf = "966 151 170 583",
                Rg = "1060953691",
                Endereco = "Rua Ricardo Schaurich 1252"
            };

            MessageBox.Show(cliente.Endereco);
            

            //Conta umaConta = new Conta();
            //umaConta.NumeroDaConta = 1;

            //MessageBox.Show("umaConta.NumeroDaConta: "+umaConta.NumeroDaConta);
            

            //c.NumeroDaConta = 1;
            //c.titular = "Nauber Ventura";
            //c.Saldo = 100.0;

            //victor.NumeroDaConta = 2;
            //victor.titular = "Victor Silva";
            //victor.Saldo = 1000.0;
            //victor.Idade = 18;
            
            //guilherme.Saldo = 750.0;

            

            /*bool deuCerto = victor.Transfere(100.0, guilherme);//c.Saca(100.0);
            if (deuCerto == true)
            {
                MessageBox.Show("Saque realizado com sucesso. Saldo de Guilerme é: " + guilherme.Saldo);

            }
            else
            {
                if (victor.MenorDeIdade == true)
                {
                    MessageBox.Show("Operação negada. Você é menor de idade.");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente.");
                }
            }*/
        }
    }
}
