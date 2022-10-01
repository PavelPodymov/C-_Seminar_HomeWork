/*
33. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
сумма отрицательных равна -20.
*/


int checkNumber(string UserString)
{
    int numb = new int();
    while (numb == 0)
    {
        Console.Write(UserString);
        var user_number = Console.ReadLine();
        int.TryParse(user_number, out numb);
        if (numb < 0) numb = 0;
    }
    return numb;
}

int[] randomArray(int num)
{
    // List<int> myListInt = new List<int> ();
    // or
    int[] myListInt = new int[num];
    for (int i = 0; i < num; i++)
    {
        // int randomNumber = new Random().Next(-9, 10);
        // myListInt.Add(randomNumber);
        // or
        myListInt[i] = new Random().Next(-9, 10);
    }
    return myListInt;
}

void countPlusAndMinusNumbersInArray(int[] someList)
{
    int plusNumbers = 0;
    int minusNumbers = 0;
    int countyPlusNumbers = 0;
    int countyMinusNumbers = 0;

    foreach (var item in someList)
    {
        if (item > 0)
        {
            plusNumbers += item;
            countyPlusNumbers++;
        }
        else
        {
            minusNumbers += item;
            countyMinusNumbers++;
        }
    }
    Console.WriteLine($"Quantity of Plus numbers is: [{countyPlusNumbers}] and sum = [{plusNumbers}],");
    Console.WriteLine($"Quantity of Minus numbers is: [{countyMinusNumbers}] and sum = [{minusNumbers}],");
}

Console.Clear();

int number = checkNumber("Please input a Length of array: ");
int[] outListArray = randomArray(number);
Console.WriteLine($"[{String.Join(", ", outListArray)}]");
countPlusAndMinusNumbersInArray(outListArray);

Console.WriteLine();
int[] newListArray = {3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6};
countPlusAndMinusNumbersInArray(newListArray);