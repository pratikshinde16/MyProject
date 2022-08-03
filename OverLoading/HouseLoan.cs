using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OverLoading
{
    class HouseLoan
    {
       float CalculateLoan(int P,float RI,int N)

        {
            float loan;
            return loan = (float)P * RI * N;

        }
        float CalculateLoan(int P, float RI1, float RI2,int N)
        {
            float loan1;
            if(N<=6)
            {
                return loan1 = (float)P * RI1 * N;
            }
            else
            {
                return loan1 = (float)P * RI2 * N;
            }
        }
        static void Main(string[] args)
        {
                HouseLoan h = new HouseLoan();
            Console.WriteLine(h.CalculateLoan(10000,11f,6));
        }
    }
}
