﻿using System;
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
    }
}
