namespace SalaryCalculator
{
    public class CalculationRule
    {
        public double SalaryLimitBeforeDiscount { get; }
        public double DiscountBellowLimit { get; }
        public double DiscountAboveLimit { get; }

        public CalculationRule(double salaryLimitBeforeDiscount, double discountBellowLimit, double discountAboveLimit)
        {
            this.SalaryLimitBeforeDiscount = salaryLimitBeforeDiscount;
            this.DiscountBellowLimit = discountBellowLimit;
            this.DiscountAboveLimit = discountAboveLimit;
        }

        public double DiscountSalary(double salary)
        {
            var discount = salary < this.SalaryLimitBeforeDiscount ? this.DiscountBellowLimit : this.DiscountAboveLimit;
            return salary * discount;
        }
    }
}
