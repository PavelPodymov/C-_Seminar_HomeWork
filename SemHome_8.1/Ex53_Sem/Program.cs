/* 
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.
*/
Random random = new Random();

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
            if (matrix[row, column] < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{matrix[row, column]:F1} \t");
                Console.ResetColor();
            }
            else Console.Write($"{matrix[row, column]:F1} \t");
        }
        Console.WriteLine();
    }
}

void FillMatrix(double[,] matrix, int start, int end)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[row, column] = random.Next(start, end+1);
        }
    }
}

double[,] ChangeFirstRowToLastRow(double[,] SomeMatrix)
{
    double someNumber = 0;
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        if (row == 0 || row == SomeMatrix.GetLength(0) - 1)
        {
            for (int column = 0; column < SomeMatrix.GetLength(1); column++)
            {
                someNumber = SomeMatrix[row, column];
                SomeMatrix[row, column] = SomeMatrix[SomeMatrix.GetLength(0) - 1, column];
                SomeMatrix[SomeMatrix.GetLength(0) - 1, column] = someNumber;
            }
        }
    }
    return SomeMatrix;
}

double[,] ChangeRowAndColumn(double[,] SomeMatrix, int row1, int row2)
{
    for (int column = 0; column < SomeMatrix.GetLength(1); column++)
    {
        double someNumber = SomeMatrix[row1, column];
        SomeMatrix[row1, column] = SomeMatrix[row2, column];
        SomeMatrix[row2, column] = someNumber;
    }
    return SomeMatrix;
}

Console.Clear();
int NumberOfRows = checkNumber("Please input a number of rows: ", true);
int NumberOfColumns = checkNumber("Please input a number of columns: ", true);

int startDiapason = checkNumber("Start diapason: ", false);
int endDiapason = checkNumber("End diapason: ", false);


double[,] MyMatrix = new double[NumberOfRows, NumberOfColumns];

Console.WriteLine();
Console.WriteLine("Start matrix: ");
FillMatrix(MyMatrix, startDiapason, endDiapason);
PrintMatrix(MyMatrix);
Console.WriteLine();

Console.WriteLine("Your new matrix: ");
double[,] MyNewMatrix = (double[,])MyMatrix.Clone();
ChangeFirstRowToLastRow(MyNewMatrix);
PrintMatrix(MyNewMatrix);


Console.WriteLine();
Console.WriteLine("Your next matrix: ");
ChangeRowAndColumn(MyNewMatrix, 1, MyNewMatrix.GetLength(0)-1);
PrintMatrix(MyNewMatrix);
