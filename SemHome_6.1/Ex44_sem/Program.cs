/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

void FibonacciArray(int someNumber)
{
    int lengthArray = 0;
    if (someNumber == 0 || someNumber == 1) lengthArray = 1;
    else lengthArray = someNumber;
    int[] myFibonacciArray = new int[lengthArray];
    for (int i = 0; i < lengthArray; i++)
    {
        if (i == 0)
        {
            if (someNumber == 1) myFibonacciArray[i] = 1;
            else myFibonacciArray[i] = 0;
        }
        else if (i == 1) myFibonacciArray[i] = 1;        
        else myFibonacciArray[i] = myFibonacciArray[i-1] + myFibonacciArray[i-2];
    }
    Console.WriteLine($"Если N = {((someNumber == 0 || someNumber == 1)? someNumber : lengthArray)} -> {String.Join(" ", myFibonacciArray)}");
}

Console.Clear();
FibonacciArray(0);
FibonacciArray(1);
FibonacciArray(2);
FibonacciArray(3);
FibonacciArray(5);
FibonacciArray(7);
