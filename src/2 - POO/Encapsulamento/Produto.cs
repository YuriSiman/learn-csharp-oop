namespace Encapsulamento
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int qtd)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = qtd;
        }

        public string Nome
        {
            get { return _nome; }
            set 
            { 
                if(!string.IsNullOrEmpty(value))
                    _nome = value; 
            }
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
            return $"{_nome}, R$ {Preco.ToString("F2")}, {Quantidade}, R$ {ValorTotalEmEstoque().ToString("F2")}";
        }
    }
}
