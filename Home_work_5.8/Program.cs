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

            Console.WriteLine("Исходный массив:");
            FillArrayAndOutput(array);
            CalculateSumRow(array, sumRow);
            Console.Write("\n");
            Console.WriteLine($"Суммы элементов по строкам: [{String.Join("; ", sumRow)}]");
            Console.WriteLine($"Строка с наименьшей суммой элементов: {FindSmallestSum(sumRow)}");

            // Функция заполнения массива и его вывод
            void FillArrayAndOutput(int[,] mainArray)
            {
                for (int i = 0; i < mainArray.GetLength(0); i++)
                {
                    for (int j = 0; j < mainArray.GetLength(1); j++)
                    {
                        mainArray[i, j] = new Random().Next(11);
                        Console.Write(mainArray[i, j] + "\t");
                    }
                    Console.Write("\n");
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

            // Функция поиска наименьшей суммы элементов по строкам
            int FindSmallestSum(int[] calculateSum)
            {
                int min = calculateSum[0], minPositionRow = 1;
                for (int i = 0; i < calculateSum.Length; i++)
                {
                    if (calculateSum[i] < min)
                    {
                        min = calculateSum[i];
                        minPositionRow = i + 1;
                    }   
                }
                return (minPositionRow);
            }
        }
    }
}