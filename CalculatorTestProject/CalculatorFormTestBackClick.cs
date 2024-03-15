using NUnit.Framework;

namespace WindowsCalculator.UnitTests
{
    [TestFixture]
    public class CalculatorFormTestBackClick
    {
        [TestCase("", ExpectedResult = "")]

        public string testBackClickWithNOperand_shouldDoNothing(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.eraseLastLetterOperandAndOutPut1();
            return form.Output1;
        }

        [TestCase("0", "+", ExpectedResult = "0")]
        [TestCase("1", "-", ExpectedResult = "1")]
        [TestCase("2", "/", ExpectedResult = "2")]
        [TestCase("3", "*", ExpectedResult = "3")]
        public string testBackClickWithFirstOperand_shouldEraceLastLetterOfOutput1(string operand1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.eraseLastLetterOperandAndOutPut1();
            return form.Output1;
        }

       [TestCase("07", "+", ExpectedResult = "07")]
       [TestCase("13", "-", ExpectedResult = "13")]
       [TestCase("25", "/", ExpectedResult = "25")]
       [TestCase("36", "*", ExpectedResult = "36")]
        public string testBackClickWithFirstOperandMultipleCharacters_shouldEraceLastLetterOfOutput1(string operand1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.eraseLastLetterOperandAndOutPut1();
            return form.Output1;
        }

        [TestCase("0", "1", "+", ExpectedResult = "0")]
        [TestCase("1", "2", "-", ExpectedResult = "0")]
        [TestCase("2", "3", "/", ExpectedResult = "0")]
        [TestCase("3", "4", "*", ExpectedResult = "0")]
        [TestCase("4", "5", "+", ExpectedResult = "0")]
        public string testBackClickWithSecondOperand_shouldEraceLastLetterOfOutput1(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.operandButonClick(operand2);
            form.eraseLastLetterOperandAndOutPut1();
            return form.Output1;
        }

        [TestCase("0", "12", "+", ExpectedResult = "1")]
        [TestCase("1", "23", "-", ExpectedResult = "2")]
        [TestCase("2", "34", "/", ExpectedResult = "3")]
        [TestCase("3", "45", "*", ExpectedResult = "4")]
        [TestCase("4", "56", "+", ExpectedResult = "5")]
        public string testBackClickWithSecondOperandMultipleCharacters_shouldEraceLastLetterOfOutput1(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.operandButonClick(operand1);
            form.setOperationClick(op);
            form.operandButonClick(operand2);
            form.eraseLastLetterOperandAndOutPut1();
            return form.Output1;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}