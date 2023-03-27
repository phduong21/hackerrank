using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
    public class BreakingTheRecords
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            var result = new List<int>();

            if (scores.Count < 2)
            {
                result.Add(0); result.Add(0);
                return result;
            }
            var breakMinRecord = 0;
            var breakMaxRecord = 0;
            var firstElement = scores.First();
            var secondElement = scores.ElementAt(1);
            var min = 0;
            var max = 0;
            if (firstElement > secondElement)
            {
                breakMinRecord++;
                min = secondElement;
                max = firstElement;
            }
            else if (secondElement > firstElement)
            {
                breakMaxRecord++;
                min = firstElement;
                max = secondElement;
            }
            else
            {
                min = firstElement;
                max = firstElement;
            }

            foreach (var score in scores.Skip(2))
            {
                if (score < min)
                {
                    breakMinRecord++;
                    min = score;
                }
                else if (score > max)
                {
                    breakMaxRecord++;
                    max = score;
                }
            }
            result.Add(breakMaxRecord);
            result.Add(breakMinRecord);
            return result;
        }
    }
}
