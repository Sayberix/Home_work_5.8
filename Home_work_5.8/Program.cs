using System;

namespace Home_work_5._8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
            // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
            // массив размером 2 x 2 x 2
            // 12(0, 0, 0) 22(0, 0, 1)
            // 45(1, 0, 0) 53(1, 0, 1)

            int m = 2, n = 2, p = 2;
            int[,,] array = new int[m, n, p];

            Console.WriteLine("Исходный массив:");
            FillArrayAndOutput(array);
            
            // Функция заполнения массива и его вывод
            void FillArrayAndOutput(int[,,] ArrayInFunction)
            {
                for (int i = 0; i < ArrayInFunction.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInFunction.GetLength(1); j++)
                    {
                        for (int k = 0; k < ArrayInFunction.GetLength(2); k++)
                        {
                            ArrayInFunction[i, j, k] = new Random().Next(11);
                            Console.Write($"{ArrayInFunction[i, j, k]} ({i},{j},{k})" + "\t");
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }

        }
    }
}