using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorFormTestNumberClick
    {
        [TestCase("0", ExpectedResult = "0")]
        [TestCase("1", ExpectedResult = "1")]
        [TestCase("2", ExpectedResult = "2")]
        [TestCase("3", ExpectedResult = "3")]
        [TestCase("4", ExpectedResult = "4")]
        [TestCase("5", ExpectedResult = "5")]
        [TestCase("6", ExpectedResult = "6")]
        [TestCase("7", ExpectedResult = "7")]
        [TestCase("8", ExpectedResult = "8")]
        [TestCase("9", ExpectedResult = "9")]
        public string testSingleNumberClick(string operand)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand);
            return form.Output1;
        }

        [TestCase("0", ExpectedResult = "0")]
        [TestCase("1", ExpectedResult = "-1")]
        [TestCase("2", ExpectedResult = "-2")]
        [TestCase("3", ExpectedResult = "-3")]
        [TestCase("4", ExpectedResult = "-4")]
        [TestCase("5", ExpectedResult = "-5")]
        [TestCase("6", ExpectedResult = "-6")]
        [TestCase("7", ExpectedResult = "-7")]
        [TestCase("8", ExpectedResult = "-8")]
        [TestCase("9", ExpectedResult = "-9")]
        public string testSingleNumberWithSignClick(string operand)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand);
            form.SignButtonClicked("-");
            return form.Output1;
        }

        [TestCase("0", ExpectedResult = "0")]
        [TestCase("1", ExpectedResult = "1")]
        [TestCase("2", ExpectedResult = "2")]
        [TestCase("3", ExpectedResult = "3")]
        [TestCase("4", ExpectedResult = "4")]
        [TestCase("5", ExpectedResult = "5")]
        [TestCase("6", ExpectedResult = "6")]
        [TestCase("7", ExpectedResult = "7")]
        [TestCase("8", ExpectedResult = "8")]
        [TestCase("9", ExpectedResult = "9")]
        public string testSingleNumberWithDoubleSignClick(string operand)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand);
            form.SignButtonClicked("-");
            form.SignButtonClicked("-");
            return form.Output1;
        }

        [TestCase("0", "1", ExpectedResult = "01")]
        [TestCase("1", "2", ExpectedResult = "12")]
        [TestCase("2", "3", ExpectedResult = "23")]
        [TestCase("3", "4", ExpectedResult = "34")]
        [TestCase("4", "5", ExpectedResult = "45")]
        [TestCase("5", "6", ExpectedResult = "56")]
        [TestCase("6", "7", ExpectedResult = "67")]
        [TestCase("7", "8", ExpectedResult = "78")]
        [TestCase("8", "9", ExpectedResult = "89")]
        [TestCase("9", "0", ExpectedResult = "90")]
        public string testMultipleNumbersClick(string operand1, string operand2)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.OperandButonClick(operand2);
            return form.Output1;
        }

        [TestCase("1", ".", ".", ExpectedResult = "1.")]
        [TestCase("1", ".", "$", ExpectedResult = "1.")]
        public string testInvalidInPut(string operand1, string operand2, string operand3)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.OperandButonClick(operand2);
            form.OperandButonClick(operand3);
            return form.Output1;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}