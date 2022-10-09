/*
Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int checkNumber(string UserString, bool OnlyMarkPlus)
{
    int numb = new int();
    bool startCount = true;
    while (startCount)
    {
        Console.Write(UserString);
        var user_number = Console.ReadLine();

        int.TryParse(user_number, out numb);

        if (numb <= 0 && OnlyMarkPlus == true) startCount = true;
        else
        {
            if (numb == 0 && user_number != "0") startCount = true;
            else startCount = false;
        }
    }
    return numb;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(data);
    Console.ResetColor();
}

void PrintMatrix(double[,] matrix)
{
    Console.WriteLine();
    Console.WriteLine($"rows = {matrix.GetLength(0)}, columns = {matrix.GetLength(1)}");
    Console.Write("\t");
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        printColorData(column + "\t");
    }
    Console.WriteLine();
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        printColorData(row + "\t");
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row, column]} \t");
        }
        Console.WriteLine();
    }
}

double[,] FillMatrix(double[,] SomeMatrix, int start, int end)
{
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < SomeMatrix.GetLength(1); column++)
        {
            SomeMatrix[row, column] = new Random().Next(start, end +1);
        }
    }
    return SomeMatrix;
}

void averageSumOfEachColum(double[,] matrix)
{
    double[] Sum = new double[matrix.GetLength(1)];
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Sum[column] += matrix[row, column];
        }
    }

    double[] averageSum = new double[Sum.Length];
    for (int i = 0; i < Sum.Length; i++)
    {
        averageSum[i] = Math.Round(Sum[i]/matrix.GetLength(0), 1);
    }

    for (int i = 0; i < averageSum.Length; i++)
    {
        Console.WriteLine($" column [{i}] the average sum is: [{averageSum[i]:F1}]");
    }
    Console.WriteLine($"The average sum of each column: [{(String.Join(", ", averageSum))}].");
}

Console.Clear();
int NumberOfRows = checkNumber("Please input a number of rows: ", true);
int NumberOfColumns = checkNumber("Please input a number of columns: ", true);

int startDiapason = checkNumber("Start diapason: ", false);
int endDiapason = checkNumber("End diapason: ", false);

double[,] MyMatrix = new double[NumberOfRows, NumberOfColumns];

Console.WriteLine();
Console.WriteLine("Matrix: ");
FillMatrix(MyMatrix, startDiapason, endDiapason);
PrintMatrix(MyMatrix);
Console.WriteLine();

averageSumOfEachColum(MyMatrix);
