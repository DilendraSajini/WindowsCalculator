using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorFormTestNumberType
    {
        [TestCase("0", "1", "+", ExpectedResult = "0 + ")]
        [TestCase("1", "2", "-", ExpectedResult = "1 - ")]
        [TestCase("2", "3", "/", ExpectedResult = "2 / ")]
        [TestCase("3", "4", "*", ExpectedResult = "3 * ")]
        [TestCase("4", "5", "+", ExpectedResult = "4 + ")]
        public string testTwoOperandsAndOperatorType_shouldReturnValidOutput2(char operand1, char operand2, char op)
        {

            CalculatorForm form = new CalculatorForm();
            form.KeyPressInputHandler(operand1);
            form.KeyPressInputHandler(op);
            form.KeyPressInputHandler(operand2);
            return form.Output2;
        }

        [TestCase("0", "1", "+", ExpectedResult = "1")]
        [TestCase("1", "2", "-", ExpectedResult = "-1")]
        [TestCase("2", "3", "/", ExpectedResult = "0.6666667")]
        [TestCase("3", "4", "*", ExpectedResult = "12")]
        public string testTwoOperandsOperatorAndEqualType_shouldReturnValidOutput1(char operand1, char operand2, char op)
        {

            CalculatorForm form = new CalculatorForm();
            form.KeyPressInputHandler(operand1);
            form.KeyPressInputHandler(op);
            form.KeyPressInputHandler(operand2);
            form.KeyPressInputHandler('=');
            return form.Output1;
        }

        [TestCase("0", "1", "+", ExpectedResult = "0 + 1")]
        [TestCase("1", "2", "-", ExpectedResult = "1 - 2")]
        [TestCase("2", "3", "/", ExpectedResult = "2 / 3")]
        [TestCase("3", "4", "*", ExpectedResult = "3 * 4")]
        public string testTwoOperandsOperatorAndEqualType_shouldReturnValidOutput2(char operand1, char operand2, char op)
        {

            CalculatorForm form = new CalculatorForm();
            form.KeyPressInputHandler(operand1);
            form.KeyPressInputHandler(op);
            form.KeyPressInputHandler(operand2);
            form.KeyPressInputHandler('=');
            return form.Output2;
        }



        [TearDown]
        public void TearDown()
        {
        }

    }
}