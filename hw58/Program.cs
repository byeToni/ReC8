// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;
Clear();
WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
int count = Get_int("Введите размерность массивов: ");


int[,] arr1= new int[count, count];
int[,] arr2= new int[count, count];
int[,] rezArr= new int[count, count];
FillArray(arr1, 0, 4);
FillArray(arr2, 0, 4);
FillArray(rezArr, 0, 4);
WriteLine("Рэндомныq массив 1: ");
PrintTwoDimensionArray(arr1);

WriteLine("Рэндомныq массив 2: ");
PrintTwoDimensionArray(arr2);

WriteLine("Массив произведений : ");
Multiplication();
PrintTwoDimensionArray(rezArr);

// Функция нахожддения произведения массивов
void Multiplication()
{

for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        rezArr[i, j] = 0;
        for (int k = 0; k < count; k++)
        {
            rezArr[i, j] += arr1[i, k] * arr2[k, j];
        }
    }
}
   
    return ;
}

void FillArray(int[,] coll, int count_str, int count_col)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(count_str, count_col + 1);
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

void PrintOneDimensionArray(int[] arr)
{

    for (int j = 0; j < arr.Length; j++)
    {
        Write($"{arr[j]} ");
    }
    WriteLine();
}
int Get_int(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}
