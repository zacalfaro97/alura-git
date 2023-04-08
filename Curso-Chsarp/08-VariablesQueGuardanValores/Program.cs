using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_VariablesQueGuardanValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyeto 08-Variables que guardan valores.");

            int edadLeonardo = 39;
            int edadMaria = edadLeonardo + 5 ;

            Console.WriteLine("La edad de Leonardo es:  " + edadLeonardo);
            Console.WriteLine("La edad de Leonardo es:  " + edadMaria);


            Console.ReadLine();
        }
    }
}
