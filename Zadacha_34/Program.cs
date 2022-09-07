
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте размер массива");
int Arrayslenght = Convert.ToInt32(Console.ReadLine());

static int CountChetnihElements(int[] array)
{
    int countNumEven = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) countNumEven++;
    }

    return countNumEven;
}


static int[] GetThreeDigitArray(int sizeArray)
{
    int[] array = new int[sizeArray];

    for (int i = 0; i < sizeArray; i++) array[i] = new Random().Next(100, 1000);

    Console.WriteLine($"Рандомный массив:\n{String.Join(", ", array)}");

    return array;
}


Console.WriteLine($"количество чётных чисел в массиве: {CountChetnihElements(GetThreeDigitArray(Arrayslenght))}\n");