using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class TournamentWinner
    {
        public string TournamentWinnerMethod(List<List<string>> competitions, List<int> results)
        {
            Dictionary<string, int> score = new Dictionary<string, int>();

            for (int i = 0; i < competitions.Count; i++)
            {
                var testWinner = results[i] == 1 ? competitions[i][0] : competitions[i][1];
                if (score.ContainsKey(testWinner))
                {
                    score[testWinner] += 3;
                }
                else
                {
                    score.Add(testWinner, 3);
                }

            }
            return score.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }
    }
}
