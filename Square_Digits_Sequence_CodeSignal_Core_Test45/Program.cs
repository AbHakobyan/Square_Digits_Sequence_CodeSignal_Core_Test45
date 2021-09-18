using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Digits_Sequence_CodeSignal_Core_Test45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 16;
            int result = squareDigitsSequence(n);
            Console.WriteLine(result);
        }


        static int squareDigitsSequence(int a0)
        {
            int cur = a0;
            HashSet<int> was = new HashSet<int>();

            while (!was.Contains(cur))
            {
                was.Add(cur);
                int next = 0;
                while (cur > 0)
                {
                    next += (cur % 10) * (cur % 10);
                    cur /= 10;
                }
                cur = next;
            }

            return was.Count + 1;
        }

    }
}
