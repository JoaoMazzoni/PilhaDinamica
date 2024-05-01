using PilhaDinamica;

internal class Program
{
    private static void Main(string[] args)
    {
        PilhaLivro minhaPilha = new PilhaLivro();
        int opc;

        do
        {
            Console.WriteLine("\n\n---- MENU ----\n");
            Console.WriteLine("|1| - Inserir Livro");
            Console.WriteLine("|2| - Remover Livro");
            Console.WriteLine("|3| - Imprimir Livro");
            Console.WriteLine("|4| - Sair");
            Console.Write("\nInforme a opção desejada: ");

            opc = int.Parse(Console.ReadLine());
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
//Livro livro1 = new Livro("Poeira em Alto Mar"); // 1 - CRIANDO LIVRO - livro1
//Livro livro2 = new Livro("A Volta Dos Que Não Foram");
//minhaPilha.push(livro1); // 2 - ENVIANDO O LIVRO1 PARA | 3 - FUNÇÃO "PUSH" (CLASSE PilhaLivro)
////minhaPilha.push(livro2);
//minhaPilha.print();
//minhaPilha.pop(); //REMOVE O TOPO DA PILHA, NÃO É POSSIVEL ESCOLHER.
//minhaPilha.print();