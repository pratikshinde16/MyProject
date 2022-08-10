using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class ReverseCharacter
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            char[] ch = new char[size];

            Console.WriteLine("Ënter the char type array");

            for(int i=0;i<ch.Length;i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine(" ...................................  ");
            foreach(char x in ch)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("Reverse Array ...........");

            for(int i=ch.Length-1;i>=0; i--)

            {
                Console.Write(ch[i]+" ");
            }
        }
    }
}
