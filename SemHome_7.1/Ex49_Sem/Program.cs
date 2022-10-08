/*
В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
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
            if (row % 2 == 0 && column % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{matrix[row, column]} \t");
                Console.ResetColor();
            }
            else Console.Write($"{matrix[row, column]} \t");
        }
        Console.WriteLine();
    }
}

double[,] FillMatrix(double[,] SomeMatrix)
{
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < SomeMatrix.GetLength(1); column++)
        {
            SomeMatrix[row, column] = new Random().Next(1, 10);
        }
    }
    return SomeMatrix;
}

void ElementWithEvenIndexChangeToSquareElement(double[,] SomeMatrix)
{
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        if (row % 2 == 0)
        {
            for (int column = 0; column < SomeMatrix.GetLength(1); column++)
            {
                if (column % 2 == 0)
                {
                    SomeMatrix[row, column] *= SomeMatrix[row, column];
                }
            }
        }
    }
}

Console.Clear();
int NumberOfRows = checkNumber("Please input a number of rows: ", true);
int NumberOfColumns = checkNumber("Please input a number of columns: ", true);
double[,] MyMatrix = new double[NumberOfRows, NumberOfColumns];
Console.WriteLine("Start matrix: ");
FillMatrix(MyMatrix);
PrintMatrix(MyMatrix);

Console.WriteLine();

Console.WriteLine("Change Element with even index in matrix to their square: ");
double[,] EvenIndex = (double[,])MyMatrix.Clone();

ElementWithEvenIndexChangeToSquareElement(EvenIndex);
PrintMatrix(EvenIndex);
