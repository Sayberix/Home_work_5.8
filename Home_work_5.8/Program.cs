using System;

namespace Home_work_5._8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // 5 2 6 7
            // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

            int m = 5, n = 4;
            int[,] array = new int[m, n];
            int[] sumRow = new int[m];

            FillArray(array);
            Console.WriteLine("Исходный массив:");
            OutputArray(array);
            CalculateSumRow(array, sumRow);
            Console.Write("\n");
            // Console.WriteLine("Отсортированный массив по строкам:");
            // OutputArray(array);

            // Функция заполнения массива
            void FillArray(int[,] mainArray)
            {
                for (int i = 0; i < mainArray.GetLength(0); i++)
                {
                    for (int j = 0; j < mainArray.GetLength(1); j++)
                    {
                        mainArray[i, j] = new Random().Next(11);
                    }
                }
            }

            // Функция суммирования элементов по строкам
            void CalculateSumRow(int[,] mainArray, int[] calculateSum)
            {
                for (int i = 0; i < mainArray.GetLength(0); i++)
                {
                    int sum = 0;
                    for (int j = 0; j < mainArray.GetLength(1); j++)
                    {
                        sum += mainArray[i, j];
                    }
                    calculateSum[i] = sum;
                }
            }

            // Функция вывода массива
            void OutputArray(int[,] mainArray)
            {
                for (int i = 0; i < mainArray.GetLength(0); i++)
                {
                    for (int j = 0; j < mainArray.GetLength(1); j++)
                    {
                        Console.Write(mainArray[i, j] + "\t");
                    }
                    Console.Write("\n");
                }
            }


        }
    }
}