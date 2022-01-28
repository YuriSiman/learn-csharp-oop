namespace ClassesAtributosMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;
        }

        public override string ToString()
        {
            return $"\n\nNome do Produto: {Nome}\nPreço por Unidade: R$ {Preco:F2}\nQuantidade em Estoque: {Quantidade}\nValor Total em Estoque: R$ {ValorTotalEmEstoque():F2}";
        }
    }
}
