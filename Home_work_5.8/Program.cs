using System;

namespace Home_work_5._8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
            // Например, заданы 2 массива:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // 5 2 6 7
            // и
            // 1 5 8 5
            // 4 9 4 2
            // 7 2 2 6
            // 2 3 4 7

            // Их произведение будет равно следующему массиву:
            // 1 20 56 10
            // 20 81 8 6
            // 56 8 4 24
            // 10 6 24 49

            int m = 5, n = 4;
            int[,] firstArray = new int[m, n];
            int[,] secondArray = new int[m, n];

            FillArray(firstArray);
            FillArray(secondArray);
            Console.WriteLine("Исходный первый массив:");
            OutputArray(firstArray);
            Console.Write("\n");
            Console.WriteLine("Исходный второй массив:");
            OutputArray(secondArray);
            Console.Write("\n");
            Console.WriteLine("Массив с результатом умножения двух исходных массивов:");
            OutputArray(ArrayMultiplication(firstArray, secondArray));

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

            // Функция произведения элементов двух матриц
            int [,] ArrayMultiplication(int[,] firstArray, int[,] secondArray)
            {
                int lengthRow = firstArray.GetLength(0); int lengthColumn = firstArray.GetLength(1);
                int[,] resaultMultiplication = new int[lengthRow, lengthColumn];
                for (int i = 0; i < lengthRow; i++)
                    for (int j = 0; j < lengthColumn; j++)
                        resaultMultiplication[i, j] = firstArray[i,j] * secondArray[i,j];
                return (resaultMultiplication);
            }
        }
    }
}