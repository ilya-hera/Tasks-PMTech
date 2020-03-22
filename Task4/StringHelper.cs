using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            string arrStrings = "aoui";
            
            int counter = 0;
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j < arrStrings.Length; j++)
                    if (str[i] == arrStrings[j])
                    {
                        counter++;
                    }
            }
            return counter;
        }
    }
}
