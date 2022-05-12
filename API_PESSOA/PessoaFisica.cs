using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_PESSOA
{
    class PessoaFisica : Pessoa
    {
        string CPF { get; set; }
        public PessoaFisica(long Codigo, string Nome, string CPF) : base(Codigo, Nome) {
            this.CPF = CPF;
        }

        public override string Imprimir()
        {
            string valor = String.Format("COD:{0}\tNome:{1}\tDOC:{2}", Codigo, Nome, CPF);
            return valor;
        }

        public override bool Validar()
        {
            return false;
        }
    }
}
