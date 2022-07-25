using System;

namespace Home_work_5._8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Задача 62.Заполните спирально массив 4 на 4.
            // Например, на выходе получается вот такой массив:
            // 1  2  3  4
            // 12 13 14 5
            // 11 16 15 6
            // 10 9  8  7

            int m = 4, n = 4;
            int[,] array = new int[m, n];

            int countFill = 0;

            int countRow = m, countCol = n;
            countFill = FillTopRow(array, countFill, countRow, countCol);
            countFill = FillRightCol(array, countFill, countRow, countCol);
            countFill = FillRLowerRow(array, countFill, countRow, countCol);
            countFill = FillLeftCol(array, countFill, countRow, countCol);
            Console.WriteLine("Результат:");
            PrintArray(array);
            Console.WriteLine(countFill);
            // Функция заполнения массива

            int FillTopRow(int[,] ArrayInFunction, int countFill, int countRow, int countCol)
            {
                for (int i = 0; i < countRow; i++)
                {
                    for (int j = 0; j < countCol; j++)
                    {
                        if (ArrayInFunction[i, j] == 0 || j != 0)
                        {
                            ArrayInFunction[i, j] = countFill;
                            countFill++;
                        }
                    }
                    break;
                }
                return (countFill);
            }

            int FillRightCol(int[,] ArrayInFunction, int countFill, int countRow, int countCol)
            {
                for (int j = countCol - 1; j < countCol; j++)
                {
                    for (int i = 0; i < countRow; i++)
                    {
                        if (ArrayInFunction[i, j] == 0)
                        {
                            ArrayInFunction[i, j] = countFill;
                            countFill++;
                        }
                    }
                    break;
                }
                return (countFill);
            }

            int FillRLowerRow(int[,] ArrayInFunction, int countFill, int countRow, int countCol)
            {
                for (int i = countRow - 1; i >= 0; i--)
                {
                    for (int j = countCol - 1; j >= 0; j--)
                    {
                        if (ArrayInFunction[i, j] == 0)
                        {
                            ArrayInFunction[i, j] = countFill;
                            countFill++;
                        }
                    }
                    break;
                }
                return (countFill);
            }

            int FillLeftCol(int[,] ArrayInFunction, int countFill, int countRow, int countCol)
            {
                for (int j = 0; j < countCol; j++)
                {
                    for (int i = countRow - 1; i > 0; i--)
                    {
                        if (ArrayInFunction[i, j] == 0)
                        {
                            ArrayInFunction[i, j] = countFill;
                            countFill++;
                        }
                    }
                    break;
                }
                return (countFill);
            }

            void PrintArray(int[,] ArrayInFunction)
            {
                for (int i = 0; i < ArrayInFunction.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayInFunction.GetLength(1); j++)
                    {
                        Console.Write($"{ArrayInFunction[i, j]} \t");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}