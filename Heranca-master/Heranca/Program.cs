using System;
using System.Data.SqlTypes;
using System.Globalization;

namespace Aula
{
    class Program
    {
        static void Main()
        {
            //-----------------------------------------------------------------PESSOA------------------------------------------------------------------------------------------------//
            Escrever("\n*Bem vindo ao sistema de cadastro de PESSOAL");
            Escrever("");
            Escrever("1-Base de Pessoal");
            Escrever("2-Pessoa Juridica");
            Escrever("3-Pessoa Fisica");
            Escrever("");
            Escrever("Escolha uma opção:");

            string escolha;

            do
            {
                escolha = Console.ReadLine();
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE CADASTRO BASE DE PESSOAL");
            } while (escolha != "1");

            Console.Clear();

            if (escolha == "1")
            {
                Escrever("Digite seu nome.....:");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome.....:");
                string sobrenome = Console.ReadLine();

                Escrever("Digite sua Data Nascimento.....:");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite a cor dos seus olhos.....:");
                string olhos = Console.ReadLine();

                Pessoa pes = new Pessoa(n, sobrenome, dtnascimento, olhos);

                pes.Gravar();
            }
            else if (escolha == "2")
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE CADASTRO BASE DE PESSOAL");
            }
            else if (escolha == "3")
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE CADASTRO BASE DE PESSOAL");
            }
            Console.Clear();

            //-------------------------------------------------------------------PESSOA JURIDICA-------------------------------------------------------------------------------------//
            Escrever("\n*Bem vindo ao sistema de cadastro de PESSOA JURIDICA");
            Escrever("1-Base de Pessoal");
            Escrever("2-Pessoa Juridica");
            Escrever("3-Pessoa Fisica");
            Escrever("");
            Escrever("Escolha uma opção:");

            string escolha2;
            
            do
            {
                escolha2 = Console.ReadLine();
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA JURÍDICA");

            } while (escolha2 != "2");
            Console.Clear();

            if (escolha2 == "2")
            {
                Escrever("Digite seu nome.....:");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome.....:");
                string sobrenome = Console.ReadLine();
                Escrever("Digite seu CNPJ.....:");
                string cnpj = Console.ReadLine();
;
                Escrever("Digite sua Data Nascimento.....:");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite a cor dos seus olhos.....:");
                string olhos = Console.ReadLine();

                PessoaJuridica pj = new PessoaJuridica(n, sobrenome, cnpj, dtnascimento, olhos);

                pj.Gravar();
            }else if(escolha2=="1")
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA JURÍDICA");
            }
            else if (escolha2 == "3")
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA JURÍDICA");
            }
            Console.Clear();

            //---------------------------------------------------------------------PESSOA FISICA------------------------------------------------------------------------------------//
            Escrever("\n*Bem vindo ao sistema de cadastro de PESSOA FISICA");
            Escrever("1-Base de Pessoal");
            Escrever("2-Pessoa Juridica");
            Escrever("3-Pessoa Fisica");
            Escrever("");
            Escrever("Escolha uma opção:");

            string escolha3;

            do
            {
                escolha3 = Console.ReadLine();
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA FÍSICA");

            } while (escolha3 != "3");
            Console.Clear();

            if (escolha3 == "3")
            {
                Escrever("Digite seu nome.....:");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome.....:");
                string sobrenome = Console.ReadLine();

                Escrever("Digite seu CPF.....:");
                string cpf = Console.ReadLine();

                Escrever("Digite seu RG.....:");
                string rg = Console.ReadLine();

                Escrever("Digite sua Data Nascimento.....:");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite a cor dos seus olhos.....:");
                string olhos = Console.ReadLine();

                PessoaFisica pf = new PessoaFisica(n, sobrenome, cpf, rg, dtnascimento, olhos);

                pf.Gravar();
            }else if (escolha3 == "1")
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA FÍSICA");
            }
            else if (escolha3 == "2")
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA FÍSICA");
            }

            static void Escrever(string mensagemParaPrintarNaTela)
            {
                Console.WriteLine(mensagemParaPrintarNaTela);
            }
        }
    }
}


    

