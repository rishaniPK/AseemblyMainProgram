using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using internalAssembly1;


namespace AseemblyMainProgram
{
    class Program : Class1
    {
        static void Main(string[] args)
        {
            Program obj1 = new Program();

            Console.WriteLine("Addition " + obj1.x + obj1.y);
            Console.WriteLine("Addition " + obj1.y);
            Console.WriteLine("Additon " + obj1.add_numb());
            // Class1 i = new Class1();
            childassembly ch = new childassembly();
            Console.WriteLine("additon of x + y  + a + b = " + ch.add());
         
        }
    }
}
