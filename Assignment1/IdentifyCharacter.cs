using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Assignment1
{
    class IdentifyCharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Character");
            
            Char ch = Convert.ToChar(Console.ReadLine());
            
            
            if((ch>='a' && ch<='z') || ch>='A' && ch<='Z')
                {

                Console.WriteLine(ch+" is Alphabet");
            }
            else if(ch>='0' && ch<='9')
            {
                Console.WriteLine(ch+" is Digit");

            }
            else
            {
                Console.WriteLine(ch+" is Special Character");
            } 
             

            

        }
    }
}
