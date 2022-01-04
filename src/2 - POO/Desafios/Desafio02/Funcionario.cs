namespace Desafio02
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem/100); 
        }

        public override string ToString()
        {
           return $"\nNome: {Nome}\nSalário Líquido: R$ {SalarioLiquido():F2}";
        }
    }
}
