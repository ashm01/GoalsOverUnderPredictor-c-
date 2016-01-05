using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalsOverUnderPredictor
{
    class MatchResults
    {
        public List<Match> Results { get; set; }

        public MatchResults()
        {
            Results = new List<Match>();
        }

        public double PredictNumGoals(Team hT, Team aT)
        {
            int homeMatchCounter = 0;
            int awayMatchCounter = 0;
            int numMatchGoalsHome = 0;
            int numMatchGoalsAway = 0;

            foreach (Match m in Results)
            {
                if(m.homeTeam.teamName == hT.teamName)
                {
                    numMatchGoalsHome += m.fullTimeHomeGoals + m.fullTimeAwayGoals;
                    homeMatchCounter+= 1;
                }
                if(m.awayTeam.teamName == aT.teamName)
                {
                    numMatchGoalsAway += m.fullTimeAwayGoals + m.fullTimeHomeGoals;
                    awayMatchCounter+= 1;
                }

            }
            double homeTeamAverageGoals = numMatchGoalsHome / homeMatchCounter;
            double awayTeamAverageGoals = numMatchGoalsAway / awayMatchCounter;
            Console.WriteLine(homeTeamAverageGoals);
            Console.WriteLine(awayTeamAverageGoals);
            return (homeTeamAverageGoals + awayTeamAverageGoals ) /2;
        }
    }
}
