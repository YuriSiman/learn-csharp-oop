namespace Desafio04
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        public ContaBancaria(int numero, string titular, decimal deposito)
        {
            Numero = numero;
            Titular = titular;
            Deposito(deposito);
        }

        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }

        public void Saque(decimal valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return $"\n============ Dados da Conta ============\n\nConta {Numero}\nTitular: {Titular}\nSaldo: R$ {Saldo:F2}";
        }

    }
}
