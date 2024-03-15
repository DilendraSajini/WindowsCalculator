using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WindowsCalculator
{
    static class CalculatorUtil
    {
        public static string getBackSpacedLastCharacter(string value)
        {
            if (value.Length == 1)
            {
                return "0";
            }
            return value.Remove(value.Length - 1);
        }

        public static double getSquared(float value)
        {
            return Math.Pow(value, 2);
        }

        public static string getPercentage(string value1, string value2, string op)
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
                    Console.WriteLine("Error: Invalid operator. Please provide a valid operator (+, -, *, /).");
                    return "0";
            }

        }

        public static string calculateWithSecondOperand(string value1, string value2, string op)
        {
            float result = 0;
            if (!string.IsNullOrEmpty(value1) && !string.IsNullOrEmpty(value2) && !string.IsNullOrEmpty(op))
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
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            return "Cannot divide by zero";
                        }
                        result = operand1 / operand2;
                        return result.ToString();
                    default:
                        Console.WriteLine("Error: Invalid operator. Please provide a valid operator (+, -, *, /).");
                        return result.ToString();

                }
            }
            return result.ToString();
        }

        public static string getSigned(string value)
        {
            if (value != "0")
            {
                if (!string.IsNullOrEmpty(value))
                {
                    float operand1 = float.Parse(value);
                    float newOperand1 = operand1 * (-1);
                    return newOperand1.ToString();
                }
            }
            return value;
        }

        public static Boolean isNumpadInput(char ch)
        {
            if (!char.IsControl(ch) && !char.IsDigit(ch) &&
                 (ch != '.'))
            {
                return true;
            }
            return false;
        }

        public static Boolean isValidInput(char ch)
        {
            if (char.IsDigit(ch) || ch == '.')
            {
                return true;
            }
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
            {
                return true;
            }
            return false;
        }

        public static Boolean isValidOperand(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            int decimalCount = Enumerable.Count(value, (c => c == '.'));

            if (decimalCount > 2)
            {
                return false;
            }
            if (!double.TryParse(value, out _))
            {
                return false;
            }

            return true;
        }

    }
}
