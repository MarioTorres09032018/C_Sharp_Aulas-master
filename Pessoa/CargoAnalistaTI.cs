using Aula;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    class CargoAnalistaTI:Pessoa
    {
        public CargoAnalistaTI(string nome, string sobrenome, string Cargo, DateTime dataNascimento, string cordosolhos)

                          : base(nome, sobrenome, dataNascimento, cordosolhos)

        {
            AnalistaTI = Cargo;
        }
        public string AnalistaTI { get; set; }
    }
}
