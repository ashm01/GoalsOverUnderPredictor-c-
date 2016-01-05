using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalsOverUnderPredictor
{
    class Match
    {
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }
        public int fullTimeHomeGoals { get; set; }
        public int fullTimeAwayGoals { get; set; }
        public string fullTimeResult { get; set; }
        public int halfTimeHomeGoals { get; set; }
        public int halfTimeAwayGoals { get; set; }
        public string halfTimeResult { get; set; }
        public DateTime dateOfMatch { get; set; }

        public Match()
        {
            homeTeam = new Team();
            awayTeam = new Team();
            fullTimeHomeGoals = 0;
            fullTimeAwayGoals = 0;
            fullTimeResult = "D";
            halfTimeAwayGoals = 0;
            halfTimeHomeGoals = 0;
            halfTimeResult = "D";
            dateOfMatch = new DateTime();
        }

        public Match(DateTime date, Team home, Team away, int homeFTGoals, int awayFTGoals, string FTResult,
            int homeHTgoals, int awayHTgoals, string HTResult)
        {
            homeTeam = home;
            awayTeam = away;
            fullTimeHomeGoals = homeFTGoals;
            fullTimeAwayGoals = awayFTGoals;
            fullTimeResult = FTResult;
            halfTimeAwayGoals = awayHTgoals;
            halfTimeHomeGoals = homeHTgoals;
            halfTimeResult = HTResult;
            dateOfMatch = date;
        }
        


    }
}
