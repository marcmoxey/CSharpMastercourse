
using System.Net.Http.Headers;

List<string> firstNames = new List<string>();
firstNames.Add("Marc");
firstNames.Add("Jon");
firstNames.Add("Nio");

for(int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine(firstNames[i]);
}


for(int i = 0; i < 100; i+=2)
{
    Console.WriteLine(i);
}