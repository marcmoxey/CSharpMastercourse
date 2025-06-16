

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"The value of i is {i}");
//}

//string data = "Tim,Sue,Bob,Jane";
//List<string> firstName = data.Split(',').ToList();
//for (int i = 0; i < firstName.Count; i++)
//{
//    Console.WriteLine($"{firstName[i]} is in attendance");
//}

List<decimal> charges = new ();
charges.Add(23.78M);
charges.Add(10.99M);
charges.Add(15M);

decimal total = 0;
for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}
Console.WriteLine($"Our total charge is {total}");