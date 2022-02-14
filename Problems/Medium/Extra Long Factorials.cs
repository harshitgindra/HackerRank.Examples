using System;
using NUnit.Framework;

namespace Problems.Medium
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/extra-long-factorials/
    /// </summary>
    public class Extra_Long_Factorials
    {
        public static void extraLongFactorials(int n)
        {
            string result = "1";
            for (int i = 2; i <= n; i++)
            {
                result = _Multiply(result, i);
            }

            Console.WriteLine(result);
        }

        private static string _Multiply(string num1, int num2)
        {
            string result = "";
            int carry = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                var temp = (Int32.Parse(num1[i].ToString()) * num2);

                // Add carry from previous transaction
                temp += carry;

                // reset carry to 0
                carry = 0;

                // Get the digit from units place and add to result
                var unitsPlace = temp % 10;
                result = unitsPlace + result;

                // result is greater than 10
                // Add a carry
                if (temp > 9)
                {
                    carry = temp / 10;
                }
            }

            if (carry != 0)
            {
                result = carry + result;
            }

            return result;
        }

        [Test(Description = "https://www.hackerrank.com/challenges/extra-long-factorials/")]
        [Category("Medium")]
        [Category("Hacker Rank")]
        [Category("Extra Long Factorials")]
        public void Test1((bool Output, string Input) item)
        {
            extraLongFactorials(30);
        }
    }
}