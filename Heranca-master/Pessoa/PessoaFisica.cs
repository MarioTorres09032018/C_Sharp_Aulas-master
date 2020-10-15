using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Aula
{
    public class PessoaFisica : Pessoa 
    {
        public PessoaFisica(string nome, string sobrenome, string cpf, string rg, DateTime dataNascimento, string cordosolhos)

                            : base(nome, sobrenome, dataNascimento,cordosolhos)
        {
            CPF = cpf;
            RG = rg;
        }
        public string CPF { get; set; }

        public string RG { get; set; }

    }
}
