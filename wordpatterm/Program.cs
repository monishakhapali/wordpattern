using System;
using System.Collections;
using System.Collections.Generic;

namespace wordpatterm
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string pattern = "abba";
            string str = "dog cat cat fish";
            bool b = WordPattern(pattern, str);
            Console.WriteLine(b);
            Console.ReadLine();

        }
        public static bool WordPattern(string pattern, string str)
        {
            var patternAndWord = new Dictionary<char, string>();
            var wordSet = new HashSet<string>();

            var wordList = str.Split(' ');
            if (pattern.Length != wordList.Length) return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (patternAndWord.ContainsKey(pattern[i]))
                {
                    var curWord = patternAndWord[pattern[i]];
                    if (wordList[i] != curWord)
                    {
                        return false;
                    }
                }
                else
                {
                    if (wordSet.Contains(wordList[i])) return false;
                    patternAndWord[pattern[i]] = wordList[i];
                    wordSet.Add(wordList[i]);
                }
            }

            return true;
        }
    }
}
