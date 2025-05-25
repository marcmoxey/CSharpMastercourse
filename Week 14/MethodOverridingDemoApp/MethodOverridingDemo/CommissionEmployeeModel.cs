namespace MethodOverridingDemo
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
