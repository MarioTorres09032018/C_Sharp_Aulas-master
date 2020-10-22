using System;
﻿using Aula;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Globalization;
using Cadastro;

namespace Aula
{
    public class CargoVendedor : Cargos
    {
        private string n;
        private double qtdDias;

        public CargoVendedor(string nome, string sobrenome, string profissao, DateTime dtnascimento, string cordosolhos,string vendedor, string assistenteADM, string analistaTI)
                               :base(nome,sobrenome,dtnascimento,cordosolhos,vendedor,assistenteADM,analistaTI)
        {
            
            this.vendedor = vendedor;
            
        }
        
        public string vendedor { get; set; }
        
    
    }
    }


