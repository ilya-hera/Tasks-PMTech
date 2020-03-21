using System;
using System.Collections.Generic;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            int gcd = 0;
            List<int> Numbers = new List<int> ();
            for (int i = 1; i <= a; i++)
            {
                if(a % i == 0)
                {
                    Numbers.Add (i);
                }
            }
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (b % Numbers[i] == 0)
                {
                    if(Numbers[i] > gcd)
                    {
                        gcd = Numbers[i];
                    }
                }
            }
            return gcd;
        }
    }
}
