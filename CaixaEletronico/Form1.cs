using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        Conta conta;

        public Form1()
        {
            InitializeComponent();

            conta = new Conta("Victor", 1, 250.0);
            this.textoTitular.Text = conta.Titular.Nome;
            this.textoNumero.Text = conta.Numero.ToString();
            this.textoSaldo.Text = conta.Saldo.ToString();

            //Conta[] contas = new Conta[5];
            //contas[0] = new Conta();
            //contas[0].Deposita(1);
            //contas[1] = new Conta();
            //contas[1].Deposita(30);
            //contas[2] = new Conta();
            //contas[2].Deposita(500);
            //contas[3] = new ContaPoupanca();
            //contas[3].Deposita(950);
            //contas[4] = new ContaPoupanca();
            //contas[4].Deposita(1);

            //foreach (Conta c in contas)
            //{
            //    MessageBox.Show(String.Format("O saldo da conta é: {0}", c.Saldo));            
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val1 = this.textoValor.Text;
            this.conta.Deposita(Convert.ToDouble(val1));
            AtualizaSaldo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string val1 = this.textoValor.Text;
            this.conta.Saca(Convert.ToDouble(val1));
            AtualizaSaldo();
        }

        private void AtualizaSaldo()
        {
            this.textoSaldo.Text = this.conta.Saldo.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();            
        }
    }
}
