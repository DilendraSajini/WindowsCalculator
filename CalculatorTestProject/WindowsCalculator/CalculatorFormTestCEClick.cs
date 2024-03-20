using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorFormTestCEClick
    {

        [TestCase("3","4","5", ExpectedResult = "")]
        public string testCEClickWithMultipleOperands_shouldCleanOutput1(string operand1, string operand2, string operand3)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.operandButonClick(operand2);
            form.operandButonClick(operand3);
            form.resetCalculator();
            return form.Output1;
        }

        [TestCase("3", "*", ExpectedResult = "")]
        public string testCEClickWithOneOperandsAndOperatorClick_shouldCleanOutput1(string operand1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.resetCalculator();
            return form.Output1;
        }

        [TestCase("3","4", "*", ExpectedResult = "")]
        public string testCEClickWithTwoOperandsAndOperatorClick_shouldCleanOutput1(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.operandButonClick(operand2);
            form.resetCalculator();
            return form.Output1;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}