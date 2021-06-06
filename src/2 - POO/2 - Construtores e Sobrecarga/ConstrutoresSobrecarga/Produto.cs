namespace ConstrutoresSobrecarga
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {}

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int qtd) : this(nome, preco)
        {
            Quantidade = qtd;
        }

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
