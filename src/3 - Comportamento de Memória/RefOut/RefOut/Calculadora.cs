namespace RefOut
{
    internal class Calculadora
    {
        // Fazendo o parâmetro ser uma referência para a variável original
        public static void TriplicarRef(ref int x)
        {
            x = x * 3;
        }

        public static void TriplicarOut(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
