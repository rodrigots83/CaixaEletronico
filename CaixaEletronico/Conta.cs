using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.CaixaEletronico.Cliente;

namespace Caelum.CaixaEletronico.Contas
{
    class Conta
    {      
        public Titular Titular { get; set; }
        public double Saldo { get; protected set; }
        public int Numero { get; set; }

        public Conta() { }

        public Conta(string nome)
        {
            this.Titular = new Titular();
            this.Titular.Nome = nome;
        }

        public Conta(string nome, int numero, double saldo)
        {
            this.Titular = new Titular();
            this.Titular.Nome = nome;
            this.Numero = numero;
            this.Saldo = 0; 
            this.Deposita(saldo);
        }

        private bool saldoPositivo(double valor)
        {
            bool retorno = true;

            if (this.Saldo < valor)
                retorno = false;

            return retorno;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Saca(double valor)
        {
            if (this.saldoPositivo(valor))
                this.Saldo -= valor;
            else
                throw new SaldoInsuficienteException();
        }

        public void Transfere(double valor, Conta destino)
        {
            if (this.saldoPositivo(valor))
                destino.Deposita(valor);
        }
    }
}
