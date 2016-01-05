using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalsOverUnderPredictor
{
    class Team
    {
        public string teamName;
        public int leaguePosition;
        public int form;

        public Team()
        {
            teamName = "Unknown";
        }

        public Team(string name)
        {
            teamName = name;
        }

        public string GetName()
        {
            return teamName;
        }

        public void SetName(string newName)
        {
            teamName = newName;
        }

    }
}
