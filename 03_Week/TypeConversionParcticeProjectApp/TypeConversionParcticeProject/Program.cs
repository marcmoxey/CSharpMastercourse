
Console.Write("How much money do you have in your bank account: ");
string bankBalanceText = Console.ReadLine();

bool isValidDecimal = decimal.TryParse(bankBalanceText, out decimal bankBalance);
Console.WriteLine($"The decimal is {isValidDecimal}. The amount in the bank account is {bankBalance}");
Console.ReadLine();
