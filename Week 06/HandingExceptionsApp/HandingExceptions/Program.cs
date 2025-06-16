// Exceptions bubble up 
// If don't catch in 'BadCall' whoever calls has opportunity next to catch it
// Allow to bubble to user interface code 
// then it can tell the user

try
{
    BallCall();

}
catch (Exception ex)
{
    Console.WriteLine("There was an exception thrown in our app");
    Console.WriteLine(ex.Message);
    
}
 static void BallCall()
{
    int[] ages = new int[] { 1, 3, 5 };

    for (int i = 0; i <= ages.Length; i++)
    {
        try
        {
            Console.WriteLine(ages[i]); // view details - message, innerException, StackTrace
        }
        catch (Exception ex)
        {
            Console.WriteLine("We had an error");
            Console.WriteLine(ex.Message);
            //throw; // keep going if the exception wasn't caught
            throw new Exception("There was an error handling our array", ex); // to preserve the stack track & line numbers
            //Console.WriteLine(ex); // if writing to log file
            

        }
    }
}

Console.ReadLine();