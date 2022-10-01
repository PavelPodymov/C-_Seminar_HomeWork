/*
38. Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int[] randomArrayWithNumberBetweenTO_200(int LengthOfArray)
{
    int[] myListInt = new int[LengthOfArray];
    for (int i = 0; i < LengthOfArray; i++)
    {
        myListInt[i] = new Random().Next(-200, 201);
    }
    return myListInt;
}

int sumNumbersWithEvenIndex(int[] someList)
{
    int sum = 0;
    for (int i = 1; i < someList.Length; i += 2)
    {
        sum += someList[i];
    }
    return sum;
}

Console.Clear();
int lengthArray = checkNumber("Please input a Length of array: ");
int[] randAr = randomArrayWithNumberBetweenTO_200(lengthArray);
int countyOfNumbers = sumNumbersWithEvenIndex(randAr);
string finalArray = String.Join(", ", randAr);
Console.WriteLine($"In random array: [{finalArray}], sum of Numbers with Even Index is: ({countyOfNumbers}).");
