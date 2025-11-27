using System.Data.Common;

namespace SistemaBiblioteca.models;

public abstract class Produto {
    public string Nome {get; set;}
    public double Preco {get; set;}
    public int CodigoDeBarras {get; set;}
    public  int QuantidadeEmEstoque {get; set;}
public Produto(string nome, double preco, int codigoDeBarras, int quantidadeEmEstoque)
    {
        Nome = nome;
        Preco = preco;
        CodigoDeBarras = codigoDeBarras;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }
    public void AdicionarEstoque(int quantidade)
    {
        if(quantidade <= 0)
        {
            Console.WriteLine($"a quantidade {quantidade} nao e valida");
        }
        else
        {
            QuantidadeEmEstoque += quantidade; 
            Console.WriteLine($"{quantidade} itens adicionados");
        }
    }
    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome} | Preço: {Preco} | Estoque: {QuantidadeEmEstoque}");
    }

}