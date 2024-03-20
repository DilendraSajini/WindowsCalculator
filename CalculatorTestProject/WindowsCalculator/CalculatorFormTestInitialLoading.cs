using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorFormTestInitialLoading
    {
        [Test]
        public void testSingleNumberClick()
        {
            CalculatorForm form = new CalculatorForm();
            Assert.AreEqual(form.Output1, "0");
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}