// int five = 5;
// Console.WriteLine((five == 5).ToString().ToLower());
// Console.WriteLine((five == 5).ToString());

// string answer = five == 5 ? "true"  :  "false";
// Console.WriteLine(answer);
// string answer2 = five == 5 ? "ой"  :  "ай";
// Console.WriteLine(answer2);
// string answer3 = five == 4 ? "ой"  :  "ай";
// Console.WriteLine(answer3);


List<int> termsList = new List<int>();
for (int i = 0; i < 400; i++)
{
    termsList.Add(i);
}

int[] terms = termsList.ToArray();
System.Console.WriteLine(String.Join(", ", termsList));