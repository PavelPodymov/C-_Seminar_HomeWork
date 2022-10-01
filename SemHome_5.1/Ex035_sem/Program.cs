/*
35. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int checkNumber(string UserString)
{
    int numb = new int();
    while (numb == 0)
    {
        Console.Write(UserString);
        var user_number = Console.ReadLine();
        int.TryParse(user_number, out numb);
        // if (numb < 0) numb = 0;
    }
    return numb;
}

int[] randomArray(int lengthArr)
{
    int[] someList = new int[lengthArr];
    for (int i = 0; i < lengthArr; i++)
    {
        someList[i] = new Random().Next(-9, 10);
    }
    return someList;
}

void searchNumberInList(int[] randArray, int num)
{
    int countNum = 0;
    for (int i = 0; i < randArray.Length; i++)
    {
        if (Math.Abs(randArray[i]) == Math.Abs(num)) countNum++;
    }
    if (countNum == 0) Console.WriteLine($"Number [{num}]: isn't in array [{String.Join(", ", randArray)}]");
    else Console.WriteLine($"Number [{num}]: is in array [{String.Join(", ", randArray)}], quantity times [{countNum}]");
}

Console.Clear();
int lengthArray = checkNumber("Please input a Length of array: ");
int searchNumber = checkNumber("Please input a Number: ");
int[] randomList = randomArray(lengthArray);
searchNumberInList(randomList, searchNumber);


