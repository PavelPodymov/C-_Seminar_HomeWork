/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
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

int[] MyArrayFromKeyBoard(int someNumber)
{
    int[] someArray = new int[someNumber];
    for (int i = 0; i < someNumber; i++)
    {
        someArray[i] = checkNumber($"Number {i+1}. ", false);
    }
    return someArray;
}

int countQuantityOfNumbersMoreThenZero(int[] someArray)
{
    int count = 0;
    for (int i = 0; i < someArray.Length; i++)
    {
        if (someArray[i] > 0) count++;
    }
    return count;
}

Console.Clear();
int number = checkNumber("Please input the quantity of numbers: ", true);

int[] myArray = MyArrayFromKeyBoard(number);
string array = String.Join(", ", myArray);
int countMoreThenZero = countQuantityOfNumbersMoreThenZero(myArray);
var moreZero = $"[{array}] - > {countMoreThenZero} number{((countMoreThenZero == 1)? "" : "s")} more then '0'";
Console.WriteLine((countMoreThenZero > 0)? moreZero : "Sorry their is no Numbers more then '0'");

