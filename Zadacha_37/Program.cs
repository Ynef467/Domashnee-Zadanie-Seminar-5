// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Задайте размер массива: ");
int lenghtArrays = Convert.ToInt32(Console.ReadLine());

static int[] GetArray(int sizeArray)
{
    int[] array = new int[sizeArray];

    for (int i = 0; i < sizeArray; i++) array[i] = new Random().Next(-100, 100);

    Console.WriteLine($"Рандомный массив:\n{String.Join(", ", array)}");

    return array;
}

static string MultOfPairs(int[] array)
{


    int[] arrayMult = new int[(array.Length + 1) / 2];

    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            arrayMult[i] = array[i] * array[array.Length - 1 - i];
        }
    }

    else
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            arrayMult[i] = array[i] * array[array.Length - 1 - i];
        }

        arrayMult[array.Length / 2] = array[array.Length / 2];
    }

    string multArray = String.Join(", ", arrayMult);

    return multArray;
}

Console.WriteLine($"Произведение пар чисел в одномерном массиве:\n{(MultOfPairs(GetArray(lenghtArrays)))}\n");