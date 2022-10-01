/*
36. Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int[] randomArrayWithNumberBetween100_999(int LengthOfArray)
{
    int[] myListInt = new int[LengthOfArray];
    for (int i = 0; i < LengthOfArray; i++)
    {
        myListInt[i] = new Random().Next(100, 1000);
    }
    return myListInt;
}

void checkEvenness(int[] someList)
{
    int count = 0;
    for (int i = 0; i < someList.Length; i++)
    {
        if (someList[i] % 2 == 0) count++;
    }
    if (count == 0) Console.WriteLine($"In random array: [{String.Join(", ", someList)}], NO EVEN numbers");
    else Console.WriteLine($"Random array: [{String.Join(", ", someList)}] -> Quantity of EVEN numbers is: [{count}]");
}

Console.Clear();
int lengthArray = checkNumber("Please input a Length of array: ");
int[] array = randomArrayWithNumberBetween100_999(lengthArray);
checkEvenness(array);
