void NewTask()
{
    System.Console.WriteLine("Нажмите Enter для продолжения и перехода к следующей задаче");
    Console.ReadLine();
    Console.Clear();
}
int GetNumber(string numberName)
{
    System.Console.Write($"Введите значение для {numberName}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[,] GetMatrixWithFloat(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rand.NextDouble() * (max - min) + min), 1);
        }

    }
    return matrix;
}
int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max);
        }

    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void PrintMatrixWithFloat(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void CheckValue(int[,] matrix)
{
    int value = GetNumber("проверки его наличия в матрице");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (matrix[i, j] == value)
            {
                System.Console.WriteLine($"Первый раз число '{value}' встречается в этой матрице под индексом [{i}, {j}].");
                return;
            }

        }

    }
    System.Console.WriteLine($"Число {value} в данной матрице не встречается.");
}
void GetSum(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0.0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        System.Console.WriteLine($"Среднее значение столбца номер {j+1} = {sum/matrix.GetLength(0)}");
    }
}
Console.Clear();
System.Console.WriteLine("Задача 47. Задайте двумерный массив размером m x n заполненный случайными вещественными числами.");
int rowsInMatrix = GetNumber("m");
int columnsInMatrix = GetNumber("n");
int min = GetNumber("минимального числа");
int max = GetNumber("максимального числа");
double[,] matrix = GetMatrixWithFloat(rowsInMatrix, columnsInMatrix, min, max);
PrintMatrixWithFloat(matrix);

NewTask();
System.Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает" +
"его индексы первого найденого числа или же указание, что такого элемента нет.");
int[,] matr = GetMatrix(3, 3, 1, 10);
PrintMatrix(matr);
CheckValue(matr);

NewTask();
System.Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
 rowsInMatrix = GetNumber("количества строк: ");
 columnsInMatrix = GetNumber("количества столбцов: ");
matr = GetMatrix(rowsInMatrix, columnsInMatrix, 1, 10);
PrintMatrix(matr);
GetSum(matr);
