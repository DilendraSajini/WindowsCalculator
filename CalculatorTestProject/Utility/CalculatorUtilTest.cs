using NUnit.Framework;
using System.Data;
using WindowsCalculator;

namespace CalculatorTestProject.Utility
{
    [TestFixture]
    public class CalculatorUtilTest
    {
        [Test]
        public void testCalculatePercentageWithTwoOperands_whenGivenEmptyOperands_shouldReturnException()
        {
            Assert.Throws<InvalidExpressionException>(() => CalculatorUtil.calculatePercentageWithTwoOperands("", "", ""));
        }

        [Test]
        public void testCalculatePercentageWithTwoOperands_whenGivenInValidOperator_shouldReturnException()
        {
            Assert.Throws<InvalidExpressionException>(() => CalculatorUtil.calculatePercentageWithTwoOperands("1", "2", ""));
        }

        [TestCase("0", "1", "+", ExpectedResult = "0")]
        [TestCase("1", "2", "-", ExpectedResult = "0.02")]
        [TestCase("2", "3", "/", ExpectedResult = "0.03")]
        [TestCase("3", "4", "*", ExpectedResult = "0.04")]
        public string testCalculatePercentageWithTwoOperands_whenGivenValidOperator_shouldReturnValidPercentage(string operand1, string operand2, string op)
        {
            return CalculatorUtil.calculatePercentageWithTwoOperands(operand1, operand2, op);
        }

        [Test]
        public void testCalculateBasicOperationWithTwoOperands_whenGivenEmptyOperands_shouldReturnException()
        {
            Assert.Throws<InvalidExpressionException>(() => CalculatorUtil.calculateBasicOperationWithTwoOperands("", "", ""));
        }

        [Test]
        public void testCalculateBasicOperationWithTwoOperands_whenGivenInValidOperator_shouldReturnException()
        {
            Assert.Throws<InvalidExpressionException>(() => CalculatorUtil.calculateBasicOperationWithTwoOperands("1", "2", ""));
        }

        [TestCase("0", "1", "+", ExpectedResult = "1")]
        [TestCase("1", "2", "-", ExpectedResult = "-1")]
        [TestCase("2", "3", "/", ExpectedResult = "0.6666667")]
        [TestCase("3", "4", "*", ExpectedResult = "12")]
        [TestCase("2", "0", "/", ExpectedResult = "Cannot divide by zero")]
        public string testCalculateBasicOperationWithTwoOperand_whenGivenValidOperator_shouldReturnValidOutput(string operand1, string operand2, string op)
        {
            return CalculatorUtil.calculateBasicOperationWithTwoOperands(operand1, operand2, op);
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}