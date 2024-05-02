using PilhaDinamica;


internal class Program
{
    private static void Main(string[] args)
    {
        PilhaLivro minhaPilha = new PilhaLivro();
        int opc;

        static void BuscarLivro(PilhaLivro pilha) //Recebe um parâmetro do tipo pilha, ou seja, vai acessar uma pilha de alguma coisa para buscar (Pilha de Livro - minhaPilha)
        {
            Console.Write("\nInforme o título do livro que deseja buscar: "); //Pede para digitar o titulo do livro
            string tituloBusca = Console.ReadLine(); //A string local "tituloBusca" guarda o titulo digitado
            Livro livroEncontrado = pilha.ProcurarPorTitulo(tituloBusca); //A minhaPilha acessa a função levando o titulo digitado para  ela |FUNÇÃO CLASSE - PilhaLivro|
            //Variavel local do tipo Livro recebe o valor retornado pela função acessada (minhaPilha.ProcurarPorTitulo(titulo digitado)), que também é do tipo livro.

            if (livroEncontrado != null) //Se livroEncontrado receber um valor diferente de nulo
            {
                Console.WriteLine($"\nO livro '{tituloBusca}' foi encontrado na pilha.");
            }
            else //Se ele não receber nada/nulo
            {
                Console.WriteLine($"\nO livro '{tituloBusca}' não foi encontrado na pilha.");
            }
        }

        do
        {
            Console.Clear();
            Console.WriteLine("\n---- MENU ----\n");
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
