using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsCalculator
{
    static class CalculatorUtil
    {
        public static string eraseLastCharacter(string value)
        {
            string returnValue = value;
            if (value.Length == 0)
            {
                return returnValue;
            }
            else if (value.Length == 1)
            {
                returnValue = "0";
            }
            else
            {
                returnValue = value.Remove(value.Length - 1);
            }
                return returnValue;
        }
    }
}
