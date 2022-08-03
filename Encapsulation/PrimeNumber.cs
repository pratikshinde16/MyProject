using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Encapsulation
{
    class PrimeNumber
    {
        bool Prime(int n)
        {
            int temp = 0;
            for(int i=2;n>i;i++)
            {
                if(n%i==0)
                {
                    temp = 1;
                    break;
                }

            }
            if(temp==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            PrimeNumber p = new PrimeNumber();
            bool d = p.Prime(12);
                if(d==true)
            {
                Console.WriteLine("Prime Number");
            }
                else
            {
                Console.WriteLine("Not Prime Number");
            }
        }
    }
}
