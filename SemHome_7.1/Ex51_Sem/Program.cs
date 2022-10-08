/*
В матрице чисел найти сумму элементов главной диагонали

Задача 51: Задайте двумерный массив. Найдите Сумма элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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
            if (row == column)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{matrix[row, column]} \t");
                Console.ResetColor();
            }
            else Console.Write($"{matrix[row, column]} \t");
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

void sumOfMainDiagonal(double[,] SomeMatrix)
{
    double[] arraySum = new double[SomeMatrix.GetLength(0)];
    int count = 0;
    double sum = 0;
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < SomeMatrix.GetLength(1); column++)
        {
            if (row == column)
            {
                sum += SomeMatrix[row, column];
                arraySum[count] = SomeMatrix[row, column];
                count++;
            }
        }
    }
    string myArray = String.Join(" + ", arraySum);
    Console.WriteLine();
    Console.WriteLine($"The summer of main diagonal is: ({myArray}) = [{sum}]");
}


Console.Clear();
int NumberOfRows = checkNumber("Please input a number of rows: ", true);
int NumberOfColumns = checkNumber("Please input a number of columns: ", true);

double[,] MyMatrix = new double[NumberOfRows, NumberOfColumns];

Console.WriteLine("Matrix: ");
FillMatrix(MyMatrix, 0, 10);
PrintMatrix(MyMatrix);
Console.WriteLine();

sumOfMainDiagonal(MyMatrix);