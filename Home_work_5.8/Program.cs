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
            int rangeMin = -99, rangeMax = 100, range = rangeMax - rangeMin;
            if(m*n*p > range)
            {
                Console.WriteLine("Неверно введенные начальные параметры! Несоотвествие параметров размерности матрицы и диапазона выборки уникальных значений. Программа завершает работу!");
                return;
            }
            int[] arraySorted = new int[range];
            int[,,] array = new int[m, n, p];

            Console.WriteLine("Исходный массив:");
            FillSortedArrayInRange(arraySorted, rangeMin, rangeMax, range);
            Console.WriteLine($"[{String.Join(";", arraySorted)}]");
            Console.WriteLine($"Длина массива: {arraySorted.Length}");
            FillArrayAndOutput(array);
            Console.WriteLine($"[{String.Join(";", arraySorted)}]");
            Console.WriteLine($"Длина массива: {arraySorted.Length}");

            void FillSortedArrayInRange(int[] ArrayInFunction, int min, int max, int range)
            {
                int count = 0;
                for (int i = min; i <= max; i++)
                {
                    if (count < range)
                    {
                        ArrayInFunction[count] = i;
                        count++;
                    }
                }
            }

            int RandomSample(int[] ArrayInFunction)
            {
                int sample = ArrayInFunction[new Random().Next(0, ArrayInFunction.Length)];
                //Console.WriteLine($"Выбрали случайный элемент: {sample} c индексом {Array.IndexOf(ArrayInFunction, sample)}");
                int indexSample = Array.IndexOf(ArrayInFunction, sample);
                Array.Clear(ArrayInFunction, indexSample, 1);
                for (int i = indexSample; i < ArrayInFunction.Length-1; i++)
                    ArrayInFunction[i] = ArrayInFunction[i + 1];
                Array.Resize(ref arraySorted, arraySorted.Length - 1);
                return (sample);
            }

            // Функция заполнения массива и его вывод
            void FillArrayAndOutput(int[,,] ArrayInFunction)
            {
                for (int i = 0; i < ArrayInFunction.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInFunction.GetLength(1); j++)
                    {
                        for (int k = 0; k < ArrayInFunction.GetLength(2); k++)
                        {
                            ArrayInFunction[i, j, k] = RandomSample(arraySorted);
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