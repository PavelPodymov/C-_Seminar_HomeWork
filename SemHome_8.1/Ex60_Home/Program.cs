/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

void FillMatrix(int[,,] matrix, int start, int end)
{
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                bool notFind = true;
                while (notFind)
                {
                    int number = new Random().Next(start, end + 1);
                    int count = 0;
                    foreach (int item in matrix)
                    {
                        if (item == number) count++;
                    }
                    if (count == 0)
                    {
                        matrix[x, y, z] = number;
                        notFind = false;
                    }
                }
            }
        }
    }
}

void PrintThreeDMatrix(int[,,] matrix)
{
    Console.WriteLine();
    Console.WriteLine($"x = {matrix.GetLength(0)}, y = {matrix.GetLength(1)}, z = {matrix.GetLength(2)}");

    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(1); z++)
            {
                Console.Write($"{matrix[x, y, z]} ({x}, {y}, {z}) \t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("First Matrix");
int x = checkNumber("Please input X: ", true);
int y = checkNumber("Please input Y: ", true);
int z = checkNumber("Please input Z: ", true);

// int startDiapason = checkNumber("Start diapason: ", false);
// int endDiapason = checkNumber("End diapason: ", false);

int startDiapason = 10;
int endDiapason = 99;

int[,,] ThreeDMatrix = new int[x, y, z];
FillMatrix(ThreeDMatrix, startDiapason, endDiapason);
PrintThreeDMatrix(ThreeDMatrix);


int[,,] teacherMatrix = new int[2,2,2];
teacherMatrix[0,0,0] = 66;
teacherMatrix[0,1,0] = 25;
teacherMatrix[1,0,0] = 34;
teacherMatrix[1,1,0] = 41;
teacherMatrix[0,0,1] = 27;
teacherMatrix[0,1,1] = 90;
teacherMatrix[1,0,1] = 26;
teacherMatrix[1,1,1] = 55;
PrintThreeDMatrix(teacherMatrix);