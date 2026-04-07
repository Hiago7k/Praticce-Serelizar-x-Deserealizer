using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticce_Serelizar_x_Deserealizer;

internal class Pessoas
{
    public Pessoas(string? nome)
    {
        Nome = nome;
        ListaDePessoas = new List<Pessoa>();
    }

    public string? Nome { get; set; }
    public List<Pessoa> ListaDePessoas  { get;}


    public void AdicionarNaListaDePessoas(Pessoa pessoa) 
    {
        ListaDePessoas.Add(pessoa);
    }

    public void ExibirLista() 
    {
        Console.WriteLine("Exibindo pessoas da lista");
        foreach (var pessoa in ListaDePessoas) 
        {
            Console.WriteLine($"- {pessoa.Nome} | {pessoa.Idade} {pessoa.Email}");
        }

    }
}
