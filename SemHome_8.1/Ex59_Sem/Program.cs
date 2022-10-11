/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7
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

void printColorYellow(string data)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(data);
    Console.ResetColor();
}

void printColorGreen(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void printColorRed(string data)
{
    Console.ForegroundColor = ConsoleColor.Red;
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
        printColorYellow(column + "\t");
    }
    Console.WriteLine();
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        printColorYellow(row + "\t");
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            if (row == column)
            {
                printColorGreen($"{matrix[row, column]} \t");
            }
            else if (matrix[row, column] < 0)
            {
                printColorRed($"{matrix[row, column]} \t");
            }
            else Console.Write($"{matrix[row, column]} \t");
        }
        Console.WriteLine();
    }
}

void CheckTheMatrixCanToRemoveRowAndColumn(int[,] matrix)
{
    if (matrix.GetLength(1) != 1 && matrix.GetLength(0) != 1)
    {
        DeleteRowAndColumnWithMinNumber(matrix);
    }
    else Console.WriteLine("Their is no new matrix");
}

void DeleteRowAndColumnWithMinNumber(int[,] matrix)
{
    int min = matrix.Cast<int>().Min();

    int delRow = 0;
    int delColumn = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            if (min == matrix[row, column])
            {
                delRow += row;
                delColumn += column;
                Console.WriteLine($"Min = {min}: [Rom {delRow}; Column {delColumn}]");
                break;
            }
        }
        if (min == matrix[delRow, delColumn]) break;
    }

    int[,] newArray = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int rowNew = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        if (row != delRow)
        {
            int columnNew = 0;
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (column != delColumn)
                {
                    newArray[rowNew, columnNew] = matrix[row, column];
                    Console.Write($"{matrix[row, column]} \t");
                    columnNew++;
                }
            }
            Console.WriteLine();
            rowNew++;
        }
    }

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

CheckTheMatrixCanToRemoveRowAndColumn(MyMatrix);
Console.WriteLine();

int[,] teacherMatrix = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};

CheckTheMatrixCanToRemoveRowAndColumn(teacherMatrix);