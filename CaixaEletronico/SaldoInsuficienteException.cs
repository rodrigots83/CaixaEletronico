using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.CaixaEletronico
{
    class SaldoInsuficienteException : Exception
    {
        private string message;

        public new string Message{ get; protected set; }

        public SaldoInsuficienteException()
        {
            this.Message = "Saldo insuficiente";
        }
    }
}
