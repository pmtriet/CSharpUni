using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUni
{
    internal class svcntt : sv
    {
        public bool LT { get; set; }
        public override string ToString()
        {
            return base.ToString() + ", LT= " + LT;
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("LT = {0}", LT);
        }

    }
}
