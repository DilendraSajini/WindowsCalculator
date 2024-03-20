using NUnit.Framework;

namespace WindowsCalculator.UnitTests
{
    [TestFixture]
    public class CalculatorFormTestSquaredClick
    {
        [TestCase("0", ExpectedResult = "0")]
        [TestCase("1", ExpectedResult = "1")]
        [TestCase("2", ExpectedResult = "4")]
        [TestCase("3", ExpectedResult = "9")]
        [TestCase("4", ExpectedResult = "16")]
        public string testOperandClick_shouldReturnValidOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setSquaredClicked();
            return form.Output1;
        }

        [TestCase("0", ExpectedResult = "0")]
        [TestCase("1", ExpectedResult = "1")]
        [TestCase("2", ExpectedResult = "16")]
        [TestCase("3", ExpectedResult = "81")]
        [TestCase("4", ExpectedResult = "256")]
        public string testOperandAndMultipleOperatiorClick_shouldReturnValidOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setSquaredClicked();
            form.setSquaredClicked();
            return form.Output1;
        }


        [TearDown]
        public void TearDown()
        {
        }

    }
}