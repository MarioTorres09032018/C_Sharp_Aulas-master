using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;

namespace Aula
{
    public class Pessoa
    {
        const string PATHFILE = @"c:\CADASTRO\CadastroUsuario.txt";
        const string PASTA = @"c:\CADASTRO";

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

            string dadoscarregados = CarregarDadosArquivo();
            
            if (!Directory.Exists(PASTA))
            {
                Directory.CreateDirectory(PASTA);
            }

            Console.WriteLine(File.Exists(PATHFILE));
            File.WriteAllText(PATHFILE, "CadastroUsuario");
            Console.WriteLine(File.Exists(PATHFILE));
            Console.ReadKey(true);

            //salva em um arquivo de txt
            File.WriteAllText(PATHFILE, JsonConvert.SerializeObject(this) + "\n" +  dadoscarregados);
            
        }
        
        public static string CarregarDadosArquivo()
        
        {
            return File.ReadAllText(PATHFILE); //return dando problema. Não cria mais a pasta nem salva arquivo, só se criar manualmente.
        }
    }
}

