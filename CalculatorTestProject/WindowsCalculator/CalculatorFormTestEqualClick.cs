﻿using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorFormTestEqualClick
    {

        [TestCase("1", ExpectedResult = "1")]
        public string testOneOperandAndEqualClick_shouldReturnValidOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.EqualButtonClicked("=");
            return form.Output1;
        }

        [TestCase("1", ExpectedResult = "1 =")]
        public string testOneOperandAndEqualClick_shouldReturnValidOutput2(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.EqualButtonClicked("=");
            return form.Output2;
        }

        [TestCase("0", "1", "+", ExpectedResult = "1")]
        [TestCase("1", "2", "-", ExpectedResult = "-1")]
        [TestCase("2", "3", "/", ExpectedResult = "0.6666667")]
        [TestCase("3", "4", "*", ExpectedResult = "12")]
        [TestCase("2", "0", "/", ExpectedResult = "Cannot divide by zero")]
        public string testTwoOperandsAndOperatorEqualClick_shouldReturnValidOutput1(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.OperationsClick(op);
            form.OperandButonClick(operand2);
            form.EqualButtonClicked("=");
            return form.Output1;
        }

        [TestCase("0", "1", "+", ExpectedResult = "0 + 1")]
        [TestCase("1", "2", "-", ExpectedResult = "1 - 2")]
        [TestCase("2", "3", "/", ExpectedResult = "2 / 3")]
        [TestCase("3", "4", "*", ExpectedResult = "3 * 4")]
        [TestCase("4", "5", "+", ExpectedResult = "4 + 5")]
        public string testTwoOperandsAndOperatorEqualClick_shouldReturnValidOutput2(string operand1, string operand2, string op)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.OperationsClick(op);
            form.OperandButonClick(operand2);
            form.EqualButtonClicked("=");
            return form.Output2;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}