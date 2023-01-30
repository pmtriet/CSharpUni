using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUni
{
    internal class KClass : Interface1, Interface3
    {
        public void A1()
        {
            Console.WriteLine("I1-A1");
        }
        public void B1()
        {
            Console.WriteLine("I1-B1");
        }
        public void B3()
        {
            Console.WriteLine("I1-B3");
        }
    }
}
