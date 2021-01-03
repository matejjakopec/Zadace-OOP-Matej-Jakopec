using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PrviOOP
{
    class SeasonEnum : IEnumerator
    {
        public List<Episode> season;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public SeasonEnum(List<Episode> list)
        {
            season = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < season.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Episode Current
        {
            get
            {
                try
                {
                    return season[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
