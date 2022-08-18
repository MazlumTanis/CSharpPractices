using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualNumbers
{
    internal class IsVowel
    {

        private List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u','ı', 'ü', 'ö' };



    public void checkVowel(List<String> sentence)
        {
            bool flag=false;
            foreach(string s in sentence)
            {
                s.ToLower();
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (!vowels.Contains(s[i]) && !vowels.Contains(s[i + 1]))
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    Console.Write("True, ");
                }
                else
                {
                    Console.Write("False, ");
                }
                flag = false;
            }
           
            Console.WriteLine("\n");
        }
 
    }
}
