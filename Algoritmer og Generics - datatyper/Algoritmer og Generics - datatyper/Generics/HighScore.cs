using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    class HighScore : IComparable<HighScore> //allows two highscores to be compared
    {
        string name;
        int score;

        public HighScore(string _name, int _score)
        {
            name = _name;
            score = _score;
        }

        //returns 1 or -1 or 0 if they're the same
        public int CompareTo(HighScore other)
        {
            // If other is not a valid object reference, this instance is greater.
            if (other == null) return 1;

            //if the score is the same
            if (this.score.CompareTo(other.score) == 0)
            {
                //compare names
                return this.name.CompareTo(other.name);
            }
            //else compare scores
            //Negative because it sorts from smallest to largest
            return -this.score.CompareTo(other.score);

        }

        public override string ToString()
        {
            return name + "  " + score;
        }
    }
}

