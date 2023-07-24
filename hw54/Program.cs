// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// 
using System;
using static System.Console;
Clear();
WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
int count_str = Get_int("Введите количество строк в массиве: ");
int count_col = Get_int("Введите количество столбцов в массиве: ");
int[,] arr = new int[count_str, count_col];
FillArray(arr, 0, 15);
WriteLine("Рэндомный массив: ");
PrintArray(arr);
SortToLower(arr);
WriteLine("Отсортированный массив: ");
PrintArray(arr);
// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
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

void PrintArray(int[,] arr)
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
