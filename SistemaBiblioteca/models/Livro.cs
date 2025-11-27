namespace SistemaBiblioteca.models;

public class Livro : Produto
{
    public string Autor {get; set;}
    public string Genero {get; set;}
    
public Livro (string nome, double preco, int codigo, int estoque, string autor, string genero) 
        : base(nome, preco, codigo, estoque)
    {
        Autor = autor;
        Genero = genero;
    }

    public override void ExibirDetalhes()

    {
        base.ExibirDetalhes();
             Console.WriteLine($"Autor: {Autor} | Genero: {Genero}");
    }
}