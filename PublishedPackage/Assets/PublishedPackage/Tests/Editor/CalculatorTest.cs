using NSubstitute;
using NUnit.Framework;

namespace CleverCrow.UnityPackageGitExample {
    public class CalculatorTest {
        [Test]
        public void It_should_add_numbers () {
            var calculator = new CalculatorInternal();

            calculator.Add(2);
            calculator.Add(2);
            
            Assert.AreEqual(4, calculator.Total);
        }

        [Test]
        public void It_should_add_two_calculators_together () {
            var calculatorA = new CalculatorInternal();
            calculatorA.Add(2);

            var calculatorB = Substitute.For<ICalculator>();
            calculatorB.Total.Returns(2);
            
            calculatorA.Add(calculatorB);
            
            Assert.AreEqual(4, calculatorA.Total);
        }
    }
}
