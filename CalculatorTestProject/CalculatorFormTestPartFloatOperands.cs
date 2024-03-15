using NUnit.Framework;

namespace WindowsCalculator.UnitTests
{
    [TestFixture]
    public class CalculatorFormTestPartFloatOperands
    {
        [TestCase("0", ".", "5", "1", "+", ExpectedResult = "1.5")]
        public string testSingleFloatOperandsAndOperatorClick_shouldReturnValidOutput1(string operand1Part1,string opDot, string operand1Part2, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1Part1);
            form.operandButonClick(opDot);
            form.operandButonClick(operand1Part2);
            form.setOperationClick(op);
            form.operandButonClick(operand2);
            form.setEqualClicked("=");
            return form.Output1;
        }

        [TestCase("0", ".", "5", "1", "+", ExpectedResult = "0.5 + 1")]
        public string testSingleFloatOperandsAndOperatorClick_shouldReturnValidOutput2(string operand1Part1, string opDot, string operand1Part2, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1Part1);
            form.operandButonClick(opDot);
            form.operandButonClick(operand1Part2);
            form.setOperationClick(op);
            form.operandButonClick(operand2);
            form.setEqualClicked("=");
            return form.Output2;
        }

        [TestCase("0", ".", "5", "1", "+", ExpectedResult = "2")]
        public string testFloatOperandsAndOperatorClick_shouldReturnValidOutput1(string operand1Part1, string opDot, string operand1Part2, string operand2Part1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1Part1);
            form.operandButonClick(opDot);
            form.operandButonClick(operand1Part2);
            form.setOperationClick(op);
            form.operandButonClick(operand2Part1);
            form.operandButonClick(opDot);
            form.operandButonClick(operand1Part2);
            form.setEqualClicked("=");
            return form.Output1;
        }

        [TestCase("0", ".", "5", "1", "+", ExpectedResult = "0.5 + 1.5")]
        public string testFloatOperandsAndOperatorClick_shouldReturnValidOutput2(string operand1Part1, string opDot, string operand1Part2, string operand2Part1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1Part1);
            form.operandButonClick(opDot);
            form.operandButonClick(operand1Part2);
            form.setOperationClick(op);
            form.operandButonClick(operand2Part1);
            form.operandButonClick(opDot);
            form.operandButonClick(operand1Part2);
            form.setEqualClicked("=");
            return form.Output2;
        }

    [TearDown]
        public void TearDown()
        {
        }

    }
}