namespace Desafio26
{
    internal class Aluguel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Aluguel(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}, Quarto: {Quarto}";
        }
    }
}
