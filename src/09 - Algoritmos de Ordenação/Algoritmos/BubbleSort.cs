namespace Algoritmos
{
    internal class BubbleSort
    {
        public void OrdenarBubbleSort(ref int[] array)
        {
            int aux = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        aux = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = aux;
                    }
                }
            }
        }

        public void OrdenarArray(ref int[] array)
        {
            // Opção de ordenar um array utilizando a classe Array do C#
            Array.Sort(array);
        }

        public void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
