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
            return $"{Nome}, R$ {Preco.ToString("F2")}, {Quantidade}, R$ {ValorTotalEmEstoque().ToString("F2")}";
        }
    }
}
