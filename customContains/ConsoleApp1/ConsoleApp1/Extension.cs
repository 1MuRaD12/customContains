using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Extension
    {
        public static bool customContains(this string word, string name)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    return true;
                }
                return true;
            }
            return true;


        }
    }
}
