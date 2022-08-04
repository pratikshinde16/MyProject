using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop_Test_2
{
    class KaprekarNumber1
    {
        public static bool isCheck(int num)
        {
            int count = 0;
            int temp = num;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            //Console.WriteLine(count);
            num = temp;
            int sq = num * num;
            int power = 1;
            for (int i = 1; i <= count; i++)
            {
                power = power * 10;
            }
            // Console.WriteLine(power);
            int q = sq / power;
            int r = sq % power;
            int sum = q + r;
            Console.WriteLine("sum= " + sum);
            if (sum == num)
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
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());
                bool isCorrect = isCheck(num);
                if(isCorrect)
                {
                    Console.WriteLine("Number is Kaprekar");
                }
                else
                {
                    Console.WriteLine("Not Kaprekar Number");
                }
            }
        
    }
}
