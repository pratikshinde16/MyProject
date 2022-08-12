using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array_Demo
{
    class MinimumChar
    {
        public char Minimum(char[] a)
        {
            char m=a[0];
                for(int i=0;i<a.Length;i++)
                {
                    if(m>a[i])
                    {
                    m = a[i];
                    }
                }
            return m;
        }
        static void Main(string[] args)
        {
            char[] b = {'A', 'B', 'a', 'x', 'b'};
            MinimumChar m = new MinimumChar();
            char min = m.Minimum(b);
            Console.WriteLine("Minimum character is "+min);
        }
    }
}
