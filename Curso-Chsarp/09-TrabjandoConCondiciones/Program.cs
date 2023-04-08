using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_TrabjandoConCondiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyeto 09- Trabajando con condiciones.");


            int edadLeonardo = 43;
            int edadMaria = 39  ;

            // Operadores condicionales:


            //Igual a 
            /*
            if ( edadLeonardo == edadMaria)

            {
                Console.WriteLine("la edad de leonardo es igual a la de maria");      
                    
            } else

            {
                Console.WriteLine("la edad de leonardo no es igual a la de maria");
            }

           */

            //Diferente de 
            /*
            if ( edadLeonardo != edadMaria)

            {
                Console.WriteLine("la edad de leonardo es diferente a la de maria");      
                    
            } else

            {
                Console.WriteLine("la edad de leonardo IGUAL a la de maria");
            }

           */
            
            //Mayor que
            
            if ( edadLeonardo > edadMaria)

            {
                Console.WriteLine("la edad de leonardo es mayor a la de maria");      
                    
            } else

            {
                Console.WriteLine("la edad de leonardo NO es mayor a la de maria");
            }

            //Menor que

            if (edadLeonardo < edadMaria)

            {
                Console.WriteLine("la edad de leonardo es menor a la de maria");

            }
            else

            {
                Console.WriteLine("la edad de leonardo NO es menor a la de maria");
            }
            

            
                
            

            Console.ReadLine();
        }
    }
}
