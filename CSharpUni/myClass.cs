using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUni
{
    internal class myClass : Interface1, Interface2
    {
        public void A1()
        {
            Console.WriteLine("I1-A1");
        }
        public void A2()
        {
            Console.WriteLine("I1-A2");
        }
        public void B1()
        {
            Console.WriteLine("I1-B1");
        }
        public void B2()
        {
            Console.WriteLine("I1-B2");
        }
    }
}
