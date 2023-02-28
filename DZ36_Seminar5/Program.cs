// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int GetResult(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if ((i % 2) != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] myArray = GenerateArray(11, 1, 8);
PrintArray(myArray);
Console.WriteLine(GetResult(myArray));




