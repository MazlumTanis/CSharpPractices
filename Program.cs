using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intNumbers = new List<int>();
            List<int> mutlakList= new List<int>();
            List<string> isConsonantSentence = new List<string>();
            int n,choice;
            string s;
           
            while (true)
            {
                Console.Write("1-)Calculate Dual integers\n2-)Mutlak Kare alma\n3-)Swap words first and last characters\nPlease choose operation!: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Please choose list length(it's must be even): ");
                        n = int.Parse(Console.ReadLine());
                        if (n % 2 == 0)
                        {
                            break;
                        }
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Please enter a number: ");
                            intNumbers.Add(int.Parse(Console.ReadLine()));
                        }

                        CalcDual calcDual = new CalcDual(intNumbers);
                        calcDual.sumDual(intNumbers);

                        break;
                    case 2:

                        Console.Write("Please choose list length: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Please enter a number: ");
                            mutlakList.Add(int.Parse(Console.ReadLine()));
                        }

                        MutlakKare mutlakKare = new MutlakKare(mutlakList);
                        mutlakKare.calcDif(mutlakList);

                        break;
                    case 3:
                        Console.Write("Please enter a sentence: ");
                        s = Console.ReadLine();

                        SwitchChars switchChars = new SwitchChars(s);
                        switchChars.changeChar();
                        break;
                    case 4:
                        Console.Write("Please enter a sentence: ");
                        s = Console.ReadLine();
                        IsVowel isVowel = new IsVowel();
                        isConsonantSentence = s?.Split(' ').ToList();
                        isVowel.checkVowel(isConsonantSentence);
                        break;
                    default:
                        Console.WriteLine("ERROR! \n");
                        break;
                }
             
            }
        





       



            Console.Read();
        }
    }
}
