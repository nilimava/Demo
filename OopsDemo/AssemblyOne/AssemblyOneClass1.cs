using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        private int Id;
        public void Display1()
        {
            //Private Member Accessible with the Containing Type only
            //Where they are created, they are available only within that type
            Console.WriteLine(Id);
        }
    }
    public class AssemblyOneClass2 : AssemblyOneClass1
    {
        public void Display2()
        {
            Display1();
        }

        
     
        //You cannot access the Private Member from the Derived Class
        //Within the Same Assembly
        // Console.WriteLine(Id); //Compile Time Error
    }

   
}

