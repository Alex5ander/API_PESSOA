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
            char[] digitos = CPF.ToString().ToCharArray();
            int peso = 10;
            int soma = 0;
            int div1 = 0,
                div2 = 0,
                resto;
            for (int i = 0; i < 9; i++)
            {
                soma += peso * Convert.ToInt16(digitos[i].ToString());
                peso--;
            }
            resto = soma % 11;
            if (resto < 2) div1 = 0; else div1 = 11 - resto;
            if (div1 != Convert.ToInt16(digitos[9].ToString()))
                return false;
            peso = 11;
            resto = 0;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += peso * Convert.ToInt16(digitos[i].ToString());
                peso--;
            }
            resto = soma % 11;
            if (resto < 2) div2 = 0; else div2 = 11 - resto;
            if (div2 != Convert.ToInt16(digitos[10].ToString())) return false;
            return true;
        }
    }
}
