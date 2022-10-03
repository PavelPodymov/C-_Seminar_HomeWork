/*
В двумерном массиве показать позиции числа,
заданного пользователем или указать, что такого элемента нет
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

void positionOfNumber(double[,] SomeMatrix, int someNumber)
{
    int count = 1;
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < SomeMatrix.GetLength(1); column++)
        {
            if (SomeMatrix[row, column] == someNumber) 
            {
                Console.WriteLine($"{count}. SomeMatrix[{row}, {column}]");
                count++;
            }
        }
    }
    string no = "Their is NO numbers in matrix";
    string yes = $"Their is {count-1} number{((count > 2)? "s" : "")} in matrix";
    Console.WriteLine((count == 1)? no : yes);
}

Console.Clear();
int NumberOfRows = checkTheNumber("Please input a number of rows: ");
int NumberOfColumns = checkTheNumber("Please input a number of columns: ");

int userNumber = checkTheNumber("Please input a number: ");

double[,] MyMatrix = new double[NumberOfRows, NumberOfColumns];
Console.WriteLine("Start matrix: ");
FillMatrix(MyMatrix);
PrintMatrix(MyMatrix);

Console.WriteLine();
positionOfNumber(MyMatrix, userNumber);

