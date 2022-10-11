/*
Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
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

void countQuantityOfItemsInMatrix(int[,] matrix)
{
    int min = matrix.Cast<int>().Min();
    int max = matrix.Cast<int>().Max();
    for (int i = min; i <= max; i++)
    {
        int count = 0;
        foreach (var item in matrix)
        {
            if (item == i) count++;
        }
        if (count !=0) Console.WriteLine($" {i} exist {count} time{((count>1)? "s." : ".")}");
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


countQuantityOfItemsInMatrix(MyMatrix);
Console.WriteLine();

int[,] teacherArray = { {1, 9, 9, 0, 2, 8, 0, 9} };
int[,] teacherArray2 = { { 1, 2, 3 }, { 4, 6, 1 }, { 2, 1, 6 } };

countQuantityOfItemsInMatrix(teacherArray);
Console.WriteLine();
countQuantityOfItemsInMatrix(teacherArray2);