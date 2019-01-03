using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highscoreExamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HighscoreManager.Instance.LoadHighScores();

            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                HighscoreManager.Instance.AddHighScore(new HighScore("number#" + i, rnd.Next(100), DateTime.Now.Date));
            }

            HighscoreManager.Instance.SaveHighScores();

            Console.ReadKey();

        }
    }
}
