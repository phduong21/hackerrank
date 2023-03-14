using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
    class MiniMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            var arrayInt = arr.ToArray();
            long minVal = arrayInt[0];
            long maxVal = arrayInt[0];
            long allSum = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                allSum += arrayInt[i];
                if (arrayInt[i] < minVal)
                {
                    minVal = arrayInt[i];
                }

                if (arrayInt[i] > maxVal)
                {
                    maxVal = arrayInt[i];
                }
            }
            long r1 = allSum - maxVal;
            long r2 = allSum - minVal;
            Console.WriteLine($"{r1} {r2}");

        }
    }
}
