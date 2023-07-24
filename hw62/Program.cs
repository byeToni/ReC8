// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

using System;
using static System.Console;
Clear();
WriteLine("адача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
int count = Get_int("Введите размерность массивов: ");

int numbers = 1;
int[,] arr1 = new int[count, count];
FillArraSpiraly(0, 0);

WriteLine("Заполненный массив : ");
PrintTwoDimensionArray(arr1);

void FillArraSpiraly(int i, int j)
{
    if (arr1[i, j] == 0)
    {
        arr1[i, j] = numbers;

        WriteLine($"i {i}, j {j}, numbers {numbers}, arr {arr1[i, j]} ");
        numbers++;
        if (numbers < count*count)
        {
        if (j + 1 < count) FillArraSpiraly(i, j + 1);
        if (i + 1 < count) FillArraSpiraly(i + 1, j);
        if (j > 0) FillArraSpiraly(i, j - 1);
        FillArraSpiraly(i - 1, j);
        PrintTwoDimensionArray(arr1);
        WriteLine();
        }
    }
    
}

void PrintTwoDimensionArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }
}

int Get_int(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}