/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();
Console.Write("Please enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
List<int> list_of_EVEN_number = new List<int>();
while (count < number)
{
if (number % 2 == 0)
{
    list_of_EVEN_number.Add(number);
}
number--;
}
list_of_EVEN_number.Reverse();
Console.WriteLine(String.Join(", ", list_of_EVEN_number));