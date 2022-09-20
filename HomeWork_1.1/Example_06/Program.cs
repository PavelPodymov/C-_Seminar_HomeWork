/*
Задача 4: Напишите программу, которая принимает на вход три 
числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();
Console.WriteLine("Example_06");
Console.Write("Pleas enter numbers: ");
string numbers = Console.ReadLine();

string[] words = numbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

List<int> list_of_numbers = new List<int>();

foreach (string num in words)
{
    int number = int.Parse(num);
    // Console.WriteLine($"{number}");
    list_of_numbers.Add(number);
}

// Console.WriteLine(String.Join(", ", list_of_numbers));
int max = list_of_numbers[0];
foreach (int num in list_of_numbers)
{
    if (max < num)
    {
        max = num;
    }
}

Console.WriteLine($"Maximum number is: {max}");
