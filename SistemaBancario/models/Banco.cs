namespace SistemaBanco.Core.Models;

public class Banco
{
    public string Nome {get; set;}

    public List <Conta> Contas {get; private set;}

    public Banco(string nome)
    {
        Nome = nome;
        Contas = new List<Conta>();
    }

    public void AdicionarConta (Conta conta)
    {
        Contas.Add(conta);
        Console.WriteLine($"conta {conta.Numero} adicionada ao banco {Nome}");
    }
    public void ListarContas()
    {
        Console.WriteLine($"relatorio do banco {Nome.ToUpper()}");

        foreach (var conta in Contas)
        {
        Console.WriteLine($"Conta: {conta.Numero} | Titular: {conta.Titular.Nome} | Saldo: R$ {conta.Saldo}");

        }
    }
}

