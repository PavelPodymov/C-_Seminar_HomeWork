/*
34. Напишите программу замена элементов массива: положительные
элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

int[] randomArray(int lenghtArray)
{
    int[] someList = new int[lenghtArray];
    for (int i = 0; i < lenghtArray; i++)
    {
        someList[i] = new Random().Next(-9, 10);
    }
    return someList;
}

int[] changeMark(int[] randArray)
{
    for (int i = 0; i < randArray.Length; i++)
    {
        randArray[i] *= -1;
        // Console.WriteLine(randArray[i]);
    }
    return randArray;
}

Console.Clear();
int number = checkNumber("Please input a Length of array: ");
int[] randomList = randomArray(number);
Console.Write($"Old list [{String.Join(", ", randomList)}] -> ");
int[] randomListWithChangeMark = changeMark(randomList);
Console.Write($"New List [{String.Join(", ", randomListWithChangeMark)}]");

