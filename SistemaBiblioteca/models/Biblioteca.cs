using System.Collections.Generic;
using System.Linq;

namespace SistemaBiblioteca.models;

public class Biblioteca
{
    public string Nome {get; set;}
    private List<Livro> Livros {get; set;}

    public Biblioteca (string nome)
    {
        Nome = nome;
        Livros = new List<Livro>();
    }
    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
    }
public void ListarLivros()
    {
        Console.WriteLine("\n CATÁLOGO COMPLETO");

        if (Livros.Count == 0)
        {
            Console.WriteLine("A biblioteca esta vazia no momento.");
            return; 
        }

        foreach (var livro in Livros)
        {
            livro.ExibirDetalhes(); 
        }
    }
    public List<Livro> BuscarPorAutor(string autorBusca)
    {
        return Livros.Where(livro => livro.Autor == autorBusca).ToList();
    }
}