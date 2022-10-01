/*
37. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
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

int[] randomArrayWithNumberBetween0_200(int LengthOfArray)
{
    int[] myListInt = new int[LengthOfArray];
    for (int i = 0; i < LengthOfArray; i++)
    {
        myListInt[i] = new Random().Next(0, 201);
    }
    return myListInt;
}

void checkTheDiapasonOfNumbersInArray(int[] someList, int start, int end)
{
    int count = 0;
    for (int i = 0; i < someList.Length; i++)
    {
        if (someList[i] >= start && someList[i] <= end) count++;
    }
    if (count == 0) Console.WriteLine($"In random array: [{String.Join(", ", someList)}], NO numbers in Diapason({start},{end})");
    else Console.WriteLine($"Random array: [{String.Join(", ", someList)}] -> Quantity of numbers is: [{count}] in Diapason ({start},{end})");
}

Console.Clear();
int lengthArray = checkNumber("Please input a Length of array: ");
int startDiapason = checkNumber("Please input a START diapason: ");
int endDiapason = checkNumber("Please input a END diapason: ");
int[] randAr = randomArrayWithNumberBetween0_200(lengthArray);
checkTheDiapasonOfNumbersInArray(randAr, startDiapason, endDiapason);
