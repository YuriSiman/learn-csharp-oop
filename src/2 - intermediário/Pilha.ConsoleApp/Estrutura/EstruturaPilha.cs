using Pilha.ConsoleApp.Position;
using System;

namespace Pilha.ConsoleApp.Estrutura
{
    public class EstruturaPilha
    {
        public Posicao Primeiro { get; set; }

        public void Empilha(object item)
        {
            Primeiro = new Posicao(Primeiro, item);
        }

        public object Desempilha()
        {
            if (Primeiro == null)
            {
                throw new InvalidOperationException("A pilha está vazia!");
            }

            object resultado = Primeiro.Item;
            Primeiro = Primeiro.Proximo;
            return resultado;
        }
    }
}
