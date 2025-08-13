<<<<<<< HEAD
﻿namespace MethodOverridingDemo
{
    public class EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }

        // virtual allows this method to be overridden in derived classes
        public virtual decimal GetPaycheckAmount(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }
}
=======
﻿namespace MethodOverridingDemo
{
    public class EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }

        // virtual allows this method to be overridden in derived classes
        public virtual decimal GetPaycheckAmount(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
