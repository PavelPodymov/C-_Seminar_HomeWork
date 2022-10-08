/*
Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
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

void createMatrixFromSumIndexes(int[,] createMatrix)
{
    for (int row = 0; row < createMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < createMatrix.GetLength(1); column++)
        {
            createMatrix[row, column] = row + column;
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
    Console.WriteLine($"rows = {matrix.GetLength(0)}, columns = {matrix.GetLength(1)}");
    Console.Write("\t");
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        printColorData((column + 1) + "\t");
    }
    Console.WriteLine();
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        printColorData((row +1) +"\t");
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row, column]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int NumberOfRows = checkNumber("Please input a number of rows: ", true);
int NumberOfColumns = checkNumber("Please input a number of columns: ", true);

int[,] matrix = new int[NumberOfRows, NumberOfColumns];
Console.WriteLine();
createMatrixFromSumIndexes(matrix);
PrintMatrix(matrix);