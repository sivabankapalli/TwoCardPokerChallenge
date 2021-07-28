using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge
{
    public class DetermineWinner
    {
        public ArrayList FinalWinner(List<HandComparisonItem> playersList)
        {
            try
            {
                var listByOwner = playersList.GroupBy(l => l.PlayerName)
                            .Select(lg =>
                                  new
                                  {
                                      PlayerName = lg.Key,
                                      TotalScore = lg.Sum(w => w.Rank),
                                      PlayerRank = 0
                                  }).OrderByDescending(o => o.TotalScore);
                ArrayList finalWinner = new ArrayList(2);

                int i = 0;
                foreach (var winner in listByOwner)
                {
                    finalWinner.Add(new ArrayList());
                    finalWinner[i] = winner.PlayerName +
                        "     " + winner.TotalScore.ToString()
                        + "      " + (++i);
                }

                return finalWinner;
            }
            catch (Exception e)
            {
                TwoCardPoker twoCardPoker = new TwoCardPoker();
                twoCardPoker.errorMessage.Visible = true;
                twoCardPoker.errorMessage.Text = @"Exception Thrown " + e.Message;
                return null;
            }
        }
    }
}