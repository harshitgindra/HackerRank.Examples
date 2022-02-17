using System.Collections.Generic;

namespace Problems.Medium
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-time-in-words/
    /// </summary>
    public class The_Time_in_Words
    {
        private static IDictionary<int, string> _nums = new Dictionary<int, string>()
        {
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fifteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"},
        };

        private static IDictionary<int, string> _range = new Dictionary<int, string>()
        {
            {2, "twenty"},
        };

        public static string timeInWords(int h, int m)
        {
            string result = "";
            if (m > 30)
            {
                h++;
                if (h == 13)
                {
                    h = 1;
                }

                result = $"{_GetStringForMinute(m)} to {_nums[h]}";
            }
            else
            {
                result = _nums[h];
                if (m == 0)
                {
                    result = $"{result} o' clock";
                }
                else
                {
                    result = $"{_GetStringForMinute(m)} past {result}";
                }
            }

            return result;
        }

        private static string _GetStringForMinute(int m)
        {
            if (m > 30)
            {
                m = 60 - m;
            }

            if (m == 30)
            {
                return "half";
            }
            else if (m == 15)
            {
                return $"quarter";
            }
            else if (m == 1)
            {
                return $"one minute";
            }
            else if (m < 20)
            {
                return $"{_nums[m]} minutes";
            }

            var tens = m / 10;
            var unit = m % 10;

            return $"{_range[tens]} {_nums[unit]} minutes";
        }
    }
}