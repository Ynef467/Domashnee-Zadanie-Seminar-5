
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте размер массива: ");
int lenghtArrays = Convert.ToInt32(Console.ReadLine());


static int[] GetArray(int sizeArray)
{
    int[] array = new int[sizeArray];

    for (int i = 0; i < sizeArray; i++) array[i] = new Random().Next(-100, 100);

    Console.WriteLine($"Рандомный массив:\n{String.Join(", ", array)}");

    return array;
}


static double RaznicaMaxMin(int[] array)
{
    double minElement = array[0];
    double maxElement = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement) minElement = array[i];
        if (array[i] > maxElement) maxElement = array[i];
    }

    Console.WriteLine($"Минимальный элемент массива {minElement}\nМаксимальный элемент массива {maxElement}");

    return maxElement - minElement;
}

Console.WriteLine($"Разница между максимальным и минимальным элементов массива {(RaznicaMaxMin(GetArray(lenghtArrays)))}\n");