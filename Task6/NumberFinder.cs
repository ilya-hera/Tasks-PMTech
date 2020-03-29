using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace PadawansTask6
{
    public static class NumberFinder
    {

        public static int? NextBiggerThan(int number)
        {
            try
            {
                string str = number.ToString();
                string i = str[(str.Length - 1)].ToString();

                string news = str.Insert(str.Length - 2, i);

                return int.Parse(news.Remove(news.Length - 1));
            }
            catch
            {
                return null;
            }

            
        }
    
        
    }
}
