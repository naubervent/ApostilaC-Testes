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
            //Conta victor = new Conta();
            Conta guilherme = new Conta();

            Cliente cliente = new Cliente();
            cliente.nome = "Victor";

            Conta umaConta = new Conta();
            umaConta.NumeroDaConta = 1;

            MessageBox.Show("umaConta.NumeroDaConta: "+umaConta.NumeroDaConta);
            

            /*c.numeroDaConta = 1;
            //c.titular = "Nauber Ventura";
            c.saldo = 100.0;

            victor.numeroDaConta = 2;
            //victor.titular = "Victor Silva";
            victor.saldo = 0.0;
            victor.idade = 18;
            */
            //guilherme.saldo = 750.0;

            //victor.Transfere(100.0, guilherme);

            /*bool deuCerto = victor.Saca(201.0);//c.Saca(100.0);
            if (deuCerto == true)
            {
                MessageBox.Show("Saque realizado com sucesso. Saldo é: " + victor.saldo);

            }
            else
            {
                if (victor.menorDeIdade == true)
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
