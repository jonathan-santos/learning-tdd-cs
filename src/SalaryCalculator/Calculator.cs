using System.Collections.Generic;

namespace SalaryCalculator
{
    public class Calculator
    {
        static Dictionary<Position, CalculationRule> _rules = new()
        {
            [Position.Developer] = new CalculationRule(1500.00, 0.9, 0.8),
            [Position.DBA] = new CalculationRule(1500.00, 0.85, 0.75)
        };

        public static double CalculateSalary(Employee employee)
        {
            return _rules[employee.Position].DiscountSalary(employee.Salary);
        }
    }
}
