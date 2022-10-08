/*
Показать двумерный массив размером m×n заполненный целыми числами
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

void FillMatrix(int[,] matrix, int start, int end)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[row, column] = new Random().Next(start, end + 1);
        }
    }
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(data);
    Console.ResetColor();
}

void PrintMatrix(int[,] matrix)
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
            if (matrix[row,column] < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{matrix[row,column]} \t");
                Console.ResetColor();
            }
            else Console.Write($"{matrix[row,column]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int NumberOfRows = checkNumber("Please input a number of rows: ", true);
int NumberOfColumns = checkNumber("Please input a number of columns: ", true);
int startDiapason = checkNumber("Start diapason: ", false);
int endDiapason = checkNumber("End diapason: ", false);
int[,] matrix = new int[NumberOfRows, NumberOfColumns];
FillMatrix(matrix, startDiapason, endDiapason);
PrintMatrix(matrix);
