using System;
﻿using Aula;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Aula
{
    public class CargoVendedor : Pessoa
    {
        public string n { get; set; }
        public string sobrenome { get; set; }
        public string profissao { get; set; }
        public DateTime dtnascimento {get;set;}
        public string cordosolhos { get; set; }

        public CargoVendedor(string nome, string sobrenome, DateTime dataNascimento, string cordosolhos, string profissao, double QtdVendas, double SalMes,
         double comissao, double QtdDias)

                                 : base(nome, sobrenome, dataNascimento, cordosolhos)

        {
            Cargo = profissao;
            VendasMes = QtdVendas;
            Salariomes = SalMes;
            BonusMes= comissao;
            DiasTrabalhados = QtdDias;
        }

        public CargoVendedor(string n, string sobrenome, string profissao, DateTime dtnascimento, string cordosolhos)
        {
            this.n = n;
            this.sobrenome = sobrenome;
            this.profissao = profissao;
            this.dtnascimento = dtnascimento;
            this.cordosolhos = cordosolhos;
        }

        public string Cargo { get; set; }
        public double Salariomes { get; set; }
        public double BonusMes { get; set; }
        public double VendasMes { get; set; }
        public double DiasTrabalhados { get; set; }
    } 
   
}

namespace SalarioBase_Comissao  
{
    public class CargoVendedor:Pessoa
    {
        static void Main()
        {
            double QtdVendas = 0;
            double mes;
            double salario=1.200;
            double comissao = 0.1;
            
           mes= QtdVendas / salario * comissao;

            Console.WriteLine("Informe o numero de dias trabalhados");
            mes = int.Parse(Console.ReadLine());
        }
        
        public CargoVendedor(string nome, string sobrenome, string Cargo, DateTime dataNascimento, string cordosolhos)

                            : base(nome, sobrenome, dataNascimento, cordosolhos)

        {
            Vendedor = Cargo;
        }
        public string Vendedor { get; set; }
    }
}

