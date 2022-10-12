/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
    Console.WriteLine();
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int newRow = 0;
    if (matrix1.GetLength(0) >= matrix2.GetLength(0)) newRow = matrix1.GetLength(0);
    else newRow = matrix2.GetLength(0);

    int newColumn = 0;
    if (matrix1.GetLength(1) == 1 || matrix2.GetLength(1) == 1) newColumn = 1;
    else if (matrix1.GetLength(1) > matrix2.GetLength(1)) newColumn = matrix1.GetLength(1);
    else newColumn = matrix2.GetLength(1);

    int[,] newMyMatrix = new int[newRow, newColumn];

    for (int row = 0; row < newMyMatrix.GetLength(0); row++)
    {
        for (int column = 0; column < newMyMatrix.GetLength(1); column++)
        {
            if (matrix1.GetLength(1) != 1 && matrix2.GetLength(1) != 1)
            {
                for (int i = 0; i < newMyMatrix.GetLength(1); i++)
                {
                    newMyMatrix[row, column] += matrix1[row, i] * matrix2[i, column];
                }
            }
            else
            {
                for (int i = 0; i < newMyMatrix.GetLength(0); i++)
                {
                    newMyMatrix[row, column] += matrix1[row, i] * matrix2[i, column];
                }
            }
        }
    }
    return newMyMatrix;
}

void CheckMatrixAndPrint(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        PrintMatrix(MultiplyMatrix(matrix1, matrix2));
    }
    else Console.WriteLine("Sorry, you can't to multiply two matrix.");
}

Console.Clear();
Console.WriteLine("First Matrix");
int NumberOfRows1 = checkNumber("Please input a number of rows: ", true);
int NumberOfColumns1 = checkNumber("Please input a number of columns: ", true);

Console.WriteLine("Second Matrix");
int NumberOfRows2 = checkNumber("Please input a number of rows: ", true);
int NumberOfColumns2 = checkNumber("Please input a number of columns: ", true);

int startDiapason = checkNumber("Start diapason: ", false);
int endDiapason = checkNumber("End diapason: ", false);

int[,] MyMatrix1 = new int[NumberOfRows1, NumberOfColumns1];
FillMatrix(MyMatrix1, startDiapason, endDiapason);
int[,] MyMatrix2 = new int[NumberOfRows2, NumberOfColumns2];
FillMatrix(MyMatrix2, startDiapason, endDiapason);

Console.WriteLine("Matrix 1: ");
PrintMatrix(MyMatrix1);

Console.WriteLine();

Console.WriteLine("Matrix 2: ");
PrintMatrix(MyMatrix2);

Console.WriteLine("Your new matrix: ");
CheckMatrixAndPrint(MyMatrix1, MyMatrix2);

Console.WriteLine();


int[,] teacherMatrix1 = {
    {2, 4},
    {3, 2}
};

int[,] teacherMatrix2 = {
    {3, 4},
    {3, 3}
};

CheckMatrixAndPrint(teacherMatrix1, teacherMatrix2);


