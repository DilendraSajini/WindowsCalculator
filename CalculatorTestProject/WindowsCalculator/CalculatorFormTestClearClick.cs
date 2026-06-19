using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorFormTestClearClick
    {

        [TestCase("0", "1", "+", ExpectedResult = "")]
        [TestCase("1", "2", "-", ExpectedResult = "")]
        [TestCase("2", "3", "/", ExpectedResult = "")]
        [TestCase("3", "4", "*", ExpectedResult = "")]
        [TestCase("4", "5", "+", ExpectedResult = "")]
        public string testClearClick_shouldCleanOutput1(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.OperationsClick(op);
            form.OperandButonClick(operand2);
            form.EqualButtonClicked("=");
            form.ResetCalculator();
            return form.Output1;
        }


        [TestCase("0", "1", "+", ExpectedResult = "")]
        [TestCase("1", "2", "-", ExpectedResult = "")]
        [TestCase("2", "3", "/", ExpectedResult = "")]
        [TestCase("3", "4", "*", ExpectedResult = "")]
        [TestCase("4", "5", "+", ExpectedResult = "")]
        public string testClearClick_shouldCleanOutput2(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.OperationsClick(op);
            form.OperandButonClick(operand2);
            form.EqualButtonClicked("=");
            form.ResetCalculator();
            return form.Output2;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}