using Newtonsoft.Json;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace Aula
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome, DateTime dataNascimento, string cordosolhos)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            CorDosOlhos = cordosolhos;
        }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string CorDosOlhos { get; private set; }
        public int Idade
        {
            get
            {
                return DateTime.Now.Year - DataNascimento.Year;
            }

        }
        public void Gravar()
        {
            //Verifica se o diretório existe
            {
                string pasta = @"c:\CADASTRO";

                if (Directory.Exists(pasta))
                {
                    Console.WriteLine("**Um Diretório de Cadastro de Usuários foi criado em C: CADASTRO. Aperte ENTER para continuar**");
                }
                else 
                {
                    Console.WriteLine("**O Diretório Não Existe. Para cria-lo agora aperte ENTER**");
                }
            }
            //Cria um Novo Diretório
            string diretorio = @"c:\CADASTRO";
            Directory.CreateDirectory(diretorio);

            //salva em um arquivo de txt
            File.WriteAllText(@"c:\CADASTRO\CadastroUsuario.txt", JsonConvert.SerializeObject(this));
            Console.ReadKey(true);
        }
    }
}

 