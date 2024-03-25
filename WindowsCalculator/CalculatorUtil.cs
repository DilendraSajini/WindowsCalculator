using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WindowsCalculator
{
    public static class CalculatorUtil
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CalculatorUtil));

        public static string calculatePercentageWithTwoOperands(string value1, string value2, string op)
        {
            if (StringUtil.isValidSring(value1) && StringUtil.isValidSring(value2))
            {
                float operand1 = float.Parse(value1);
                float operand2 = float.Parse(value2);
                switch (op)
                {
                    case "+":
                    case "-":
                        return ((operand2 * (operand1 / 100)).ToString());

                    case "*":
                    case "/":
                        return ((operand2 / 100).ToString());
                    default:
                        log.Error("Error: Invalid operator. Please provide a valid operator (+, -, *, /).");
                        throw new InvalidExpressionException();
                }
            }
            log.Error("Error: Invalid number format");
            throw new InvalidExpressionException();
        }

        public static string calculateBasicOperationWithTwoOperands(string value1, string value2, string op)
        {
            if (StringUtil.isValidSring(value1) && StringUtil.isValidSring(value2) && StringUtil.isValidSring(op))
            {

                float operand1 = float.Parse(value1);
                float operand2 = float.Parse(value2);

                switch (op)
                {
                    case "+":
                        return (operand1 + operand2).ToString();
                    case "-":
                        return (operand1 - operand2).ToString();
                    case "*":
                        return (operand1 * operand2).ToString();
                    case "/":
                        if (operand2 == 0)
                        {
                            log.Error("Error: Division by zero is not allowed.");
                            return "Cannot divide by zero";
                        }
                        return (operand1 / operand2).ToString();
                    default:
                        log.Error("Error: Invalid operator. Please provide a valid operator (+, -, *, /).");
                        throw new InvalidExpressionException();

                }
            }
            log.Error("Error: Invalid number format");
            throw new InvalidExpressionException();
        }

        public static string getSignedString(string value)
        {
            if (value != StringUtil.ZERO_TEXT)
            {
                if (StringUtil.isValidSring(value))
                {
                    float operand1 = float.Parse(value);
                    float newOperand1 = operand1 * (-1);
                    return newOperand1.ToString();
                }
            }
            return value;
        }

        public static bool isValidNumpadInput(char ch, string text)
        {
            if (char.IsDigit(ch) || ch == '.' || char.IsControl(ch))
            {
                string inputText = text + ch;

                if (StringUtil.isValidDouble(inputText) && StringUtil.getDecimalCount(inputText) <= 1)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isValidCharacterInput(char ch)
        {
            if (isValidCharacterOperand(ch))
            {
                return true;
            }
            if (isvalidCharacterOperator(ch))
            {
                return true;
            }
            return false;
        }

        public static bool isvalidCharacterOperator(char ch)
        {
            return ch == '+' || ch == '-' || ch == '*' || ch == '/';
        }

        public static bool isValidCharacterOperand(char ch)
        {
            return char.IsDigit(ch) || ch == '.';
        }

        public static bool isValidStringOperand(string value)
        {
            return StringUtil.isValidSring(value) && StringUtil.getDecimalCount(value) <= 2 && StringUtil.isValidDouble(value);
        }

        public static string removeLastCharacterFromString(string value)
        {
            if (value.Length == 1)
            {
                return StringUtil.ZERO_TEXT;
            }
            return value.Remove(value.Length - 1);
        }

        public static double calculateSquare(double value)
        {
            return Math.Pow(value, 2);
        }
    }
}