
namespace PilhaDinamica
{
    internal class PilhaLivro
    {
        Livro topoLivro;

        public PilhaLivro()
        {
            topoLivro = null;
            Console.WriteLine("Pilha criada com sucesso!");
        }

        public void push(Livro auxLivro) //3 - auxLivro = livro1
        {
            if (vazia() == true)
            {
                topoLivro = auxLivro;
            }
            else
            {
                auxLivro.setAnterior(topoLivro); // 4 - livro1.setAnterior(topoLivro) topoLivro é o livro que está no Topo da Fila | 5- ENVIA topoLivro NA FUNÇÃO "setAnterior" - CLASSE Livro
                topoLivro = auxLivro; // 7 - "topoLivro" agora recebe o novo livro que estava aguardando no "auxiliarLivro" - (livro1)
            }                        // Agora, o livro que está no topo da pilha é o (livro1), que foi adicionado.
        }

        bool vazia()
        {
            if (topoLivro == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void print()
        {
            Livro auxLivro = topoLivro; 
            if (vazia()) 
            {
                Console.WriteLine("Pilha Vazia!");
                Console.Write("Pressione qualquer tecla para continuar:");
                Console.ReadKey();
            }

            else
            {
                do
                {
                    Console.WriteLine(auxLivro.ToString());
                    auxLivro = auxLivro.getAnterior();
                }while(auxLivro != null);
                Console.WriteLine("FIM DA IMPRESSÃO");
                Console.Write("Pressione qualquer tecla para continuar: ");
                Console.ReadKey();
            }

        }
    

    
        public void pop()
        {
            if (vazia())
            {
                Console.WriteLine("Pilha Vazia! Impossível Remover.");
                Console.Write("Pressione qualquer tecla para continuar:");
                Console.ReadKey();
            }
            else
            {
                topoLivro = topoLivro.getAnterior();
            }

        }
    
    }



}
