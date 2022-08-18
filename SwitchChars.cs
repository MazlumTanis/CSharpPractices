using System;
using System.Collections.Generic;
using System.Linq;

namespace DualNumbers
{
    internal class SwitchChars
    {
        List<string> words = new List<string>();

        public SwitchChars(string s)
        {
            words = s?.Split(' ').ToList();
        }

        public void changeChar()
        {
            
            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                char tasiyici = letters[0];
                letters[0] = letters[letters.Length - 1];
                letters[letters.Length - 1] = tasiyici;

                string s = "";
                foreach (var c in letters)
                    s += c.ToString();
                Console.Write(s + " ");

            }
            Console.WriteLine("\n");
        }
    }
}
