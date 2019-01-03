using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highscoreExamExample
{
    class HighScore : IComparable<HighScore>
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }


        public HighScore(string name, int score, DateTime date)
        {
            Name = name;
            Score = score;
            Date = date;
        }

        public int CompareTo(HighScore other)
        {
            // If other is not a valid object reference, this instance is greater.
            if (other == null) return 1;

            //if the score is the same
            if (this.Score.CompareTo(other.Score) == 0)
            {

                if (this.Name.CompareTo(other.Name) == 0)
                {
                    return this.Date.CompareTo(other.Date);
                }
                return this.Name.CompareTo(other.Name);
            }

            //else compare scores
            //Negative because it sorts from smallest to largest
            return -this.Score.CompareTo(other.Score);
        }

        public override string ToString()
        {
            return "Name: " + Name + " Score: " + Score + " Date: " + Date;
        }

    }

}
