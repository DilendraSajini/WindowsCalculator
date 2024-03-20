using NUnit.Framework;

namespace WindowsCalculator.UnitTests
{
    [TestFixture]
    public class CalculatorFormTestOperatorClick
    {
       
        [TestCase("0", "1", "+", ExpectedResult = "1")]
        [TestCase("1", "2", "-", ExpectedResult = "2")]
        [TestCase("2", "3", "/", ExpectedResult = "3")]
        [TestCase("2", "0", "/", ExpectedResult = "0")]
        [TestCase("3", "4", "*", ExpectedResult = "4")]
        [TestCase("4", "5", "+", ExpectedResult = "5")]
        public string testTwoOperandsAndOperatorClick_shouldReturnValidOutput1(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.operandButonClick(operand2);
            return form.Output1;
        }

        [TestCase("0", "1", "+", ExpectedResult = "0 + ")]
        [TestCase("1", "2", "-", ExpectedResult = "1 - ")]
        [TestCase("2", "3", "/", ExpectedResult = "2 / ")]
        [TestCase("3", "4", "*", ExpectedResult = "3 * ")]
        [TestCase("4", "5", "+", ExpectedResult = "4 + ")]
        public string testTwoOperandsAndOperatorClick_shouldReturnValidOutput2(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.operandButonClick(operand2);
            return form.Output2;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}