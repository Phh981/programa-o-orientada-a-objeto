using SistemaBanco.Core.Models;

Banco gh = new Banco("gh");

Cliente marcos = new Cliente("marcos", "111.222.333-44");
Cliente maria = new Cliente("maria", "999.888.777-66");

ContaCorrente c1 = new ContaCorrente(101, 1111, marcos);
ContaCorrente c2 = new ContaCorrente(101, 2222, maria);

c1.Depositar(100);
c2.Depositar(5000);
gh.AdicionarConta(c1);
gh.AdicionarConta(c2);
gh.ListarContas();