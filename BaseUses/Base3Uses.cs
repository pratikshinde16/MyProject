using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BaseUses
{
    class Mobile
    {
        public void Camera()
        {
            Console.WriteLine("Camera is 64MP");
        }
        public Mobile(int model_no)
            
        {
            Console.WriteLine("Model Number "+model_no);
        }
        public int ram = 8;

    }
    class Samsung:Mobile
    {
        public Samsung():base(8600041)

        {
            Console.WriteLine("Samsung "+base.ram+"GB");
            base.Camera();
        }
        
    }
    class Vivo:Mobile
    {
        public int ram = 12;
        public Vivo():base(8412573)
        {
            Console.WriteLine("Vivo "+ram+"GB");
            base.Camera();
            
        }

    }
    class Base3Uses
    {
        static void Main(string[] args)
        {
            Samsung s = new Samsung();
            Vivo v = new Vivo();
            
        }
    }
}
