using System;

namespace Home_work_5._8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // В итоге получается вот такой массив:
            // 1 2 4 7
            // 2 3 5 9
            // 2 4 4 8

            int m = 4, n = 4;
            int[,] array = new int[m, n];

            FillArray(array);
            Console.WriteLine("Исходный массив:");
            OutputArray(array);
            SortingRow(array);
            Console.Write("\n");
            Console.WriteLine("Отсортированный массив по строкам:");
            OutputArray(array);

            // Функция заполнения массива
            void FillArray(int[,] ArrayInFunction)
            {
                for (int i = 0; i < ArrayInFunction.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInFunction.GetLength(1); j++)
                    {
                        ArrayInFunction[i, j] = new Random().Next(11);
                    }
                }
            }

            // Функция сортировки по строкам
            void SortingRow(int[,] ArrayInFunction)
            {
                int temp = 0, getLengthColumn = array.GetLength(1);
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < getLengthColumn; j++)
                    {
                        for (int k = j + 1; k < getLengthColumn; k++)
                        {
                            if (ArrayInFunction[i, j] > ArrayInFunction[i, k])
                            {
                                temp = ArrayInFunction[i, j];
                                ArrayInFunction[i, j] = ArrayInFunction[i, k];
                                ArrayInFunction[i, k] = temp;
                            }
                        }
                    }
                }
            }

            // Функция вывода массива
            void OutputArray(int[,] ArrayInFunction)
            {
                for (int i = 0; i < ArrayInFunction.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInFunction.GetLength(1); j++)
                    {
                        Console.Write(ArrayInFunction[i, j] + "\t");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}