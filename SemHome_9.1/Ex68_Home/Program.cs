/*
Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}

Console.Write("Input m: ");
int m;
Int32.TryParse(Console.ReadLine(), out m);
Console.Write("Input n: ");
int n;
Int32.TryParse(Console.ReadLine(), out n);

if (m >= 0 && n >= 0)
{
    Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");
}
else Console.WriteLine($"Sorry you write wrong number");