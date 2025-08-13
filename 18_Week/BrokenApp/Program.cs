<<<<<<< HEAD
﻿using BrokenLibrary;
using System.Runtime.CompilerServices;

CompanyCreator company = new();
int totalEmployees = 0;
double totalDaysOff = 0;




List<CompanyModel> companies = company.CreateCompanyList();

foreach (var c in companies)
{
    
    Console.WriteLine($"Company: { c.CompanyName }, Employees: { c.NumberOfEmployees }, Days Off: { c.NumberOfDaysOffTotal}, Average: {   c.AverageDaysOff() }");
    totalEmployees += c.NumberOfEmployees;
    totalDaysOff += c.NumberOfDaysOffTotal;
}

Console.WriteLine();

Console.WriteLine($"The total number of employees is { totalEmployees }");
Console.WriteLine($"The total number of days off is { totalDaysOff }");

Console.ReadLine();
=======
﻿using BrokenLibrary;
using System.Runtime.CompilerServices;

CompanyCreator company = new();
int totalEmployees = 0;
int totalDaysOff = 0;




List<CompanyModel> companies = company.CreateCompanyList();

foreach (var c in companies)
{
    
    Console.WriteLine($"Company: { c.CompanyName }, Employees: { c.NumberOfEmployees }, Days Off: { c.NumberOfDaysOffTotal}, Average: {   c.AverageDaysOff() }");
    totalEmployees += c.NumberOfEmployees;
    totalDaysOff += c.NumberOfDaysOffTotal;
}

Console.WriteLine();

Console.WriteLine($"The total number of employees is { totalEmployees }");
Console.WriteLine($"The total number of days off is { totalDaysOff }");



Console.ReadLine();
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
