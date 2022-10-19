// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] MakeArray(int len)
{
    int[] result = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        result[i] = rnd.Next(100, 999);
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

int СheckEven(int[] array)
{
    int len = array.Length;
    int result = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}


Console.Clear();
Console.Write("Введите количество элементов в массиве ");
int howMuch = int.Parse(Console.ReadLine());

int[] generatedArray = MakeArray(howMuch);

PrintArray(generatedArray);

Console.WriteLine($"Количество четных чисел в массиве равно {СheckEven(generatedArray)}");