using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamProblem
{
    public class PrimeNumber
    {
        public void CheckPrimeNumber(int startNo, int EndNo)
        {
            int count = 0;
            for (int num = startNo; num <= EndNo; num++)
            {
                bool flag = false;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag && num != 1)
                {
                    Console.WriteLine("{0} ", num);
                    count++;
                }
            }
            Console.WriteLine($"Total Prime Numbers from {startNo} to {EndNo} are {count}");
        }
    }
}
