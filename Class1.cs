using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission1
{
    internal class Class1
    {

        public int[] rollDice(int numOfTimes)
        {

            int[] rollSums = new int[13];
            Random rnd = new Random();

            for (int i = 0; i<numOfTimes; i++)
            {
                int roll1 = rnd.Next(1, 7);
                int roll2 = rnd.Next(1, 7);
                int sum = roll1 + roll2;
                rollSums[sum]++;
            }
            return rollSums;
        }
    }
}
