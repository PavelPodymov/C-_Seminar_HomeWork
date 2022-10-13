/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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

void PrintArray(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int colum = 0; colum < matrix.GetLength(1); colum++)
        {
        Console.Write("{0:D2}  ", matrix[row, colum]);
        }
        Console.WriteLine();
    }
}

void FillArray(int length)
{

    Console.WriteLine();

    int[,] matrix = new int[length, length];

    int row = 0, column = 0;

    int number = 1;

    while (length != 0)
    {
        int p = 0; // padding
        do { matrix[row, column++] = number++; } while (++p < length - 1); // fill first row with column -1
        for (p = 0; p < length - 1; p++) matrix[row++, column] = number++; // tern right and fill last column without last row
        for (p = 0; p < length - 1; p++) matrix[row, column--] = number++;
        for (p = 0; p < length - 1; p++) matrix[row--, column] = number++;

        ++row;
        ++column;
        length = length < 2 ? 0 : length - 2;
    }
    PrintArray(matrix);
}

Console.WriteLine();

Console.Clear();
int number = checkNumber("Your number: ", true);
FillArray(number);
Console.WriteLine();

