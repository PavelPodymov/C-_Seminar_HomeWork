/*
*Задача(сложная не на оценку) *
Напишите программу, которая находит подмножество данного множества чисел такое,
что сумма его элементов равна заданному числу

Множество {1, 3, 4, 2} 
Задано c клавиатуры: 5 - > YES {2, 3}
Задано c клавиатуры: 5 - > YES {1, 4}

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

int[] randomArray1To9(int num)
{
    int[] myListInt = new int[num];
    for (int i = 0; i < num; i++)
    {
        myListInt[i] = new Random().Next(1, 10);
    }
    return myListInt;
}

int[] sumElementInArrayEqualNumberFormOtherArray(int[] someArray, int someNumber)
{
    int[] newArray = new int[someArray.Length];
    int sumN = 0;
    if (someNumber > someArray.Sum()) return new int[0];
    else if (someNumber < someArray.Min()) return new int[0];
    else
    {
        for (int j = 0; j < someArray.Length; j++)
        {
            if (someArray[j] > someNumber) j=j+0;
            else if (someArray[j] == someNumber && sumN == 0)
            {
                newArray[0] = someNumber;
                return newArray;
            }
            else if (sumN < someNumber)
            {
                sumN += someArray[j];
                newArray[j] = someArray[j];
                for (int i = 0; i < someArray.Length; i++)
                {
                    if (j == i) i = i+0;
                    else
                    {
                        if (someArray[i] > someNumber) i = i+0;
                        else if (someArray[i] == someNumber && sumN == 0)
                        {
                            newArray[0] = someNumber;
                            return newArray;
                        }
                        else if (sumN + someArray[i] <= someNumber)
                        {
                            sumN += someArray[i];
                            newArray[i] = someArray[i];
                            if (sumN == someNumber) return newArray;
                        }
                    }
                }
                if (sumN < someNumber)
                {
                    sumN=0;
                    newArray = new int[someArray.Length];
                    j=j+0;
                }
            }
        }
    }
    if (sumN < someNumber) return new int[0];
    return newArray;
}

int[] removeZero(int[] array)
{
    List<int> list_numbers = new List<int>();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0) list_numbers.Add(array[i]);
    }
    array = list_numbers.ToArray();
    return array;
}


Console.Clear();
int lengthArray = checkNumber("Your length of array is: ", true);
int[] randomArray = randomArray1To9(lengthArray);
// int[] randomArray = {9, 7, 8, 9, 8};
Console.WriteLine(String.Join(", ", randomArray));

int userNumber = checkNumber("Your number is: ", true);

// int userNumber = 18;

int[] myArray = sumElementInArrayEqualNumberFormOtherArray(randomArray, userNumber);

int[] rightArray = removeZero(myArray);

string answerCannotBuildArray = "You cannot build an array";

string answerNewArray = $"Your array: [{String.Join(", ", rightArray)}]";

Console.WriteLine(((myArray.Length == 0)? answerCannotBuildArray : answerNewArray));
