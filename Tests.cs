using NUnit.Framework;

namespace SalaryCalculator
{
    [TestFixture]
    public class Tests
    {
        Calculator calculator;
        double[] salary, tax_rate, ndfl_sum;

        [SetUp]
        public void SetUp() 
        {
            calculator = new Calculator();

            salary = new double[] { 10000, 12000, 14000, 16000 };
            tax_rate = new double[] { 0.1, 0.2, 0.3, 0.4 };
            ndfl_sum = new double[] { 1000, 2400, 4200, 6400 };
        }

        [Test]
        public void Test()
        {
            for (int i = 0; i < salary.Length; i++)
            {
                Assert.AreEqual(ndfl_sum[i], calculator.salary_calculation(salary[i], tax_rate[i]));
            }
        }
    }
}
