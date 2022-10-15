// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] numbers = new int[4, 4];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
NumberMinSumElements(numbers);

void NumberMinSumElements(int[,] array)
{
    int minElements = 0;
    int minSum = 0;
    int sumElements = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        minElements += numbers[0, i];
    }
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++) sumElements += numbers[i, j];
        if (sumElements < minElements)
        {
            minElements = sumElements;
            minSum = i;
        }
        sumElements = 0;
    }
    Console.Write(($"Индекс строки с наименьшей суммой элементов: {minSum}"));
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
