// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int size = InputInt("Введите размер матриц: ");
int[,] array = new int[size,size];
int[,] secondArray = new int[size,size];
int[,] resultArray = new int[size,size];
Console.WriteLine("Первая матрица");
FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Вторая матрица");
FillArray(secondArray);
PrintArray(secondArray);

Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine();
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] = (array[i, j] * secondArray[i, j]);
        }
    }
}

PrintArray(resultArray);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

