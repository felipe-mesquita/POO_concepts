using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStatiques
{
    public static class ClasseA
    {
        public static int MethodeA()
        {
            return 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = ClasseA.MethodeA();
            Console.WriteLine("MéthodeA: " + x.ToString());
            Console.ReadLine();
        }
    }
}
