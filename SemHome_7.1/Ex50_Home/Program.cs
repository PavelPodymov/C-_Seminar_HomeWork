/*
В двумерном массиве показать позиции числа,
заданного пользователем или указать, что такого элемента нет

Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9

индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4

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

void PrintMatrix(double[,] matrix, int number)
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
            if (matrix[row, column] == number)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{matrix[row, column]} \t");
                Console.ResetColor();
            }
            else Console.Write($"{matrix[row, column]} \t");
        }
        Console.WriteLine();
    }
}

double[,] FillMatrix(double[,] SomeMatrix, int start, int end)
{
    for (int row = 0; row < SomeMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < SomeMatrix.GetLength(1); column++)
        {
            SomeMatrix[row, column] = new Random().Next(start, end +1);
        }
    }
    return SomeMatrix;
}

void findIndexOfNumbers(double[,] matrix, int someNumber)
{
    int count = 0;
    int indexNumber = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            if (matrix[row, column] == someNumber) 
            {
                count++;
                Console.WriteLine($"{count}. Matrix[{row}, {column}] - index [{indexNumber}]");
            }
            indexNumber++;
        }
    }
    string no = "Their is NO numbers in matrix";
    string yes = $"[{someNumber}] their is {count} time{((count > 1)? "s" : "")} in matrix";
    Console.WriteLine((count == 0)? no : yes);
}

string getNumberUseIndex(double[,] matrix, int index)
{
    int indexNumber = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            string no = $"Their is NO number with index [{index}] in the matrix";
            if (index == indexNumber)
            {
                return $"Index [{index}], matrix[{row}, {column}] -> number [{matrix[row,column]}]";
            }
            indexNumber++;
        }
    }
    return $"Their is NO number with index [{index}] in the matrix";
}

Console.Clear();
int NumberOfRows = checkNumber("Please input a number of rows: ", true);
int NumberOfColumns = checkNumber("Please input a number of columns: ", true);

int startDiapason = checkNumber("Start diapason: ", false);
int endDiapason = checkNumber("End diapason: ", false);

double[,] MyMatrix = new double[NumberOfRows, NumberOfColumns];

FillMatrix(MyMatrix, startDiapason, endDiapason);
int userNumber = checkNumber("Please input a number: ", false);
int userIndex = checkNumber("Please input a index: ", false);

Console.WriteLine();
Console.WriteLine("Matrix: ");
PrintMatrix(MyMatrix, userNumber);

Console.WriteLine();
findIndexOfNumbers(MyMatrix, userNumber);
Console.WriteLine();
Console.WriteLine(getNumberUseIndex(MyMatrix, userIndex));