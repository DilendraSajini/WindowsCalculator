using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCalculator
{
    public static class StringUtil
    {
        public  const string ZERO_TEXT = "0";

        public const string EMPTY_STRING = "";
        public static bool isValidSring(string value)
        {
            return !string.IsNullOrEmpty(value);
         
        }
        public static int getDecimalCount(string value)
        {
            return Enumerable.Count(value, (c => c == '.'));
        }

        public static bool isValidDouble(string value)
        {
            if (!double.TryParse(value, out _))
            {
                return false;
            }
            return true;
        }

    }
}
