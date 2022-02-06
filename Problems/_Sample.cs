using System.Collections.Generic;
using NUnit.Framework;

namespace Problems
{
    public class Tests
    {
        [Test(Description = "https://www.hackerrank.com/challenges/diagonal-difference/")]
        [Category("Easy")]
        [Category("Hacker Rank")]
        [Category("Diagonal Difference")]
        [TestCaseSource("Input")]
        public void Test1((bool Output, string Input) item)
        {
        }

        public static IEnumerable<(bool Output, string Input)> Input
        {
            get
            {
                return new List<(bool Output, string Input)>()
                {
                    (true, ("aab")),
                };
            }
        }
    }
}