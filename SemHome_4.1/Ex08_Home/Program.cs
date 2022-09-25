/*
Задача 29: Напишите программу, в которой пользователь задает длину массива,
элементы которого задаются в диапазоне [1,99] и выводит на экран.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
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

string randomArray(int num)
{
    List<int> myListInt = new List<int> ();
    for (int i = 1; i <= num; i++)
    {
        int randomNumber = new Random().Next(1, 100);
        myListInt.Add(randomNumber);
    }
    return String.Join(", ", myListInt);
}

Console.Clear();

int number = checkNumber("Please input a Length of array: ");
// randomArray(number);
Console.WriteLine($"The lenght of array [{number}] -> [{randomArray(number)}]");



