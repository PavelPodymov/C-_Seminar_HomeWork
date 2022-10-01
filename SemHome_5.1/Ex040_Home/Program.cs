/*
40.  Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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

double[] randomArrayWithNumberBetween0_100(int LengthOfArray)
{
    double[] myListInt = new double[LengthOfArray];
    for (int i = 0; i < LengthOfArray; i++)
    {
        myListInt[i] = new Random().Next(0, 100);
    }
    return myListInt;
}

double differenceMax(double[] someArray)
{
    double max = 0;
    for (int i = 0; i < someArray.Length; i++)
    {
        if (someArray[i] > max) max = someArray[i];
    }
    return max;
}

double differenceMin(double[] someArray)
{
    double min = someArray[0];
    for (int i = 0; i < someArray.Length; i++)
    {
        if (someArray[i] < min) min = someArray[i];
    }
    return min;
}

Console.Clear();
int lengthArray = checkNumber("Please input a Length of array: ");
double[] randAr = randomArrayWithNumberBetween0_100(lengthArray);
string mass = String.Join(", ", randAr);
double Max = differenceMax(randAr);
double Min = differenceMin(randAr);
Console.WriteLine($"[{mass}] - > difference between max {Max} and min {Min} is: [{Max - Min}]");