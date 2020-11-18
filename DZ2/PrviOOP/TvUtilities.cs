using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace PrviOOP
{
    class TvUtilities
    {
        static public double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * (10.0 - 0.0) + 0.0;
        }

        static public Episode Parse(string fileInput)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            string[] words = fileInput.Split(',');
            int viewers = int.Parse(words[0]);
            double totalSum = Convert.ToDouble(words[1],provider);
            double maxScore = Convert.ToDouble(words[2],provider);
            int number = int.Parse(words[3]);
            TimeSpan length = new TimeSpan();
            length = TimeSpan.Parse(words[4]);
            string name = words[5];
            Description description = new Description(number, length, name);
            Episode episode = new Episode(viewers, totalSum, maxScore, description);
            return episode;
        }
         static public void Sort(Episode[] episodes)
        {
            for (int i = 0; i < episodes.Length; i++)
            {
                for (int j = 0; j < episodes.Length; j++)
                {
                        if (episodes[i] > episodes[j]) 
                        {
                            Episode helper = episodes[i];
                            episodes[i] = episodes[j];
                            episodes[j] = helper;
                        }
                }
            }
        }
    }
}
