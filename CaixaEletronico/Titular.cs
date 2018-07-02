using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Titular
    {
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public bool EEmancipado { get; set; }

        public Titular()
        {

        }

        public Titular(string nome)
        {
            this.Nome = nome;
        }

        public bool PodeAbrirConta()
        {
            var maiorDeIdade = (this.Idade >= 18);
            var emancipado = (this.EEmancipado);
            var temCpf = !string.IsNullOrEmpty(this.Cpf);

            return (maiorDeIdade || emancipado) && temCpf;
        }
    }
}
