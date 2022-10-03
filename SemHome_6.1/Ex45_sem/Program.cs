/*
Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного копирования.
*/

int[] myArray = new int[] {1, 2, 4, 5, 6, 7, 8, 90};

int[] copyArray(int[] someArray)
{
    int[] Array = new int[someArray.Length];
    for (int i = 0; i < someArray.Length; i++)
    {
        Array[i] = someArray[i];
    }
    return Array;
}

int[] ReversCopyArray(int[] someArray)
{
    int[] Array = new int[someArray.Length];
    for (int i = 0; i < someArray.Length; i++)
    {
        Array[i] = someArray[someArray.Length - i - 1];
    }
    return Array;
}

int[] MyCopyArray = copyArray(myArray);
Console.WriteLine($"[{String.Join(", ", MyCopyArray)}]");

int[] MyReversCopyArray = ReversCopyArray(myArray);
Console.WriteLine($"[{String.Join(", ", MyReversCopyArray)}]");