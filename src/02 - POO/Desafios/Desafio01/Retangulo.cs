namespace Desafio01
{
    internal class Retangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Base * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Base + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
        }
    }
}
