using Aula;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    class CargoAssistenteADM:Pessoa
    {
        public CargoAssistenteADM(string nome, string sobrenome, string Cargo, DateTime dataNascimento, string cordosolhos)

                           : base(nome, sobrenome, dataNascimento, cordosolhos)

        {
            AssistenteADM = Cargo;
        }
        public string AssistenteADM { get; set; }
    }
}
