/*
Задача 61: Вывести первые N строк треугольника Паскаля.
Сделать вывод в виде равнобедренного треугольника
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

int[][] FillArray(int number)
{
    int[][] myArr = new int[number+1][];
    myArr[0] = new int[1];
    myArr[0][0] = 1;

    for (int row = 1; row < number+1; row++)
    {
        myArr[row] = new int[row + 1];
        for (int column = 0; column < row; column++)
        {
            if (column == 0)
            {
                myArr[row][column] = 1;
                myArr[row][myArr[row].Length - 1] = 1;
            }
            else if (column == 1)
            {
                if (row == 2)
                {
                    myArr[row][column] = row;
                }
                else
                {
                    myArr[row][column] = row;
                    myArr[row][myArr[row].Length - 2] = row;
                }
            }
            else
            {
                if (row % 2 == 0) myArr[row][column] = myArr[row - 1][column - 1] + myArr[row - 1][column];
                else
                {
                    myArr[row][column] = myArr[row - 1][column] + myArr[row - 1][column - 1];
                    myArr[row][myArr[row].Length - column - 1] = myArr[row - 1][column] + myArr[row - 1][column - 1];
                }
            }
        }
    }
    return myArr;
}

void PrintPascalTriangle(int number, int[][] someArr)
{
    for (int i = 0; i < number+1; i++)
    {
        for (int j = 0; j < someArr[i].Length; j++)
        {
            Console.Write("{0}\t", someArr[i][j]);
        }
        Console.WriteLine();
    }
}

Console.Clear();

int number = checkNumber("Your number: ", true);
int[][] Array = FillArray(number);
PrintPascalTriangle(number, Array);
