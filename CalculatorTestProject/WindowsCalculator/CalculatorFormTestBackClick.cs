using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorFormTestBackClick
    {
        [TestCase("", ExpectedResult = "0")]
        public string testBackClickWithNOperand_shouldReturnEmptyOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.EraseLastLetterOfOperand();
            return form.Output1;
        }

        [TestCase("0", ExpectedResult = "0")]
        public string testBackClickWithZeroOperand_shouldNotUpdateOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            string outputBeforeApplyOperator = form.Output1;
            form.EraseLastLetterOfOperand();
            Assert.AreEqual(outputBeforeApplyOperator, form.Output1);
            return form.Output1;
        }

        [TestCase("1", ExpectedResult = "0")]
        [TestCase("12", ExpectedResult = "1")]
        public string testBackClickWithOperand_shouldUpdateOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            string outputBeforeApplyOperator = form.Output1;
            form.EraseLastLetterOfOperand();
            Assert.AreNotEqual(outputBeforeApplyOperator, form.Output1);
            return form.Output1;
        }

        [TestCase("12", ExpectedResult = "0")]
        public string testBackClickWithMultipleClicks_shouldUpdateOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            string outputBeforeApplyOperator = form.Output1;
            form.EraseLastLetterOfOperand();
            form.EraseLastLetterOfOperand();
            Assert.AreNotEqual(outputBeforeApplyOperator, form.Output1);
            return form.Output1;
        }


        [TestCase("0", "+", ExpectedResult = "0")]
        [TestCase("1", "-", ExpectedResult = "1")]
        [TestCase("2", "/", ExpectedResult = "2")]
        [TestCase("3", "*", ExpectedResult = "3")]
        public string testBackClickWithFirstOperandAndOperator_shouldNotChangeOutput1(string operand1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.OperationsClick(op);
            string outputBeforeApplyOperator = form.Output1;
            Assert.AreEqual(operand1, outputBeforeApplyOperator);
            form.EraseLastLetterOfOperand();
            Assert.AreEqual(outputBeforeApplyOperator, form.Output1);
            return form.Output1;
        }

        [TestCase("07", "+", ExpectedResult = "07")]
        [TestCase("13", "-", ExpectedResult = "13")]
        [TestCase("25", "/", ExpectedResult = "25")]
        [TestCase("36", "*", ExpectedResult = "36")]
        public string testBackClickWithFirstOperandAndOperatorMultipleCharacters_shouldNotChangeOutput1(string operand1, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.OperationsClick(op);
            string outputBeforeApplyOperator = form.Output1;
            Assert.AreEqual(operand1, outputBeforeApplyOperator);
            form.EraseLastLetterOfOperand();
            Assert.AreEqual(outputBeforeApplyOperator, form.Output1);
            return form.Output1;
        }

        [TestCase("07", ExpectedResult = "49")]
        [TestCase("13", ExpectedResult = "169")]
        [TestCase("25", ExpectedResult = "625")]
        [TestCase("36", ExpectedResult = "1296")]
        public string testBackClickWithFirstOperAndSquaredOperator_shouldNotChangeOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.setSquaredClicked();
            string outputBeforeApplyOperator = form.Output1;
            form.EraseLastLetterOfOperand();
            Assert.AreEqual(outputBeforeApplyOperator, form.Output1);
            return form.Output1;
        }

        [TestCase("07", ExpectedResult = "49")]
        [TestCase("13", ExpectedResult = "169")]
        [TestCase("25", ExpectedResult = "625")]
        [TestCase("36", ExpectedResult = "1296")]
        public string testBackClickWithFirstOperandAndSquareRootOperator_shouldNotChangeOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.setSquaredClicked();
            string outputBeforeApplyOperator = form.Output1;
            form.EraseLastLetterOfOperand();
            Assert.AreEqual(outputBeforeApplyOperator, form.Output1);
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
            form.OperandButonClick(operand1);
            form.OperationsClick(op);
            form.OperandButonClick(operand2);
            string outputBeforeApplyOperator = form.Output1;
            Assert.AreEqual(operand2, outputBeforeApplyOperator);
            form.EraseLastLetterOfOperand();
            Assert.AreNotEqual(outputBeforeApplyOperator, form.Output1);
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
            form.OperandButonClick(operand1);
            form.OperationsClick(op);
            form.OperandButonClick(operand2);
            string outputBeforeApplyOperator = form.Output1;
            Assert.AreEqual(operand2, outputBeforeApplyOperator);
            form.EraseLastLetterOfOperand();
            Assert.AreNotEqual(outputBeforeApplyOperator, form.Output1);
            return form.Output1;
        }

        [TestCase("0", "12", "+", ExpectedResult = "0")]
        [TestCase("1", "23", "-", ExpectedResult = "0")]
        [TestCase("2", "34", "/", ExpectedResult = "0")]
        [TestCase("3", "45", "*", ExpectedResult = "0")]
        [TestCase("4", "56", "+", ExpectedResult = "0")]
        public string testBackClickWithSecondOperandMultipleCharacters_shouldEraceMultipleLetterOfOutput1(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.OperationsClick(op);
            form.OperandButonClick(operand2);
            string outputBeforeApplyOperator = form.Output1;
            Assert.AreEqual(operand2, outputBeforeApplyOperator);
            form.EraseLastLetterOfOperand();
            form.EraseLastLetterOfOperand();
            Assert.AreNotEqual(outputBeforeApplyOperator, form.Output1);
            return form.Output1;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}