namespace Desafio01
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double valor)
        {
            Salario += (valor / 100) * Salario;
        }

        public override string ToString()
        {
            return $"\nID: {Id}\nFuncionário: {Nome}\nSalário: R$ {Salario:F2}\n";
        }
    }
}
