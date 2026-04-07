using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Channels;
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
    [JsonPropertyName("pessoa")]
    public List<Pessoa> ListaDePessoas  { get; set; }


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


    public void GerarArquivoJson() 
    {
        string json = $"gerando-arquivo{Nome}.json";

        var arquivo = JsonSerializer.Serialize(new
        {
            nome = Nome,
            pessoa = ListaDePessoas
        });

        Console.WriteLine($"Arquivo Json criado com sucesso em {Path.GetFullPath(json)}");
        File.WriteAllText(json, arquivo);
    }


    public void GerarArquivoTxt() 
    {
        string nome = $"arquivotxt-gerado{Nome}.txt";

        using (StreamWriter arquivo = new StreamWriter(nome))
        {
            arquivo.WriteLine($"Arquivo texte {nome}");
            foreach (var pessoa in ListaDePessoas) 
            {
                arquivo.WriteLine($"- {pessoa.Nome} {pessoa.Idade} {pessoa.Email}");
            }
        }
        Console.WriteLine("Txt gerado com sucesso");
    }
}
