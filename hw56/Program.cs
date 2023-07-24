// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;
using static System.Console;
Clear();
WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
int count = Get_int("Введите размерность массива: ");


int[,] arr = new int[count, count];

FillArray(arr, 0, 15);
WriteLine("Рэндомный массив: ");
PrintTwoDimensionArray(arr);
int[] MinSumArr = new int[arr.GetLength(0)];
WriteLine("Массив сумм строк : ");
MinSummString(arr);
PrintOneDimensionArray(MinSumArr);
WriteLine($"Минимальная сумма строк: {GetMinimalElement(MinSumArr)}");
// Функция нахожддения наименьшей суммы строк массива
int[] MinSummString(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            MinSumArr[j] += array[j, i];
        }
    }
    return MinSumArr;
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

int GetMinimalElement(int[] array)
{
    int minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement) minElement = array[i];

    }
    return minElement;
}