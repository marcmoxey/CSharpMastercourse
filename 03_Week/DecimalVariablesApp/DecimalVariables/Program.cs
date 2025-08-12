// 4.12, 32, 1.234

decimal bankAccountBalance; // more precise, doesn't round till after 28 position, used for money
bankAccountBalance = 2.34M;
Console.WriteLine(bankAccountBalance);