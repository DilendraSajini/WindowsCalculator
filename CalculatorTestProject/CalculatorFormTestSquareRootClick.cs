using NUnit.Framework;

namespace WindowsCalculator.UnitTests
{
    [TestFixture]
    public class CalculatorFormTestSquareRootClick
    {

        [TestCase("0", ExpectedResult = "0")]
        [TestCase("1", ExpectedResult = "1")]
        [TestCase("2", ExpectedResult = "1.4142135623730951")]
        [TestCase("3", ExpectedResult = "1.7320508075688772")]
        [TestCase("4", ExpectedResult = "2")]
        public string testOperandClick_shouldReturnValidOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setSquareRootClicked();
            return form.Output1;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}