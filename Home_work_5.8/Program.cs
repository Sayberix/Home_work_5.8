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
            // Диапазоны среди положительных и отрицательных значений
            int rangeMaxNegative = -99, rangeMinNegative = -9, rangeMinPositive = 9, rangeMaxPositive = 99;
            // Расчет размерности отсортированного массива с учетом заданых диапазонов
            int range = rangeMaxPositive - rangeMinPositive + (-rangeMaxNegative) - (-rangeMinNegative);
            if (m*n*p > range)
            {
                Console.WriteLine("Неверно введенные начальные параметры! Несоответствие параметров размерности матрицы и диапазона выборки уникальных значений!");
                Console.WriteLine("Программа завершает работу!");
                return;
            }
            int[] arraySorted = new int[range];
            int[,,] array = new int[m, n, p];

            FillSortedArrayInRange(arraySorted, rangeMaxNegative, rangeMaxPositive, range);
            /* для наглядности - вывод отсортированного массива после его инициализации
            Console.WriteLine($"[{String.Join(";", arraySorted)}]");
            Console.WriteLine($"Длина массива: {arraySorted.Length}");*/
            Console.WriteLine("Результат:");
            FillArrayAndOutput(array);
            /* вывод отсортированого массива после произовльной выборки элементов из него
            Console.WriteLine($"[{String.Join(";", arraySorted)}]");
            Console.WriteLine($"Длина массива: {arraySorted.Length}");*/

            // заполнения отсоритрованного массива уникальными значениями из заданых диапазонов
            void FillSortedArrayInRange(int[] ArrayInFunction, int min, int max, int range)
            {
                int count = 0;
                for (int i = min; i <= max; i++)
                {
                    // Условие для диапазонов среди положительных и отрицательных двухзначных чисел 
                    if (count < range && i < -9 || i > 9 && i !=0)
                    {
                        ArrayInFunction[count] = i;
                        count++;
                    }
                }
            }

            // выборка произвольных значений из отсортированного массива с последующим удалением выбраного элемента в этом же массиве
            int RandomSample(int[] ArrayInFunction)
            {
                int sample = ArrayInFunction[new Random().Next(0, ArrayInFunction.Length)];
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