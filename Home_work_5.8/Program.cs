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

            // Параметры ввода размеров двухмерной матрицы
            int m = 4, n = 4;

            int[,] array = new int[m, n];
            int countRow = m, countCol = n, currentPosition, countFill = 0;

            // Проверка начальных условий
            if (m >= 3 && n >= 3)
            {
                // Выбираем самую большую сторону матрицы
                if (countRow >= countCol)
                    currentPosition = countRow;
                else
                    currentPosition = countCol;

                // Цикл спирального заполнения матрицы
                for (int i = 0; i < Math.Ceiling((decimal)currentPosition / 2); i++)
                {
                    countFill = FillTopRow(array, countFill, countRow, countCol, i);
                    countFill = FillRightCol(array, countFill, countRow, countCol, i);
                    countFill = FillLowerRow(array, countFill, countRow, countCol, i);
                    countFill = FillLeftCol(array, countFill, countRow, countCol, i);
                }
            }
            else
            {
                Console.WriteLine("Размер заданного двухмерного массива должен быть не менее 3х3! Программа прекращает работу!");
                return;
            }

            Console.WriteLine("Результат:");
            PrintArray(array);
            Console.WriteLine("Всего заполненных элементов в массиве: " + countFill);

            // Функции заполнения массива
            int FillTopRow(int[,] ArrayInFunction, int countFill, int countRow, int countCol, int globalCount)
            {
                countRow -= 1;
                int i = countRow - (countRow - globalCount);
                for (int j = 0; j < countCol; j++)
                {
                    if (ArrayInFunction[i, j] == 0)
                    {
                        ArrayInFunction[i, j] = countFill;
                        countFill++;
                    }
                }
                return (countFill);
            }

            int FillRightCol(int[,] ArrayInFunction, int countFill, int countRow, int countCol, int globalCount)
            {
                countCol -= 1;
                int j = countCol - globalCount;
                for (int i = 0; i < countRow; i++)
                {
                    if (ArrayInFunction[i, j] == 0)
                    {
                        ArrayInFunction[i, j] = countFill;
                        countFill++;
                    }
                }

                return (countFill);
            }

            int FillLowerRow(int[,] ArrayInFunction, int countFill, int countRow, int countCol, int globalCount)
            {
                countRow -= 1;
                int i = countRow - globalCount;
                for (int j = countCol - 1; j > 0; j--)
                {
                    if (ArrayInFunction[i, j] == 0)
                    {
                        ArrayInFunction[i, j] = countFill;
                        countFill++;
                    }
                }
                return (countFill);
            }

            int FillLeftCol(int[,] ArrayInFunction, int countFill, int countRow, int countCol, int globalCount)
            {
                countCol -= 1;
                int j = globalCount;
                for (int i = countRow - 1; i > 0; i--)
                {
                    if (ArrayInFunction[i, j] == 0 && i != 0)
                    {
                        ArrayInFunction[i, j] = countFill;
                        countFill++;
                    }
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