/*
39. Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] randomArrayWithNumberBetweenTO_10(int LengthOfArray)
{
    int[] myListInt = new int[LengthOfArray];
    for (int i = 0; i < LengthOfArray; i++)
    {
        myListInt[i] = new Random().Next(-10, 10);
    }
    return myListInt;
}

int[] multiplicationFirstAndLastTillTheCenter(int[] someArray)
{
    int lengthAr = someArray.Length;
    int lengthNew = 0;
        
    if (lengthAr % 2 == 0) lengthNew = lengthAr/2;
    else lengthNew = lengthAr/2 + 1;

    int[] newArray = new int[lengthNew];
    int index = 1;

    for (int i = 0; i < lengthNew; i++)
    {
        if (i < lengthAr - index) newArray[i] = someArray[i] * someArray[lengthAr - index];
        else newArray[i] = someArray[i];
        index++;
    }
    return newArray;
}

Console.Clear();
int lengthArray = checkNumber("Please input a Length of array: ");
int[] randAr = randomArrayWithNumberBetweenTO_10(lengthArray);
Console.Write($"[{String.Join(", ", randAr)}]");
int[] newArr = multiplicationFirstAndLastTillTheCenter(randAr);
Console.Write($" -> [{String.Join(", ", newArr)}]");

