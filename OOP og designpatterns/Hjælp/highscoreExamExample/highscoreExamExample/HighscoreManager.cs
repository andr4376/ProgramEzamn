using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highscoreExamExample
{
    class HighscoreManager
    {
        private static HighscoreManager instance;
        private List<HighScore> highscores;


        public static HighscoreManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HighscoreManager();
                }
                return instance;
            }
        }

        private HighscoreManager()
        {
            highscores = new List<HighScore>();
        }

        public void AddHighScore(HighScore highscore)
        {
            highscores.Add(highscore);
            highscores.Sort();
        }

        public void PrintHighScores()
        {
            foreach (HighScore highScore in highscores)
            {
                Console.WriteLine(highScore.ToString());
            }
        }

        public void SaveHighScores()
        {
            if (!File.Exists("Highscores.txt"))
            {
                File.Create("Highscores.txt");
            }

            File.WriteAllText("Highscores.txt", string.Empty);
            for (int i = 0; i < 10; i++)
            {
                if (highscores[i] == null)
                {
                    break;
                }

                string highScoreString = highscores[i].Name + "," + highscores[i].Score + "," + highscores[i].Date + ";";

                File.AppendAllText("Highscores.txt", highScoreString);
            }

        }
        public void LoadHighScores()
        {
            if (!File.Exists("Highscores.txt"))
            {
                return;
            }

            string[] array = File.ReadAllText("Highscores.txt").Split(';');

            for (int i = 0; i < array.Length-1; i++)
            {
                string[] subArray = array[i].Split(',');

                string name = subArray[0];

                Int32.TryParse(subArray[1], out int score);

                DateTime.TryParse(subArray[2], out DateTime date);

                HighscoreManager.instance.AddHighScore(new HighScore(name, score, date));


            }

        }
    }
}
