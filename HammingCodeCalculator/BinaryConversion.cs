using System;

namespace HammingCodeCalculator
{
    static class BinaryConversion
    {

        internal static string ToBinaryConversion(int decimal_value)
        {
            int remainder;
            string result = string.Empty;
            while (decimal_value > 0)
            {
                remainder = decimal_value % 2;
                decimal_value /= 2;
                result = remainder.ToString() + result;
            }
            if(result.Length < 7)
            {
                var count = 7 - result.Length;
                string tmp = string.Empty;
                for (int i = 1; i <= count; i++)
                {
                    var zero = "0";
                    tmp += zero;
                }
                result = tmp + result;
            }
            return result;
        }

        internal static string ToDecimalConversion(string binary_value)
        {
            var result = Convert.ToInt32(binary_value, 2).ToString();
            return result;
        }

    }
}
