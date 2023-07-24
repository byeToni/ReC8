// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;
using static System.Console;
Clear();
WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
int count = Get_int("Введите размерность массива: ");

while (count <=2&&count>4)
{
    WriteLine("Услови введенный параметр не соответсвует условиям задачи повторите ввод: ");
    count = Get_int("Введите размерность массива: ");
}

int[,,] arr1= new int[count, count,count];

FillArray3D(arr1);

WriteLine("Рэндомныq 3d массив : ");
Print3d(arr1);



void FillArray3D(int[,,] coll)
{
    int numbers=10;
    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < count; j++)
        {
            for (int l = 0; l < count; l++)
            {
                coll[i, j,l] = numbers++;
            }
            
        }
    }
}

void Print3d(int[,,] arr)
{
    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < count; j++)
        {
            for (int l = 0; l < count; l++)
            {
                Write($"{arr[i, j,l]} ({i},{j},{l})");
            }
        }
        WriteLine();
    }
}


int Get_int(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}
