using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp02_Estructura
{
    class Program
    {
        static void Main(string[] args)
        {

            //las struct son tipos valor
            //Heredan de System.ValueType
            BilingDetails bilingDetails = new BilingDetails("Enrique","q","40904759");
            bilingDetails.AccountNumber = "10409047594";
            bilingDetails.Name = "Enrique Incio";

            //concatener old
            Console.WriteLine("Nombre del cliente:" + bilingDetails.Name);
            //concatenar C# v7
            Console.WriteLine($"Nombre del cliente:{bilingDetails.AccountNumber}");
            Console.ReadKey();
        }
    }
}
