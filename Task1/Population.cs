using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int i;
            for (i = 0; initialPopulation <= currentPopulation; i++)
            {
                initialPopulation += (initialPopulation * (int)percent /100) + visitors;
            }
            return i;
        }  
    }
}