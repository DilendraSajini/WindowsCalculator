using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorUtilTest
    {

        [TestCase("3", "*", ExpectedResult = "0.03")]
        public string testOneOperandsAndOperatorClick_shouldReturnValidOutput1(string operand1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.setPercentageClicked();
            return form.Output1;
        }
        [TearDown]
        public void TearDown()
        {
        }

    }
}