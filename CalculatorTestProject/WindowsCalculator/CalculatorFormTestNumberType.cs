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

        [TestCase("0", "1", "+", ExpectedResult = "1")]
        [TestCase("1", "2", "-", ExpectedResult = "-1")]
        [TestCase("2", "3", "/", ExpectedResult = "0.6666667")]
        [TestCase("3", "4", "*", ExpectedResult = "12")]
        public string testTwoOperandsOperatorAndEnterKey_shouldReturnValidOutput1(char operand1, char operand2, char op)
        {

            CalculatorForm form = new CalculatorForm();
            form.KeyPressInputHandler(operand1);
            form.KeyPressInputHandler(op);
            form.KeyPressInputHandler(operand2);
            form.KeyPressInputHandler('\r');
            return form.Output1;
        }


        [TestCase("3", "4", "+", ExpectedResult = "7")]
        public string testResetOutputWithOperator_shouldNotResetOutput1(string operand1, string operand2, char op)
        {

            CalculatorForm form = new CalculatorForm();
            form.Output1 = operand1;
            form.KeyPressInputHandler(operand1[0]);
            form.KeyPressInputHandler(op);
            form.KeyPressInputHandler(operand2[0]);
            form.Output1 = operand2; // Because the  form.KeyPressInputHandler(operand2[0]) is reset before set the value.
            form.KeyPressInputHandler(op);
            return form.Output1;
        }

        [TestCase("3", "4", "4", "*", ExpectedResult = "48")]
        public string testThreeOperandsOperatorAndEnterKey_shouldReturnValidOutput1(char operand1, char operand2, char operand3, char op)
        {

            CalculatorForm form = new CalculatorForm();
            form.KeyPressInputHandler(operand1);
            form.KeyPressInputHandler(op);
            form.KeyPressInputHandler(operand2);
            form.KeyPressInputHandler('\r');
            form.KeyPressInputHandler(operand3);
            form.KeyPressInputHandler('\r');
            return form.Output1;
        }

        [TestCase("3", "4", "4", "*", ExpectedResult = "48")]
        public string testThreeOperandsOperatorAndEqual_shouldReturnValidOutput1(char operand1, char operand2, char operand3, char op)
        {

            CalculatorForm form = new CalculatorForm();
            form.KeyPressInputHandler(operand1);
            form.KeyPressInputHandler(op);
            form.KeyPressInputHandler(operand2);
            form.KeyPressInputHandler('=');
            form.KeyPressInputHandler(operand3);
            form.KeyPressInputHandler('=');
            return form.Output1;
        }

        [TestCase("0", "1", "4", "+", ExpectedResult = "5")]
        [TestCase("1", "2", "4", "-", ExpectedResult = "-5")]
        [TestCase("2", "3", "4", "/", ExpectedResult = "0.16666667")]
        [TestCase("3", "4", "4", "*", ExpectedResult = "48")]
        public string testThreeOperandsTwoOperatorAndEnterKey_shouldReturnValidOutput1(char operand1, char operand2, char operand3, char op)
        {

            CalculatorForm form = new CalculatorForm();
            form.KeyPressInputHandler(operand1);
            form.KeyPressInputHandler(op);
            form.KeyPressInputHandler(operand2);
            form.KeyPressInputHandler(op);
            form.KeyPressInputHandler(operand3);
            form.KeyPressInputHandler('\r');
            return form.Output1;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}