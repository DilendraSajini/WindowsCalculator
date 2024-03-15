using NUnit.Framework;

namespace WindowsCalculator.UnitTests
{
    [TestFixture]
    public class CalculatorFormTestPercentageClick
    {
        [TestCase("0", ExpectedResult = "0")]
        [TestCase("1", ExpectedResult = "0")]
        [TestCase("2", ExpectedResult = "0")]
        [TestCase("3", ExpectedResult = "0")]
        [TestCase("4", ExpectedResult = "0")]
        public string testSingleOperandClick_shouldReturnValidOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setPerClicked();
            return form.Output1;
        }

        [TestCase("0", "+", ExpectedResult = "0")]
        [TestCase("1", "-", ExpectedResult = "0.01")]
        [TestCase("2", "/", ExpectedResult = "0.02")]
        [TestCase("3", "*", ExpectedResult = "0.03")]
        public string testOneOperandsAndOperatorClick_shouldReturnValidOutput1(string operand1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.setPerClicked();
            return form.Output1;
        }


        [TestCase("0", "1", "+", ExpectedResult = "0")]
        [TestCase("1", "2", "-", ExpectedResult = "0.02")]
        [TestCase("2", "3", "/", ExpectedResult = "0.03")]
        [TestCase("3", "4", "*", ExpectedResult = "0.04")]
        public string testTwoOperandsAndOperatorClick_shouldReturnValidOutput1(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.operandButonClick(operand2);
            form.setPerClicked();
            return form.Output1;
        }

        [TestCase("0", "1", "+", ExpectedResult = "0 + 0")]
        [TestCase("1", "2", "-", ExpectedResult = "1 - 0.02")]
        [TestCase("2", "3", "/", ExpectedResult = "2 / 0.03")]
        [TestCase("3", "4", "*", ExpectedResult = "3 * 0.04")]
        public string testTwoOperandsAndOperatorClick_shouldReturnValidOutput2(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.operandButonClick(operand2);
            form.setPerClicked();
            return form.Output2;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}