using Praticce_Serelizar_x_Deserealizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


//Console.WriteLine("Digite as informações abaixo!");

//Console.WriteLine("Digite o Nome: ");
//string nome = Console.ReadLine()!;

//Console.WriteLine($"Digite a idade: ");
//int idade = Convert.ToInt32(Console.ReadLine()!);

//Console.WriteLine("Digite o Email: ");
//string email = Console.ReadLine()!;

//Pessoa hiago = new Pessoa(nome, idade, email);

//Pessoas listaDePessoas = new Pessoas("Lista Pessoas");

//listaDePessoas.AdicionarNaListaDePessoas(hiago);
//listaDePessoas.ExibirLista();

////listaDePessoas.GerarArquivoJson();
//listaDePessoas.GerarArquivoTxt();



string fileName = "pessoas.json.json";
if (File.Exists(fileName))
{
    string jsonString = File.ReadAllText(fileName);
    Pessoas dados = JsonSerializer.Deserialize<Pessoas>(jsonString)!;

    Console.WriteLine($"nome da lista {dados.Nome}");

    foreach (var pessoa in dados.ListaDePessoas) 
    {
        Console.WriteLine($"- {pessoa.Nome} {pessoa.Idade} {pessoa.Email}");
    }
}
else 
{
    Console.WriteLine($"O arquivo {fileName} nao existe");
}


