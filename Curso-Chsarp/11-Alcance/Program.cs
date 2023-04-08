using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Alcance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyeto 11- Alcance.");

            //Código para ver si una persona puede entrar al parque
            int edadPersona = 17;
            bool acompanado = true;
            string mensajeAlcance = "";


            if (edadPersona >= 18 && acompanado)

            {

                Console.WriteLine("La persona puede entrar el parque ");
                mensajeAlcance = "Condicion cumplida";
            }
            else 
            
            { 
                
                if (edadPersona < 18)
                {
                    Console.WriteLine("La persona NO edad suficiente ");
                       mensajeAlcance = "Condicion edad no cumplida";

                }

                
            }

            Console.WriteLine(mensajeAlcance);

            Console.ReadLine();
        }
    }
}
