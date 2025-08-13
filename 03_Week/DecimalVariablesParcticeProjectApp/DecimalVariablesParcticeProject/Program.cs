
decimal bankAccountBalance = 1674.38M;
decimal carPayment = 487M;
decimal carInsurance = 512.94M;
decimal appleMusic = 10.99M;

decimal leftOverAmount = bankAccountBalance -  carPayment;
Console.WriteLine(leftOverAmount);
leftOverAmount = leftOverAmount - carInsurance;
Console.WriteLine(leftOverAmount);