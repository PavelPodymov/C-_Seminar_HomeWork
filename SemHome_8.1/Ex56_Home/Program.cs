/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер
строки с наименьшей суммой элементов: 1 строка
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

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    Console.WriteLine($"rows = {matrix.GetLength(0)}, columns = {matrix.GetLength(1)}");

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row, column]} \t");
        }
        Console.WriteLine();
    }
}

void SumOfNumbersInColumn(int[,] matrix)
{
    Dictionary<int, int> myDict = new Dictionary<int, int>();
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int sum = 0;
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            sum += matrix[row, column];
        }
        myDict.Add(row, sum);
    }

    foreach (var item in myDict)
    {
        if (item.Value == myDict.Values.Min())
        {
            int index = item.Key;
            int row = item.Key+1;
            int sum = item.Value;
            Console.WriteLine($"Minimum sum of numbers is in row: [{row}], index of row: [{index}] and sum= {sum}.");
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

int[,] teacherMatrix = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};
SumOfNumbersInColumn(MyMatrix);
Console.WriteLine();
PrintMatrix(teacherMatrix);
SumOfNumbersInColumn(teacherMatrix);