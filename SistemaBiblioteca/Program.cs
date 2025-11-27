using SistemaBiblioteca.models; 

Biblioteca minhaBiblioteca = new Biblioteca("Biblioteca centro");

bool sistemaRodando = true ;

while (sistemaRodando)
{
Console.WriteLine("\n Menu");
Console.WriteLine("1- Cadastrar livro");
Console.WriteLine("2- Lisrar Livros");
Console.WriteLine("3- pesquisar por autor");
Console.WriteLine("0 - Sair");

string opcao = Console.ReadLine() ?? "";

switch (opcao)
    {
        case "1":
            Console.WriteLine("CADASTRAR LIVRO");
            Console.Write("Nome Do Livro: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("Preço Do Livro:");
            double preco = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Codigo De Barras (Numerico)");
            int codigo = int.Parse(Console.ReadLine() ?? "0");        

            Console.Write("Quantidade De livros :");
            int estoque = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Autor");
            string autor = Console.ReadLine() ?? "";

            Console.Write("Genero");
            string genero = Console.ReadLine() ?? "";
            
            Livro novoLivro = new Livro(nome, preco, codigo, estoque, autor, genero);
            
            minhaBiblioteca.AdicionarLivro(novoLivro);

            Console.WriteLine("Livro cadastrado com sucesso!");
            break;

        case "2":
            minhaBiblioteca.ListarLivros();
            
            Console.WriteLine("\nPressione ENTER para voltar ao menu");
            Console.ReadLine();
            break;

case "3":
            Console.WriteLine("Digite o nome do autor:");
            string nomeAutor = Console.ReadLine() ?? "";
            
            var resultado = minhaBiblioteca.BuscarPorAutor(nomeAutor);

            if (resultado.Count > 0)
            {
                Console.WriteLine($"\nLivros encontrados de {nomeAutor} ");

                foreach (var livro in resultado)
                {
                    livro.ExibirDetalhes();
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Nenhum livro encontrado para esse autor.");
            }
            
            Console.WriteLine("\n Pressione ENTER para continuar");
            Console.ReadLine();
            break;

        case "0":
            Console.WriteLine("Saindo");
            sistemaRodando = false; 
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;
    }

}