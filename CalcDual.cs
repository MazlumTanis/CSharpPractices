using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualNumbers
{
    internal class CalcDual
    {
        private List<int> numb=new List<int>();
        private int n;


        public CalcDual(List<int> numb)
        {
            this.numb = numb;
        }

        public void sumDual(List<int> numb)
        {
            for(int i = 0; i < numb.Count; i = i + 2)
            {
                if (numb[i] == numb[i + 1])
                {
                    Console.Write("{0}, ", numb[i]* numb[i]);
                }
                else
                {
                    Console.Write("{0},", numb[i] + numb[i + 1]);
                }
            }
        }


            

    }
}
