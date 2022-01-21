namespace RefOut
{
    internal class Calculadora
    {
        // Fazendo o parâmetro ser uma referência para a variável original, exigindo que a variável original seja iniciada
        public static void TriplicarRef(ref int x)
        {
            x = x * 3;
        }

        // Fazendo o parâmetro ser uma referência para a variável original, sem exigir que a variável original seja iniciada
        public static void TriplicarOut(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
