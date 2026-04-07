using Praticce_Serelizar_x_Deserealizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.WriteLine("Digite as informações abaixo!");

Console.WriteLine("Digite o Nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Digite a idade: ");
int idade = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Digite o Email: ");
string email = Console.ReadLine()!;

Pessoa hiago = new Pessoa(nome, idade, email);

Pessoas listaDePessoas = new Pessoas("Lista Pessoas");

listaDePessoas.AdicionarNaListaDePessoas(hiago);
listaDePessoas.ExibirLista();

listaDePessoas.GerarArquivoJson();