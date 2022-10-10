/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
(в случае, если матрица не квадратная)
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
            if (row == column)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{matrix[row, column]} \t");
                Console.ResetColor();
            }
            else if (matrix[row, column] < 0)
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

void FillMatrix(int[,] matrix, int start, int end)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[row, column] = new Random().Next(start, end+1);
        }
    }
}

void CheckCanMatrixToReplaceRowAndColumn(int[,] matrix)
{
    if (matrix.GetLength(1) == matrix.GetLength(0))
    {
        PrintMatrix(ChangeRowsAndColumns(matrix));
    }
    else Console.WriteLine("You can't to replace row and column");
}

int[,] ChangeRowsAndColumns(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int row = 0; row < newMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            newMatrix[row, column] = matrix[column, row];
        }
    }
    return newMatrix;
}

Console.Clear();
int NumberOfRows = checkNumber("Please input a number of rows: ", true);
int NumberOfColumns = checkNumber("Please input a number of columns: ", true);

int startDiapason = checkNumber("Start diapason: ", false);
int endDiapason = checkNumber("End diapason: ", false);


int[,] MyMatrix = new int[NumberOfRows, NumberOfColumns];

Console.WriteLine();
Console.WriteLine("Start matrix: ");
FillMatrix(MyMatrix, startDiapason, endDiapason);
PrintMatrix(MyMatrix);
Console.WriteLine();

Console.WriteLine("Your new matrix: ");
CheckCanMatrixToReplaceRowAndColumn(MyMatrix);
