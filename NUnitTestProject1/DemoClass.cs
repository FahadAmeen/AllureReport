using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    [AllureNUnit]
    public class DemoClass
    {
        [Test]
        [Category("Category: LongTerm")]
        [Description("Description: test")]
        [AllureTag("NUnit", "AllureTag")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("AllureFeature: Core")]
        public void AllureTest()
        {
            Assert.AreEqual(4, 4);
        }
        [Test(Description = "Verify assert")]
        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureIssue("555")]
        [AllureTms("66")]
        [AllureOwner("Fahd")]
        [AllureSubSuite("Automation")]
        public void AllureTest2()
        {
            Assert.AreEqual(4, 4);
        }
    }
}