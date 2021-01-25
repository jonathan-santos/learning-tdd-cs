using NUnit.Framework;

namespace SalaryCalculator
{
    public class TestSalaryCalculator
    {
        [Test]
        public void MustCalculateSalaryForDevelopersWithSalaryBellowLimit()
        {
            var employee = new Employee("Manolo", 1400, Position.Developer);
            var salary = Calculator.CalculateSalary(employee);
            Assert.AreEqual(1400 * 0.9, salary, 0.00001);
        }

        [Test]
        public void MustCalculateSalaryForDevelopersWithSalarAboveLimit()
        {
            var employee = new Employee("Manolo", 2000, Position.Developer);
            var salary = Calculator.CalculateSalary(employee);
            Assert.AreEqual(2000 * 0.8, salary, 0.00001);
        }
    }
}
