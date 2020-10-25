using System;
using System.Collections.Generic;
using System.Text;

namespace PrviOOP
{
    class Episode
    {
        private int viewers;
        private double totalSum, highestScore;
        public Episode(int viewers, double totalSum, double highestScore)
        {
            this.viewers = viewers;
            this.totalSum = totalSum;
            this.highestScore = highestScore;
        }

        public Episode()
        {
            viewers = 0;
            totalSum = 0.0;
            highestScore = 0.0;
        }

        public double GetMaxScore()
        {
            return highestScore;
        }

        public double GetAverageScore()
        {
            return totalSum / viewers;
        }

        public int GetViewerCount()
        {
            return viewers;
        }

        public void AddView(double score)
        {
            this.totalSum += score;
            this.viewers++;
            if (this.highestScore<score)
            {
                this.highestScore = score;
            }
        }

        public double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * (10.0 - 0.0) + 0.0;
        }

    }
}
