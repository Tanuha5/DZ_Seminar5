// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.21 7.68 22.11 2 78] -> 76

double[] GenerateArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        //array[i] = Math.Round(rand.NextDouble() * (maxValue - minValue) + minValue, 3);
        array[i] = Math.Round(rand.Next(minValue, maxValue) + rand.NextDouble(), 3);
    }
return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double MaxResult(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinResult(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] myArray = GenerateArray(10, 0, 10);
PrintArray(myArray);
Console.WriteLine($"Максимальное число: {MaxResult(myArray)}");
Console.WriteLine($"Минимальное число: {MinResult(myArray)}");
Console.WriteLine($"Разница между max и min равна: {MaxResult(myArray) - MinResult(myArray)}");

