﻿using NUnit.Framework;
using WindowsCalculator;

namespace CalculatorTestProject.WindowsCalculator
{
    [TestFixture]
    public class CalculatorFormTestReciprocalClick
    {
        [TestCase("0", ExpectedResult = "Cannot divide by zero")]
        // [TestCase("1", ExpectedResult = "1")]
        // [TestCase("2", ExpectedResult = "0.5")]
        // [TestCase("3", ExpectedResult = "0.3333333333333333")]
        // [TestCase("4", ExpectedResult = "0.25")]
        public string testOperandClick_shouldReturnValidOutput1(string operand1)
        {
            CalculatorForm form = new CalculatorForm();
            form.OperandButonClick(operand1);
            form.ReciprocalButtonClicked();
            return form.Output1;
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}