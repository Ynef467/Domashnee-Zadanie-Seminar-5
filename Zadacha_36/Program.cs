// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте размер массива: ");
int Arrayslenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

static int[] GetArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++) array[i] = new Random().Next(-100, 100);
    Console.WriteLine($"Your random array is:\n{String.Join(", ", array)}");
    return array;
}

static int SumNechetPosirion(int[] array)
{
    int sumOddPos = 0;

    for (int i = 1; i < array.Length; i += 2) sumOddPos += array[i];

    return sumOddPos;
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {SumNechetPosirion(GetArray(Arrayslenght))}\n");