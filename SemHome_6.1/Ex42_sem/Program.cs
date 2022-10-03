/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
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

void reversDecimalNumberToBinary(int someNumber)
{
    string binaryNumber = "";

    bool count = true;
    while (count)
    {
        int concatNumber = 0;
        if (someNumber > 1)
        {
            concatNumber = someNumber % 2;
            binaryNumber += Convert.ToString(concatNumber);
            someNumber = (int)Math.Ceiling(someNumber / 2.0) - concatNumber;
        }
        else if (someNumber <= 1)
        {
            binaryNumber += Convert.ToString(someNumber);
            count = false;
        }
    }

    string newBinary = "";
    if (binaryNumber == "1") newBinary = "1";
    else if (binaryNumber == "0") newBinary = "0";
    else
    {
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (i != binaryNumber.Length - i - 1)
            {
                newBinary += binaryNumber[binaryNumber.Length - i - 1];
            }
        }
    }
    Console.WriteLine(newBinary);
}

int gelLengthOfNumberForBinaryNumber(int someNumber)
{
    int count = 0;
    while (someNumber > 0)
    {
        someNumber /= 2;
        count++;
    }
    return count;
}

void reversDecimalNumberToBinary2(int someNumber)
{
    int[] binaryNumber = new int[gelLengthOfNumberForBinaryNumber(someNumber)];
    int number = someNumber;
    if (binaryNumber.Length == 1 && someNumber == 0) binaryNumber[0] = 0;
    else if (binaryNumber.Length == 1 && someNumber == 1) binaryNumber[0] = 1;
    else
    {
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            binaryNumber[i] = number % 2;
            number /= 2;
        }
    }

    int[] newBinary = new int[binaryNumber.Length];
    
    for (int i = 0; i < binaryNumber.Length; i++)
    {
        newBinary[i] = binaryNumber[binaryNumber.Length - i - 1];
    }

    string outOf = String.Join("", newBinary);
    Console.WriteLine($"{someNumber} -> {((newBinary.Length == 0)? "0" : outOf)}");
}

Console.Clear();
int userNumber = checkNumber("Your number: ", true);
reversDecimalNumberToBinary(userNumber);
reversDecimalNumberToBinary2(userNumber);

Console.WriteLine();
Console.WriteLine("Statement");
reversDecimalNumberToBinary(45);
reversDecimalNumberToBinary(3);
reversDecimalNumberToBinary(2);
reversDecimalNumberToBinary(1);
reversDecimalNumberToBinary(0);
reversDecimalNumberToBinary(637);

Console.WriteLine();
Console.WriteLine("Second version");

reversDecimalNumberToBinary2(45);
reversDecimalNumberToBinary2(3);
reversDecimalNumberToBinary2(2);
reversDecimalNumberToBinary2(1);
reversDecimalNumberToBinary2(0);
reversDecimalNumberToBinary2(637);

