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
    public partial class Form2 : Form
    {
        Conta[] contas;
        Conta contaSelecionada;

        public Form2()
        {
            InitializeComponent();
            this.lblNumero.Text = "";
            this.lblSaldo.Text = "";
            this.lblTitular.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            contas = new Conta[2];

            contas[0] = new Conta("Victor", 1, 0);
            contas[1] = new Conta("Mário", 2, 0);

            foreach (Conta c in contas)
                this.comboDeContas.Items.Add(String.Format("{0} - {1}", c.Numero.ToString("00000"), c.Titular.Nome));

        }

        private void comboDeContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = this.comboDeContas.SelectedIndex;

            contaSelecionada = contas[indiceSelecionado];

            this.lblTitular.Text = contaSelecionada.Titular.Nome;
            this.lblNumero.Text = contaSelecionada.Numero.ToString();
            this.lblSaldo.Text = contaSelecionada.Saldo.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //depositar
            double valorDepositar;

            valorDepositar = Convert.ToDouble(this.txtValor.Text);

            if (this.contaSelecionada != null)
            {
                this.contaSelecionada.Deposita(valorDepositar);
            }

            MostraSaldo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sacar
            double valorSacar;

            valorSacar = Convert.ToDouble(this.txtValor.Text);

            if (this.contaSelecionada != null)
            {
                this.contaSelecionada.Saca(valorSacar);
            }

            MostraSaldo();
        }

        private void MostraSaldo()
        {
            MessageBox.Show(String.Format("O saldo da conta de '{0}', é de R$ {1:C}", this.contaSelecionada.Titular.Nome, this.contaSelecionada.Saldo));
        }
    }
}
