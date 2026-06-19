using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorFormTestPartFloatOperands
    {
        [TestCase("0", ".", "5", "1", "+", ExpectedResult = "1.5")]
        public string testSingleFloatOperandsAndOperatorClick_shouldReturnValidOutput1(string operand1Part1, string opDot, string operand1Part2, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1Part1);
            form.OperandButonClick(opDot);
            form.OperandButonClick(operand1Part2);
            form.OperationsClick(op);
            form.OperandButonClick(operand2);
            form.EqualButtonClicked("=");
            return form.Output1;
        }

        [TestCase("0", ".", "5", "1", "+", ExpectedResult = "0.5 + 1")]
        public string testSingleFloatOperandsAndOperatorClick_shouldReturnValidOutput2(string operand1Part1, string opDot, string operand1Part2, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1Part1);
            form.OperandButonClick(opDot);
            form.OperandButonClick(operand1Part2);
            form.OperationsClick(op);
            form.OperandButonClick(operand2);
            form.EqualButtonClicked("=");
            return form.Output2;
        }

        [TestCase("0", ".", "5", "1", "+", ExpectedResult = "2")]
        public string testFloatOperandsAndOperatorClick_shouldReturnValidOutput1(string operand1Part1, string opDot, string operand1Part2, string operand2Part1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1Part1);
            form.OperandButonClick(opDot);
            form.OperandButonClick(operand1Part2);
            form.OperationsClick(op);
            form.OperandButonClick(operand2Part1);
            form.OperandButonClick(opDot);
            form.OperandButonClick(operand1Part2);
            form.EqualButtonClicked("=");
            return form.Output1;
        }

        [TestCase("0", ".", "5", "1", "+", ExpectedResult = "0.5 + 1.5")]
        public string testFloatOperandsAndOperatorClick_shouldReturnValidOutput2(string operand1Part1, string opDot, string operand1Part2, string operand2Part1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1Part1);
            form.OperandButonClick(opDot);
            form.OperandButonClick(operand1Part2);
            form.OperationsClick(op);
            form.OperandButonClick(operand2Part1);
            form.OperandButonClick(opDot);
            form.OperandButonClick(operand1Part2);
            form.EqualButtonClicked("=");
            return form.Output2;
        }

        [TestCase("0", ".", "5", "1", "+", ExpectedResult = "2")]
        public string testDuplicateFloatOperandsAndOperatorClick_shouldReturnValidOutput1(string operand1Part1, string opDot, string operand1Part2, string operand2Part1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1Part1);
            form.OperandButonClick(opDot);
            form.OperandButonClick(opDot);
            form.OperandButonClick(operand1Part2);
            form.OperationsClick(op);
            form.OperandButonClick(operand2Part1);
            form.OperandButonClick(opDot);
            form.OperandButonClick(operand1Part2);
            form.EqualButtonClicked("=");
            return form.Output1;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}