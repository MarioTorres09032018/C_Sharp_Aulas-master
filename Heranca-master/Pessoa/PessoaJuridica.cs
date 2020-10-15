using System;
using System.Collections.Generic;
using System.Text;

namespace Aula
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, string sobrenome, string cnpj, DateTime dataNascimento, string cordosolhos)

                              : base(nome, sobrenome, dataNascimento, cordosolhos)
        {
            CNPJ = cnpj;
        }

        public string CNPJ { get; set; }

    }
}
