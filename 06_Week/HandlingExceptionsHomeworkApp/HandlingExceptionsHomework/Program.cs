
int[] ages = new int[] { 1, 3, 5, 8, 9 };

for (int i = 0; i <= ages.Length; i++)
{
	try
	{
		Console.WriteLine(ages[i]);
	}
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
		//throw;
	}
}