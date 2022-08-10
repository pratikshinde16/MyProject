using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Abstraction
{

  
    abstract class Integer
    {
        public int a = 35;
        
        
    }
    public interface IInteger2
    {
        static int b = 45;
    }
    class Sum:Integer,IInteger2
    {
        public void Calculate()
        {
            Console.WriteLine(a+IInteger2.b);
        }
    }



    class IntegerAddition
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            s.Calculate();

        }


    }
}
