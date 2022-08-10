using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.ExtraHW
{
    class PrimetillNegative
    {
        public void Prime(int num)
        {
            int temp = 1;
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    temp = 0;
                    break;
                }
            }
            if(num<0)
            {
                Console.WriteLine("Invalid Number");
            }
            else if(temp==1)
            {
                Console.WriteLine("Prime Number");
            }
        }


        static void Main(string[] args)
        {
            PrimetillNegative p = new PrimetillNegative();
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            p.Prime(num);
            
          
        }
    }
}
