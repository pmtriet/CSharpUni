using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUni
{
    
    internal class Program
    {
        static void swap( ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void A(out int c)
        {
            c = 10;
        }
        static int sum(params int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return s;
        }
        static void Main(string[] args)
        {
            /*string s;
            s=Console.ReadLine();
            Console.WriteLine("s = {0}", s);*/


            /*int x;
            Console.Write("x = ");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine("x+1= {0}", x + 1);*/

            /*int x, y;
            Console.Write("x= ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.Write("y= ");
            y = Convert.ToInt32(Console.ReadLine());
            swap(ref x,ref y);
            Console.WriteLine("x = {0}, y={1}", x, y);*/


            /*string[] A = new string[3];
            for(int i=0; i<A.Length; i++)
            {
                Console.Write("A[{0}]= ", i);
                A[i] = Console.ReadLine();
            }
            foreach(string i in A)
            {
                Console.Write("{0} ",i);
            }*/
            int[] b = { 1, 2, 3, 4 };
            Console.WriteLine(sum(b));
            Console.WriteLine(sum(1, 2, 3, 4));

            /* int x=1;
             int y = 2;
             Console.WriteLine("x={0}, y={1}", x, y);*/
            /*            Console.Write("Nhap chuoi: ");
                        Console.WriteLine(Console.Read());*/


            double[,] matrix = new double[10, 10];
            int count = 0;
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    matrix[i, j] = ++count;
            foreach (double d in matrix)
                Console.WriteLine();
            string[][] software = new string[3][];
            software[0] = new string[]
            {
                "a", "b", "c";
            }
        /*software[1] = new string[]
        {
            "b", "e", "f";
        }*/
        /*foreach (double[] srr in matrix)
            foreach (double s in srr)
                Console.WriteLine(s);*/
        
}
        
    }
}
