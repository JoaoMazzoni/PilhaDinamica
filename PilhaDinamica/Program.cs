using PilhaDinamica;

internal class Program
{
    private static void Main(string[] args)
    {
        PilhaLivro minhaPilha = new PilhaLivro();
        Livro livro1 = new Livro("Poeira em Alto Mar"); // 1 - CRIANDO LIVRO - livro1
        Livro livro2 = new Livro("A Volta Dos Que Não Foram");
        minhaPilha.push(livro1); // 2 - ENVIANDO O LIVRO1 PARA | 3 - FUNÇÃO "PUSH" (CLASSE PilhaLivro)
        //minhaPilha.push(livro2);
        minhaPilha.print();
        minhaPilha.pop(); //REMOVE O TOPO DA PILHA, NÃO É POSSIVEL ESCOLHER.
        minhaPilha.print();

    }
}