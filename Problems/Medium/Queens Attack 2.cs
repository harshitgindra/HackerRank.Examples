using System.Collections.Generic;
using System.Linq;

namespace Problems.Medium
{
    public class Queens_Attack_2
    {
        public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
        {
            int moves = 0;
            HashSet<(int, int)> movements = new HashSet<(int, int)>()
            {
                (-1, 0), // up
                (1, 0), // down
                (0, 1), // right
                (0, -1), // left
                (-1, -1), // diagonal left up
                (-1, 1), // diagonal right up
                (1, -1), // diagonal left down
                (1, 1), // diagonal right down
            };

            HashSet<(int, int)> obs = obstacles.Select(x => (x[0], x[1])).ToHashSet();

            foreach (var movement in movements)
            {
                var response = CalculateMoves(n, k, r_q, c_q, obs, movement.Item1, movement.Item2);
                moves += response.Moves;
                k = response.K;
            }

            return moves;
        }

        private static (int Moves, int K) CalculateMoves(int n, int k, int r_q, int c_q, HashSet<(int, int)> obs,
            int rOperation,
            int cOperation)
        {
            int moves = 0;
            int length = 1;
            int rQNew = r_q;
            int cQNew = c_q;

            while (length <= n)
            {
                rQNew += rOperation;
                cQNew += cOperation;

                if (rQNew >= 1 && cQNew >= 1 && rQNew <= n && cQNew <= n)
                {
                    if (k > 0 && obs.Contains((rQNew, cQNew)))
                    {
                        // Obstacle found
                        // decrement obstacle k, remove from the obs list
                        // break the loop
                        obs.Remove((rQNew, cQNew));
                        length = n + 1;
                        k--;
                    }
                    else
                    {
                        // No obstacle found
                        // increment the moves and continue
                        moves++;
                        length++;
                    }
                }
                else
                {
                    // out of bounds
                    // setting length = n+1 and jumping out of while loop
                    length = n + 1;
                }
            }

            return (moves, k);
        }
    }
}