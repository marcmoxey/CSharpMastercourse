using LinqAndLambdaHomework;


//LambdaTest();
LinqTest();
Console.ReadLine();

void LambdaTest()
{
    var data = SampleData.GetPersonData();

    //var results = data.OrderByDescending(x => x.FirstName);

    //foreach (var item in results)
    //{
    //    Console.WriteLine($"{item.FirstName}, {item.LastName}");
    //}

    var results = data.Skip(1).Take(2);
    foreach (var item in results)
    {
        Console.WriteLine($"{item.FirstName}, {item.LastName}");
    }
}
void LinqTest()
{
    var people = SampleData.GetPersonData();

    //var results = (from p in people
    //               select new { p.FirstName, p.LastName });

    //foreach (var item in results)
    //{
    //    Console.WriteLine($"{item.FirstName}, {item.LastName}");
    //}

    var results = (from p in people
                   where p.Id == 1
                   select new {p.FirstName, p.LastName});

    foreach (var item in results)
    {
        Console.WriteLine($"{item.FirstName}, {item.LastName}");
    }
}