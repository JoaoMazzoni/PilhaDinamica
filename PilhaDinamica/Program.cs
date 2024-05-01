using PilhaDinamica;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        PilhaLivro minhaPilha = new PilhaLivro();
        int opc;

        static void BuscarLivro(PilhaLivro pilha)
        {
            Console.Write("\nInforme o título do livro que deseja buscar: ");
            string tituloBusca = Console.ReadLine();
            Livro livroEncontrado = pilha.ProcurarPorTitulo(tituloBusca);
            if (livroEncontrado != null)
            {
                Console.WriteLine($"\nO livro '{tituloBusca}' foi encontrado na pilha.");
            }
            else
            {
                Console.WriteLine($"\nO livro '{tituloBusca}' não foi encontrado na pilha.");
            }
        }

        do
        {
            Console.Clear();
            Console.WriteLine("\n\n---- MENU ----\n");
            Console.WriteLine("|1| - Inserir Livro");
            Console.WriteLine("|2| - Remover Livro");
            Console.WriteLine("|3| - Imprimir Livro");
            Console.WriteLine("|4| - Procurar Livro");
            Console.WriteLine("|5| - Quantidade de Livros");
            Console.WriteLine("|6| - Sair");
            Console.Write("\nInforme a opção desejada: ");
            
            opc = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opc)
            {
                case 1:
                    minhaPilha.push(cadastroLivro()); // 2 - ENVIANDO O LIVRO1 DO RETORNO DE cadastroLivro PARA | 3 - FUNÇÃO "PUSH" (CLASSE PilhaLivro)
                    break;

                case 2:
                    minhaPilha.pop();
                    break;

                case 3:
                    minhaPilha.print();
                    break;

                case 4:
                    BuscarLivro(minhaPilha);
                    Console.ReadLine();
                    break;

                case 5:


                    Console.WriteLine($"\nQuantidade de livros cadastrados: {minhaPilha.QuantidadeLivros()} livros");
                    Console.ReadLine(); 
                    break;


                case 6:
                    Console.WriteLine("\nFIM DO PROGRAMA");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;

            }

        } while (opc != 0);

    }

    static Livro cadastroLivro()
    {
        string titulo;
        Console.Write("\nInforme o título do novo livro: ");
        titulo = Console.ReadLine();
        return new Livro(titulo); // 1 - CRIANDO LIVRO - livro1
    }



}
