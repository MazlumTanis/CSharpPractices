using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualNumbers
{
    internal class MutlakKare
    {
        List<int> numbers = new List<int>();
        int sumDif=0, sumSquare=0,point=67;
        public MutlakKare(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public void calcDif(List<int> numbers)
        {
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= point)
                {
                    sumDif= sumDif + (point - numbers[i]);
            
                }
                if (numbers[i] > point)
                {
                 sumSquare = sumSquare + ((numbers[i] - point) * (numbers[i] - point));
                }
               
            }
            Console.Write("{0},{1}\n\n", sumDif, sumSquare);
        }
    }
}
