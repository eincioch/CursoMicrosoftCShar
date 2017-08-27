using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp03_Class
{
    public class Test{
        public string A { get; set; }
    }

    public struct TestS
    {
        public string A { get; set; }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            //Built in types
            Console.WriteLine("Tipo por valor");
            int val1 = 10;
            int val2 = val1;
            val1++;
            val2 += 10;
            Console.WriteLine(val1);
            Console.WriteLine(val2);
            Console.ReadKey();

            Console.WriteLine("Tipo por referencia - structura");
            Test s1 = new Test();
            s1.A = "Hola mundo";
            Test s2 = s1;
            s2.A += " Waza";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadKey();

            Console.WriteLine("Tipo por referencia");
            TestS ss1 = new TestS();
            ss1.A = "Hola mundo";
            TestS ss2 = s1;
            ss2.A += " Waza";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
