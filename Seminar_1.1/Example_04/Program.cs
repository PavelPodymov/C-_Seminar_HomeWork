/*
5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

Console.WriteLine("Example_04");

Console.Write("Pleas enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
List<int> numbers = new List<int>();

int count = -number;

while (count <= number)
{
    // Console.Write($"{count}, ");
    numbers.Add(count);  
    count++;
}

Console.WriteLine(String.Join(", ", numbers));

