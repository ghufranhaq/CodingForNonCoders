using NUnit.Framework;

using L10.Payroll;

namespace L10.Tests
{

    public class WhenComputingOvertimeWages {

        [Test]
        public void Then41HoursAt10Rate_Returns415() {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal wages = calculator.ComputeWages(41, 10);
            Assert.AreEqual(415, wages);
        }

        [Test]
        public void Then80HoursAt10Rate_Returns1000() {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal wages = calculator.ComputeWages(80, 10);
            Assert.AreEqual(1000, wages);
        }

    }
    
}