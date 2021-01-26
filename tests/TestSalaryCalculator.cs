using NUnit.Framework;

namespace SalaryCalculator
{
    public class TestSalaryCalculator
    {
        [Test]
        public void MustCalculateSalaryForDevelopersWithSalaryBellowLimit()
        {
            const double salary = 1400;

            var employee = new Employee("Manolo", salary, Position.Developer);
            var calculatedSalary = Calculator.CalculateSalary(employee);
            
            Assert.AreEqual(salary * 0.9, calculatedSalary, 0.00001);
        }

        [Test]
        public void MustCalculateSalaryForDevelopersWithSalarAboveLimit()
        {
            const double salary = 2000;

            var employee = new Employee("Manolo", salary, Position.Developer);
            var calculatedSalary = Calculator.CalculateSalary(employee);

            Assert.AreEqual(salary * 0.8, calculatedSalary, 0.00001);
        }
    }
}
