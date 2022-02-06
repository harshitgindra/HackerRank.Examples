using System;
using System.Collections.Generic;

namespace Problems
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/diagonal-difference/
    /// </summary>
    public class Diagonal_Difference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int sum = 0;
            int index = 0;
            int length = arr.Count - 1;
            foreach (var item in arr)
            {
                int temp = item[index] - item[length - index];
                sum += temp;
                index++;
            }

            return Math.Abs(sum);
        }
    }
}