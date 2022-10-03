/*
Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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

void averageSumOfEachColum(double[,] SomeMatrix)
{
    double[] averageSum = new double[SomeMatrix.GetLength(1)];
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < SomeMatrix.GetLength(1); column++)
        {
            averageSum[column] += SomeMatrix[row, column];
        }
    }
    for (int i = 0; i < averageSum.Length; i++)
    {
        Console.WriteLine($"{i}. column the average sum is: [{averageSum[i]}]");
    }
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

averageSumOfEachColum(MyMatrix);
