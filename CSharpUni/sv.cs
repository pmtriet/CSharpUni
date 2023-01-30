using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUni
{
    internal class sv
    {
        /*private string _mssv;
        private string _name;
        private double _dtb;
        public double dtb
        {
            get
            {
                return this._dtb;
            }
            set
            {
                this._dtb = value;
            }
        }
        public string getName()
        {
            return this._name;
        }
        public sv()
        {
            _mssv = "1"; _name = "NVA";_dtb= 0.1;
        }
        public sv(string m, string n, double d)
        {
            _mssv=m, _name=n, _dtb = d;
        }
        public sv(sv s)
        {
            _mssv=s._mssv, _name=s._name, _dtb = s._dtb;
        }*/
        public string mssv { get; set; }
        public string name { get; set; }
        public string dtb { get; set; }
        public virtual void show()
        {
            Console.WriteLine("MSSV:{0}, Name:{1}, DTB: {2}", mssv, name, dtb);
        }
        public override string ToString()
        {
            return "MSSV: " + mssv + ", NAME: " + name + ", DTB: " + dtb;
        }
    }
}
