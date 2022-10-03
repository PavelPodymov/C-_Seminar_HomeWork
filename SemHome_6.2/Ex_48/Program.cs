/*
Показать двумерный массив размером m×n заполненный целыми числами
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

void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row, column]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[row, column] = new Random().Next(1, 10);
        }
    }
}

Console.Clear();
int NumberOfRows = checkTheNumber("Please input a number of rows: ");
int NumberOfColumns = checkTheNumber("Please input a number of columns: ");
int[,] matrix = new int[NumberOfRows, NumberOfColumns];
FillMatrix(matrix);
PrintMatrix(matrix);
