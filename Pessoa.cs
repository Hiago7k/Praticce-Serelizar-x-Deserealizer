using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticce_Serelizar_x_Deserealizer;

internal class Pessoa
{
    public Pessoa(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}
