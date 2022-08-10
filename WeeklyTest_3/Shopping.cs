using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.WeeklyTest_3
{

    class Shopping

    {
       
       public void doTransaction(string c)
        {
            
            Console.WriteLine("You got 15% discount on bill on credit card transaction");
        }
       public void doTransaction(string d,int a)
        {
            
            Console.WriteLine("No discount on bill on Debit card transaction");
        }

        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            Console.WriteLine("Enter the Card type");
            string C =Console.ReadLine();
            if(C=="Credit Card")
            {
                s.doTransaction(C);
            }
            else
            {
                s.doTransaction(C,1);
            }

            


                
        }
    }

}
