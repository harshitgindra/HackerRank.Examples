using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Problems.Medium
{
    public class Climbing_the_Leaderboard
    {
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();

            var cleanerRank = ranked.ToHashSet().ToArray();
            int i = cleanerRank.Length - 1;

            for (int j = 0; j < player.Count; j++)
            {
                bool rankFound = false;
                while (!rankFound && i >= 0)
                {
                    if (player[j] < cleanerRank[i])
                    {
                        result.Add(i + 2);
                        rankFound = true;
                    }
                    else if (player[j] == cleanerRank[i])
                    {
                        result.Add(i + 1);
                        rankFound = true;
                    }
                    else
                    {
                        i--;
                    }
                }

                if (!rankFound)
                {
                    result.Add(1);
                }
            }

            return result;
        }

        [Test(Description = "https://www.hackerrank.com/challenges/climbing-the-leaderboard/")]
        [Category("Medium")]
        [Category("Hacker Rank")]
        [Category("Climbing the Leaderboard")]
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