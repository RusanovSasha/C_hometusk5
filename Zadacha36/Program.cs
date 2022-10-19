// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] MakeArray(int len, int min, int max)
{
    int[] result = new int[len];
    Random rnd = new Random();

    // Проверяем, не попутал ли пользователь минимальное и максимальные значения разбоса для рандомайзера
    if (min > max)
    {
        int storage = min;
        max = min;
        min = storage;
    }
    for (int i = 0; i < len; i++)
    {
        result[i] = rnd.Next(min, max);
    }
    return result;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    Console.Write("[");
    for (int i = 0; i < len - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[len - 1]}]");
}

int СheckSummNotEven(int[] array)
{
    int len = array.Length;
    int result = 0;
    for (int i = 0; i < len; i++)
    {
        if (i % 2 != 0) result += array[i];
    }
    return result;
}


Console.Clear();
Console.Write("Введите количество элементов в массиве ");
int howMuch = int.Parse(Console.ReadLine());

Console.Write("Введите минимально возможное значение элемента массива ");
int minValue = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное возможное значение элемента массива ");
int maxValue = int.Parse(Console.ReadLine());

int[] generatedArray = MakeArray(howMuch, minValue, maxValue);

Console.WriteLine();
Console.WriteLine("Мы сгенерировали массив:");
PrintArray(generatedArray);
Console.WriteLine();

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {СheckSummNotEven(generatedArray)}");
Console.WriteLine();