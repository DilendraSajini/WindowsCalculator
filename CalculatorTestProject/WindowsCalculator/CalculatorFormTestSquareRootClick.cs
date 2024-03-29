﻿using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorFormTestSquareRootClick
    {

        [TestCase("0", ExpectedResult = "0")]
        [TestCase("1", ExpectedResult = "1")]
        [TestCase("2", ExpectedResult = "1.4142135623730951")]
        [TestCase("3", ExpectedResult = "1.7320508075688772")]
        [TestCase("4", ExpectedResult = "2")]
        public string testOperandClick_shouldReturnValidOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.SquareRootButtonClicked();
            return form.Output1;
        }

        [TestCase("0", ExpectedResult = "0")]
        [TestCase("1", ExpectedResult = "1")]
        [TestCase("625", ExpectedResult = "5")]
        [TestCase("6561", ExpectedResult = "9")]
        [TestCase("16", ExpectedResult = "2")]
        public string testOperandAndMultipleOperatorClick_shouldReturnValidOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.SquareRootButtonClicked();
            form.SquareRootButtonClicked();
            return form.Output1;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}