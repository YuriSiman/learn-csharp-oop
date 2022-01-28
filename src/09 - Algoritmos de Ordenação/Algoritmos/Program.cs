using Algoritmos;

int[] array = new int[] { 2, 8, 4, 10, 1, 7, 3, 6, 5, 9 };

BubbleSort bubbleSort = new BubbleSort();

Console.WriteLine("======== Bubble Sort ========");

Console.Write("\nArray Original: ");
bubbleSort.ImprimirArray(array);

bubbleSort.OrdenarBubbleSort(ref array);

Console.Write("\nArray Ordenado: ");
bubbleSort.ImprimirArray(array);


