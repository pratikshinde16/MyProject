using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest_3
{
    class RBI
    {
       public float rate_rbi = 6.5f;
        public float calculateBalRBI(int amount,int years)
        {
            return amount + ((amount * rate_rbi * years) / 100);
        }
    }

    class SBI:RBI
    {
        public float rate_sbi = 7f;
       public float calculateBalSBI(int amount,int years)
        {
            return amount + ((amount * rate_sbi * years) / 100);
        }
    }
    class Canara:SBI
    {
       public float rate_canara = 7.2f;
       public float calculateBalCanara(int amount,int years)
        {
            return amount + ((amount * rate_canara * years) / 100);
        }
    }
    class MultilevelInheritance
    {
        static void Main(string[] args)
        {
            Canara c = new Canara();
            Console.WriteLine("Enter the amount to Invest??");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("For how many time have to invest (in years)??");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Your amount according to canera bank policies after " + years + " years will be " + c.calculateBalCanara(amount, years));
            Console.WriteLine("Your amount according to State bank of India policies after " + years + " years will be " + c.calculateBalSBI(amount, years));
            Console.WriteLine("Your amount according to Reserve bank of India policies after " + years + " years will be " + c.calculateBalRBI(amount, years));


        }
    }
}
