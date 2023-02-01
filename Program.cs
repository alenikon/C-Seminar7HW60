﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int[,,] array3X = new int[3, 3, 3];
GetArray(array3X);
Console.Write($"Трёхмерная матрица:");
PrintArray(array3X);


void GetArray(int[,,] array)
{
    int index = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += index;
                index += 3;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array3X.GetLength(0); i++)
    {
        for (int j = 0; j < array3X.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3X.GetLength(2); k++)
            {
                Console.Write($"{array3X[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}