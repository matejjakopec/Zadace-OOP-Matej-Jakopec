using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace PrviOOP
{
    class Episode
    {
        private int viewers;
        private double totalSum, highestScore;
        Description description;
        public Episode (int viewers, double totalSum, double highestScore, Description description)
        {
            this.viewers = viewers;
            this.totalSum = totalSum;
            this.highestScore = highestScore;
            this.description = description;
        }
        public Episode(int viewers, double totalSum, double highestScore)
        {
            this.viewers = viewers;
            this.totalSum = totalSum;
            this.highestScore = highestScore;
        }

        public override string ToString()
        {
            return viewers + " " + totalSum + " " + highestScore + " " + description.GetNumber() + " " + description.GetLength() + " " + description.GetName() ;
        }

        public TimeSpan GetLength()
        {
            return description.GetLength();
        }
        public Episode()
        {
            viewers = 0;
            totalSum = 0.0;
            highestScore = 0.0;
        }
        public void SetMaxScore(double highestScore)
        {
            this.highestScore = highestScore;
        }

        public void SetTotalSum(double totalSum)
        {
            this.totalSum = totalSum;
        }
        public void SetViewerCount(int viewers)
        {
            this.viewers = viewers;
        }
        public double GetMaxScore()
        {
            return highestScore;
        }

        public double GetTotalSum()
        {
            return totalSum;
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

        public static bool operator <(Episode lhs, Episode rhs)
        {
            if (lhs is null) return rhs is null;
            if (lhs.GetAverageScore() < rhs.GetAverageScore())
                return true;
            else
                return false;
        }

        public static bool operator >(Episode lhs, Episode rhs)
        {
            if (lhs is null) return rhs is null;
            if (lhs.GetAverageScore() > rhs.GetAverageScore())
                return true;
            else
                return false;
        }

    }
}
