namespace SalaryCalculator
{
    public class Calculator
    {
        public static double CalculateSalary(Employee employee)
        {
            var notDiscountedPercentage = employee.Salary >= 1500 ? 0.8 : 0.9;
            return employee.Salary * notDiscountedPercentage;
        }
    }
}
