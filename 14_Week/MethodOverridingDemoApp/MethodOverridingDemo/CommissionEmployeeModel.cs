<<<<<<< HEAD
﻿namespace MethodOverridingDemo
{
    public class CommissionEmployeeModel : EmployeeModel
    {
        public decimal CommissionAmount { get; set; }
        public override decimal GetPaycheckAmount(int hoursWorked)
        {
            // base - call method in the parent class
            decimal initialPlay = base.GetPaycheckAmount(hoursWorked);
            return initialPlay + CommissionAmount;
        }
    }
}
=======
﻿namespace MethodOverridingDemo
{
    public class CommissionEmployeeModel : EmployeeModel
    {
        public decimal CommissionAmount { get; set; }
        public override decimal GetPaycheckAmount(int hoursWorked)
        {
            // base - call method in the parent class
            decimal initialPlay = base.GetPaycheckAmount(hoursWorked);
            return initialPlay + CommissionAmount;
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
