namespace Pilha.ConsoleApp.Position
{
    public class Posicao
    {
        public Posicao Proximo { get; set; }
        public object Item { get; set; }

        public Posicao(Posicao proximo, object item)
        {
            Proximo = proximo;
            Item = item;
        }
    }
}
