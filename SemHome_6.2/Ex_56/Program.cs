/*
Написать программу, которая обменивает элементы первой строки и последней строки
*/

int checkTheNumber(string UserString)
{
    int numb = new int();
    while (numb == 0)
    {
        Console.Write(UserString);
        var user_number = Console.ReadLine();
        int.TryParse(user_number, out numb);
        if (numb < 0) numb = 0;
    }
    return numb;
}

void PrintMatrix(double[,] SomeMatrix)
{
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < SomeMatrix.GetLength(1); column++)
        {
            Console.Write($"{SomeMatrix[row, column]} ");
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

double[,] ChangeFirstRowAndLastRow(double[,] SomeMatrix)
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


Console.Clear();
int NumberOfRows = checkTheNumber("Please input a number of rows: ");
int NumberOfColumns = checkTheNumber("Please input a number of columns: ");

double[,] MyMatrix = new double[NumberOfRows, NumberOfColumns];

Console.WriteLine();
Console.WriteLine("Start matrix: ");
FillMatrix(MyMatrix);
PrintMatrix(MyMatrix);
Console.WriteLine();

Console.WriteLine("Your new matrix: ");
double[,] MyNewMatrix = (double[,])MyMatrix.Clone();
ChangeFirstRowAndLastRow(MyNewMatrix);
PrintMatrix(MyNewMatrix);