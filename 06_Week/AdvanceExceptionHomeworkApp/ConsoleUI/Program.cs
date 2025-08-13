
try
{
    SomeMethod();
}
catch(FileLoadException ex)
{
    Console.WriteLine("This file does not exist");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{

    Console.WriteLine($"An error how occurred: {ex.Message}");
}

void SomeMethod()
{
    throw new FileLoadException("Can't load this file");
}