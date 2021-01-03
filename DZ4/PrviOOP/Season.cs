using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PrviOOP
{
    class Season : IEnumerable
    {
        private int number;

        public int Number
        {
            get { return number; }
            private set { number = value; }
        }

        private List<Episode> episodes = new List<Episode>();
        public List<Episode> Episodes
        {
            get { return episodes; }
            private set { episodes = value; }
        }


        public Season(int number, Episode[] episodes)
        {
            this.number = number;
            this.episodes = new List<Episode>();
            for (int i = 0; i < episodes.Length; i++)
            {
                this.episodes.Add(episodes[i]);
            }
        }

        public Season(int number, List<Episode> episodes)
        {
            this.number = number;
            this.episodes = episodes;
        }
        public Season(Season season)
        {
            this.number = number;
            foreach (Episode copy in season.episodes)
            {
                this.episodes.Add(new Episode(copy));
            }
        }
        public Episode this[int key]
        {
            get { return episodes[key]; }
            private set { episodes[key] = value; }
        }


        public int Length()
        {
            return episodes.Count;
        }

        public override string ToString()
        {
            string[] output = new string[episodes.Count + 8];
            int i;
            int totalViewers = 0;
            TimeSpan totalDuration = new TimeSpan(0, 0, 0);
            output[0] = $"Season {number}";
            output[1] = "=================================================";
            for (i = 0; i < episodes.Count; i++)
            {
                output[i + 2] = episodes[i].ToString();
                totalViewers += episodes[i].GetViewerCount();
                totalDuration += episodes[1].GetLength();
            }
            output[i + 3] = "Report:";
            output[i + 4] = "=================================================";
            output[i + 5] = $"Total viewers: {totalViewers}";
            output[i + 6] = $"Total duration: {totalDuration}";
            output[i + 7] = "=================================================";
            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < output.Length; j++)
            {
                sb.Append(output[j]);
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
            

        }

        public void Add(Episode episode)
        {
            episodes.Add(episode);
        }

        

        public void Remove(string name)
        {
            bool found = false;
            foreach(Episode episode in episodes.ToArray())
            {
                if(episode.Description.GetName() == name)
                {
                    episodes.Remove(episode);
                    found = true;
                }
            }
            if (!found)
                throw new TvException("Episode does not exist in this season", name);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public SeasonEnum GetEnumerator()
        {
            return new SeasonEnum(episodes);
        }


    }
}
