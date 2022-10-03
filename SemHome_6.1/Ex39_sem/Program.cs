/*
Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int checkTheNumber(string UserString)
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

int[] randomArray(int someLength, int start, int finish)
{
    int[] myListInt = new int[someLength];
    for (int i = 0; i < someLength; i++)
    {
        myListInt[i] = new Random().Next(start, finish + 1);
    }
    return myListInt;
}

int[] reversArray(int[] someArray)
{
    int someNumber = 0;
    for (int i = 0; i < someArray.Length / 2; i++)
    {
        if (i != someArray.Length - i - 1)
        {
            someNumber = someArray[i];
            someArray[i] = someArray[someArray.Length - i- 1];
            someArray[someArray.Length - i - 1] = someNumber;
        }
    }
    return someArray;
}

Console.Clear();
int LengthArray = checkTheNumber("Please input a length of array: ");
int[] myArray = randomArray(LengthArray, -9, 9);
string array = $"[{String.Join(", ", myArray)}]";
Console.WriteLine(array);
Console.WriteLine();

int[] myReversArray = reversArray(myArray);
string arrayRevers = $"[{String.Join(", ", myReversArray)}]";
Console.WriteLine(arrayRevers);
