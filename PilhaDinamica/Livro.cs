
namespace PilhaDinamica
{
    internal class Livro
    {
        string titulo;
        Livro anterior;

        public Livro(string titulo)
        {
            this.titulo = titulo;
            anterior = null;
        }

        public override string? ToString()
        {
            return "\n\nTítulo do Livro: " + titulo;
        }

        public void setAnterior(Livro livro) // 5- livro = topoLivro (O livro do topo)
        {
            anterior = livro; // 6 - O "anterior" pega o livro que estava no topo | 7 - Volta para a função "PUSH" -  Classe PilhaLivro
        }
        
        public Livro getAnterior() 
        { 
            return anterior;
        }
    
    }


}
