using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static int FirstUniqChar(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        List<char> removedLetters = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (!dict.ContainsKey(ch))
            {
                if (!removedLetters.Contains(ch))
                {
                    dict[ch] = i;
                }
            }
            else
            {
                dict.Remove(ch);
                removedLetters.Add(ch);
            }
        }

        int index = dict.First().Value;
        return index;
    }
}
