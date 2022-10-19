//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double[] MakeArrayDouble(int len)
{
    double[] result = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        result[i] = rnd.NextDouble() * Math.Pow(10, rnd.Next(1, 4));
        result[i] = Math.Round(result[i], 2);
    }
    return result;
}

void PrintArray(double[] array)
{
    int len = array.Length;
    Console.Write("[");
    for (int i = 0; i < len - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine($"{array[len - 1]}]");
}

double FindMin(double[] array)
{
    int len = array.Length;
    double result = array[0];
    for (int i = 1; i < len; i++)
    {
        if (array[i] < result) result = array[i];
    }
    return result;
}

double FindMax(double[] array)
{
    int len = array.Length;
    double result = array[0];
    for (int i = 1; i < len; i++)
    {
        if (array[i] > result) result = array[i];
    }
    return result;
}

Console.Clear();
Console.Write("Введите количество элементов в массиве ");
int howMuch = int.Parse(Console.ReadLine());

double[] generatedArray = MakeArrayDouble(howMuch);

Console.WriteLine();
Console.WriteLine("Мы сгенерировали массив вещественных чисел:");
PrintArray(generatedArray);
Console.WriteLine();

double minVal = FindMin(generatedArray);

double maxVal = FindMax(generatedArray);

Console.WriteLine($"Минимальный элемент массива равен {minVal}, максимальный элемент равен {maxVal}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами равна {Math.Round((maxVal - minVal), 2)}");