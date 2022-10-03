/*
В двумерном массиве n×k заменить четные элементы на противоположные
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

void ElementWithEvenIndexChangeToOpposite(double[,] SomeMatrix)
{
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        if (row % 2 == 0)
        {
            for (int column = 0; column < SomeMatrix.GetLength(1); column++)
            {
                if (column % 2 == 0)
                {
                    SomeMatrix[row, column] *= -1;
                }
            }
        }
    }
}

void ChangeEvenElementToOpposite(double[,] SomeMatrix)
{
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < SomeMatrix.GetLength(1); column++)
        {
            if (SomeMatrix[row, column] % 2 == 0)
            {
                SomeMatrix[row, column] *= -1;
            }
        }
    }
}

Console.Clear();
int NumberOfRows = checkTheNumber("Please input a number of rows: ");
int NumberOfColumns = checkTheNumber("Please input a number of columns: ");
double[,] MyMatrix = new double[NumberOfRows, NumberOfColumns];
Console.WriteLine("Start matrix: ");
FillMatrix(MyMatrix);
PrintMatrix(MyMatrix);

Console.WriteLine();

Console.WriteLine("Change even index in matrix: ");
double[,] EvenIndex = (double[,])MyMatrix.Clone();

ElementWithEvenIndexChangeToOpposite(EvenIndex);
PrintMatrix(EvenIndex);

Console.WriteLine();

Console.WriteLine("Change even element in matrix: ");
double[,] EvenElement = (double[,])MyMatrix.Clone();

ChangeEvenElementToOpposite(EvenElement);
PrintMatrix(EvenElement);