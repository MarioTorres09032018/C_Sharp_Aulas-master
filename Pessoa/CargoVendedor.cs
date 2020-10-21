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
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.profissao = profissao;
            this.dtnascimento = dtnascimento;
            this.cordosolhos = cordosolhos;
            this.vendedor = vendedor;
            
        }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string profissao { get; set; }
        public DateTime dtnascimento { get; set; }
        public string cordosolhos { get; set; }
        public string vendedor { get; set; }
        
        static void Main()    //tentativa de cálculo
        {
            double QtdVendas = 0;    
            double mes;
            double salario = 1.200;    //salário Base
            double comissao = 0.01;   //Comissão de 10%

            mes = QtdVendas / salario * comissao;

            Console.WriteLine("Informe o numero de dias trabalhados");
            mes = int.Parse(Console.ReadLine());
        }
    }
    }


