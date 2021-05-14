using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    [AllureNUnit]
    public class CalculatorShould
    {
        private Calculator _cal;

        [SetUp]
        public void Setup()
        {
            _cal = new Calculator();
        }
        [Test]
        [Category("Addition")]
        [Description("Add 1 +1 = 2")]
        [AllureTag("NUnit", "AllureTag","addition")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Addition")]
        public void OnePlusOneEqualTwo()
        {
            Assert.AreEqual(2, _cal.Add(1, 1));
        }
        [Test]
        [Category("Addition")]
        [Description("Add 2 +2 = 4")]
        [AllureTag("NUnit", "AllureTag", "addition")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Addition")]
        public void TwoPlusTwoEqualFour()
        {
            Assert.AreEqual(4, _cal.Add(2, 2));
        }
        [Test]
        [Category("Addition")]
        [Description("Add 4 +1 = 5")]
        [AllureTag("NUnit", "AllureTag", "addition")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Addition")]
        public void FourPlusOneEqualFive()
        {
            Assert.AreEqual(5, _cal.Add(4, 1));
        }


        [Test]
        [Category("Subtraction")]
        [Description("Subtract 1 -1 = 0")]
        [AllureTag("NUnit", "AllureTag", "Subtract")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Subtract")]
        public void OneSubtractOneEqualTwo()
        {
            Assert.AreEqual(0, _cal.Subtract(1, 1));
        }
        [Test]
        [Category("Subtraction")]
        [Description("Subtract 2 -2 = 0")]
        [AllureTag("NUnit", "AllureTag", "Subtract")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Subtract")]
        public void TwoSubtractTwoEqualFour()
        {
            Assert.AreEqual(0, _cal.Subtract(2, 2));
        }
        [Test]
        [Category("Subtraction")]
        [Description("Subtract 4 -1 = 3")]
        [AllureTag("NUnit", "AllureTag", "Subtract")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Subtract")]
        public void FourSubtractOneEqualFive()
        {
            Assert.AreEqual(3, _cal.Subtract(4, 1));
        }
    }
}
