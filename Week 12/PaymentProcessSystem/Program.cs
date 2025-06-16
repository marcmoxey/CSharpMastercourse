using System;
using System.Collections.Generic;

System.Console.WriteLine("Welcome to the Payment System!");
System.Console.WriteLine("Select a payment method:");
System.Console.WriteLine("1. Credit Card");
System.Console.WriteLine("2. PayPal");
System.Console.WriteLine("3. Bitcoin");
string choice = Console.ReadLine();
IPaymentProcessor paymentProcessor = null; 
switch (choice)
{
    case "1":
        paymentProcessor = new CreditCardPayment();
        break;
    case "2":
        paymentProcessor = new PayPalPayment();
        break;
    case "3":
        paymentProcessor = new BitcoinPayment();
        break;
    default:
        Console.WriteLine("Invalid choice.");
        return;
}
Console.WriteLine("Enter the amount to process:");
if(decimal.TryParse(Console.ReadLine(), out decimal amount))
{
    paymentProcessor.ProcessPayment(amount);

    System.Console.WriteLine("Do you want to refund the payment? (yes/no)");
    string refundChoice = Console.ReadLine()?.ToLower();
    if (refundChoice == "yes")
    {
        paymentProcessor.RefundPayment(amount);
    }
}
else
{
    Console.WriteLine("Invalid amount.");
}

System.Console.WriteLine("Thank you for using the Payment System!");
Console.ReadLine();


public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);

    void RefundPayment(decimal amount);
}

public class CreditCardPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount:C}");
    }

    public void RefundPayment(decimal amount)
    {
        Console.WriteLine($"Refunding credit card payment of {amount:C}");
    }
}

public class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount:C}");
    }

    public void RefundPayment(decimal amount)
    {
        Console.WriteLine($"Refunding PayPal payment of {amount:C}");
    }
}

public class BitcoinPayment : IPaymentProcessor {
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Bitcoin payment of {amount:C}");
    }

    public void RefundPayment(decimal amount)
    {
        Console.WriteLine($"Refunding Bitcoin payment of {amount:C}");
    }
}