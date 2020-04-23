namespace HammingCodeCalculator
{
    static class OperationXOR
    {
        internal static string functionXOR(string binary_value)
        {
            string result = string.Empty;
            var numbers = int.Parse(binary_value);
            int sum = 0;
            while (numbers != 0)
            {
                sum += numbers % 10;
                numbers /= 10;
            }
            if (sum % 2 == 1)
                result = "1";
            else
                result = "0";
          
            return result;
        }
    }
}
