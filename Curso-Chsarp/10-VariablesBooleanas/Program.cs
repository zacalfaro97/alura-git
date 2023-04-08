using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_VariablesBooleanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyeto 10- Variables booleanas.");

            //Código para ver si una persona puede entrar al parque
            int edadPersona = 18;
            bool acompanado = false;



            if (edadPersona >= 18 && acompanado)

            {
                Console.WriteLine("La persona puede entrar el parque ");
            }
            else
            {
               
                    Console.WriteLine("La persona NO puede entrar el parque por que no esta acompañado y no es mayor de 18 años ");
                
            }



            Console.ReadLine();
        }
    }
}
