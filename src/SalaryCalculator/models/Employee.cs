namespace SalaryCalculator
{
    public enum Position
    {
        Developer,
        DBA,
        Tester
    }

    public class Employee
    {
        public string Name { get; }
        public double Salary { get; }
        public Position Position { get; }

        public Employee(string name, double salary, Position position)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
        }
    }
}
