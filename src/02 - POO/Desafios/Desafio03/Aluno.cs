namespace Desafio03
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double Nota { get; set; }
        public bool Situacao { get; set; }

        public void NotaFinal(double nota)
        {
            Nota += nota;
        }

        public bool Status()
        {
            Situacao = Nota >= 60 ? true : false;
            return Situacao;
        }

        public double NotaRestante()
        {
            if (Situacao) return 0.0;

            return 60 - Nota;
        }

        public override string ToString()
        {
            return $"\nNota Final: {Nota:F2}"; 
        }
    }
}
