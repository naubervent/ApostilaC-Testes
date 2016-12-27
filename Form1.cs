using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.c = new Conta();
            //ContaPoupanca cPoupanca = new ContaPoupanca();

            
            /*Cliente cliente = new Cliente("Nauber");
            c.Titular = cliente;
            c.Valor = cliente;
            txtTitular.Text = cPoupanca.Titular.Nome;
            txtNumero.Text = Convert.ToString(cPoupanca.Numero);
            txtSaldo.Text = Convert.ToString(cPoupanca.Saldo);*/

            
            Conta c = new Conta();
            c.Numero = 1;
            Cliente cliente = new Cliente("Victor");
            c.Titular = cliente;
            c.Valor = cliente;
            txtTitular.Text = c.Titular.Nome;
            txtNumero.Text = Convert.ToString(c.Numero);
            txtSaldo.Text = Convert.ToString(c.Saldo);              
                      

        }

        private void BotaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c.Deposita(valorOperacao);
            txtSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado); 
            this.c.Saca(valorOperacao);
            txtSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso");
        }
    }
}
