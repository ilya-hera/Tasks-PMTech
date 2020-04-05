using System.Text;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        

            public static void RemoveDuplicateWords(ref string text)
            {
                string[] listOfWords = text.Split(' ');

                for (int i = 0; i < listOfWords.Length; i++)
                {
                    if (i != Array.IndexOf(listOfWords, listOfWords[i]) && listOfWords[i] != " ")
                    {
                        listOfWords[i] = "";
                    }
                }

                text = String.Join(" ", listOfWords);
            }


        

    
    }
}