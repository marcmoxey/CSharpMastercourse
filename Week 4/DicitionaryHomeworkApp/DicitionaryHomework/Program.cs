
Dictionary<string,string> employees = new Dictionary<string,string>();
string employeeName;
string employeeId;

do
{
    Console.Write("What is the employee ID(enter 'lookup' to search or 'no' to continue): ");
    employeeId = Console.ReadLine();
 
   
    
    if(employeeId.ToLower() != "lookup") 
    {
        Console.Write("What is the employee last name: ");
        employeeName = Console.ReadLine();
        employees.Add(employeeId,employeeName);
    }
    else if(employeeId.ToLower() == "lookup")
    {
        Console.Write("What is the employee ID your searching for: ");
        employeeId = Console.ReadLine();
        Console.WriteLine($"The employee with the ID of {employeeId} is {employees[employeeId]}");
        
    }
       
   
   
   

} while (employeeId.ToLower() != "lookup");