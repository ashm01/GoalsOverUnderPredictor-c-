using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoalsOverUnderPredictor
{
    public partial class Form1 : Form
    {
        private MatchResults premiershipResults = new MatchResults();
        private MatchResults championshipResults = new MatchResults();
        private MatchResults leagueOneResults = new MatchResults();
        private MatchResults leagueTwoResults = new MatchResults();
        private List<string> premTeams = new List<string>();
        private List<string> champTeams = new List<string>();
        private List<string> l1Teams = new List<string>();
        private List<string> l2Teams = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            
        }

        private void getResultButton_Click(object sender, EventArgs e)
        {
            Team home = new Team(comboBox_Home.Text);
            Team away = new Team(comboBox_Away.Text);
            double prediction =  premiershipResults.PredictNumGoals(home, away);
            if(prediction > 2.5)
            {
                label_Result.Text = "Over";
            }
            else
            {
                label_Result.Text = "Under";
            }
            
            label_Result.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string line;

            // Reading the prem stats in
            System.IO.StreamReader file =
               new System.IO.StreamReader("C:\\Users\\moora\\Documents\\Visual Studio 2015\\premStats.csv");
            while ((line = file.ReadLine()) != null)
            {
                String[] tokens = line.Split(',');
                string date = tokens[0];
                String[] dateTokens = date.Split('/');
                Team home = new Team(tokens[1]);
                Team away = new Team(tokens[2]);
               
                //Console.WriteLine(tokens[0]);
                //Console.WriteLine(dateTokens.Length);
                DateTime matchDate = new DateTime(
                    Int32.Parse(dateTokens[2]), Int32.Parse(dateTokens[1]), Int32.Parse(dateTokens[0]));
                Match m = new Match(matchDate, home, away, Int32.Parse(tokens[3]), Int32.Parse(tokens[4]),
                    tokens[5], Int32.Parse(tokens[6]), Int32.Parse(tokens[7]),tokens[8]);
                premiershipResults.Results.Add(m);
                //Console.WriteLine(line);
            }
            file.Close();

            //Reading the championship stats in
            //re initilise the file object to the champ stats csv file
            file = new System.IO.StreamReader("C:\\Users\\moora\\Documents\\Visual Studio 2015\\champStats.csv");
            while ((line = file.ReadLine()) != null)
            {
                //Splitting each line from the csv file into individual parts
                String[] tokens = line.Split(',');
                //the first token is the date which intrun needs to be split so a datetime object can be
                // created
                string date = tokens[0];
                String[] dateTokens = date.Split('/');
                Team home = new Team(tokens[1]);
                Team away = new Team(tokens[2]);
                //Creating a match date from the date token parts read from the csv file
                DateTime matchDate = new DateTime(
                    Int32.Parse(dateTokens[2]), Int32.Parse(dateTokens[1]), Int32.Parse(dateTokens[0]));
                Match m = new Match(matchDate, home, away, Int32.Parse(tokens[3]), Int32.Parse(tokens[4]),
                    tokens[5], Int32.Parse(tokens[6]), Int32.Parse(tokens[7]), tokens[8]);
                championshipResults.Results.Add(m);
            }
            file.Close();

            //Reading the league one stats in
            //re initilise the file object to the champ stats csv file
            file = new System.IO.StreamReader("C:\\Users\\moora\\Documents\\Visual Studio 2015\\leag1Stats.csv");
            while ((line = file.ReadLine()) != null)
            {
                //Splitting each line from the csv file into individual parts
                String[] tokens = line.Split(',');
                //the first token is the date which intrun needs to be split so a datetime object can be
                // created
                string date = tokens[0];
                String[] dateTokens = date.Split('/');
                Team home = new Team(tokens[1]);
                Team away = new Team(tokens[2]);
                //Creating a match date from the date token parts read from the csv file
                DateTime matchDate = new DateTime(
                    Int32.Parse(dateTokens[2]), Int32.Parse(dateTokens[1]), Int32.Parse(dateTokens[0]));
                Match m = new Match(matchDate, home, away, Int32.Parse(tokens[3]), Int32.Parse(tokens[4]),
                    tokens[5], Int32.Parse(tokens[6]), Int32.Parse(tokens[7]), tokens[8]);
                leagueOneResults.Results.Add(m);
            }
            file.Close();

            //Reading the league two stats in
            //re initilise the file object to the champ stats csv file
            file = new System.IO.StreamReader("C:\\Users\\moora\\Documents\\Visual Studio 2015\\leag2Stats.csv");
            while ((line = file.ReadLine()) != null)
            {
                //Splitting each line from the csv file into individual parts
                String[] tokens = line.Split(',');
                //the first token is the date which intrun needs to be split so a datetime object can be
                // created
                string date = tokens[0];
                String[] dateTokens = date.Split('/');
                Team home = new Team(tokens[1]);
                Team away = new Team(tokens[2]);
                //Creating a match date from the date token parts read from the csv file
                DateTime matchDate = new DateTime(
                    Int32.Parse(dateTokens[2]), Int32.Parse(dateTokens[1]), Int32.Parse(dateTokens[0]));
                Match m = new Match(matchDate, home, away, Int32.Parse(tokens[3]), Int32.Parse(tokens[4]),
                    tokens[5], Int32.Parse(tokens[6]), Int32.Parse(tokens[7]), tokens[8]);
                leagueTwoResults.Results.Add(m);
            }
            file.Close();

            //getting the 20 unique team values from the result list
            premTeams = premiershipResults.Results.Select(team => team.homeTeam.teamName).Distinct().ToList();
            //Console.WriteLine(premTeams.Capacity);
            premTeams.Sort();
            //getting the 24 unique team values from the result list
            champTeams = championshipResults.Results.Select(team => team.homeTeam.teamName).Distinct().ToList();
            //sorting the teams into alphabetical order
            champTeams.Sort();
            //getting the 24 unique team values from the result list
            l1Teams = leagueOneResults.Results.Select(team => team.homeTeam.teamName).Distinct().ToList();
            //sorting the teams into alphabetical order
            l1Teams.Sort();
            //getting the 24 unique team values from the result list
            l2Teams = leagueTwoResults.Results.Select(team => team.homeTeam.teamName).Distinct().ToList();
            //sorting the teams into alphabetical order
            l2Teams.Sort();


        }

        private void comboBox_League_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Clear current lists
            comboBox_Away.Text = " ";
            comboBox_Home.Text = " ";
            comboBox_Away.Items.Clear();
            comboBox_Home.Items.Clear();
            //Changing the drop down lists based on which league is selected
            if (comboBox_League.Text == "Premiership")
            {
                
                foreach (string a in premTeams)
                {
                    comboBox_Away.Items.Add(a);
                    comboBox_Home.Items.Add(a);
                }

            }else if(comboBox_League.Text == "Championship")
            {
                
                foreach (string a in champTeams)
                {
                    comboBox_Away.Items.Add(a);
                    comboBox_Home.Items.Add(a);
                }

            }
            else if(comboBox_League.Text == "League One")
            {
                
                foreach (string a in l1Teams)
                {
                    comboBox_Away.Items.Add(a);
                    comboBox_Home.Items.Add(a);
                }
            }
            else if(comboBox_League.Text == "League Two")
            {
                
                foreach (string a in l2Teams)
                {
                    comboBox_Away.Items.Add(a);
                    comboBox_Home.Items.Add(a);
                }
            }


        }
    }
}
