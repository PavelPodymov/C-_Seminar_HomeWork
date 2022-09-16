/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.WriteLine("Example_03");
	
List<string> days = new List<string>() { "Monday", "Tuesday", "Wednesday",
 "Thursday", "Friday", "Saturday", "Sunday" };

Console.Write("Pleas enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your day is: {days[number-1]}");
