using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int newNum = number * count;
            for (int i = 0; i < count; i++)
            {
                newNum += i * add;
            }
            return newNum;
        }
    }
}
