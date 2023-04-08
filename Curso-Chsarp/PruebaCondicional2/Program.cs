using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCondicional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double salario = 4400.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("Su alícuota es de 7.5%");
                Console.WriteLine("Puedes deducir 142 pesos");

            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("Su alícuota es de 15.0%");
                Console.WriteLine("Puedes deducir 350 pesos");
            }
            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("Su alícuota es de 22.5%");
                Console.WriteLine("Puedes deducir 700 pesos");
            }

            int mes = 11;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("El mes es Enero");
                    break;
                case 2:
                    Console.WriteLine("El mes es Febrero");
                    break;
                case 3:
                    Console.WriteLine("El mes es Marzo");
                    break;
                case 4:
                    Console.WriteLine("El mes es Abril");
                    break;
                case 5:
                    Console.WriteLine("El mes es Mayo");
                    break;
                case 6:
                    Console.WriteLine("El mes es Junio");
                    break;
                case 7:
                    Console.WriteLine("El mes es Julio");
                    break;
                case 8:
                    Console.WriteLine("El mes es Agosto");
                    break;
                case 9:
                    Console.WriteLine("El mes es Septiembre");
                    break;
                case 10:
                    Console.WriteLine("El mes es Octubre");
                    break;
                case 11:
                    Console.WriteLine("El mes es Noviembre");
                    break;
                case 12:
                    Console.WriteLine("El mes es Diciembre");
                    break;
                default:
                    Console.WriteLine("Mes inválido");
                    break;
            }
            int contador = 1;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            


            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(contador);


            }*/


            int factorial = 1;
            for (int i = 1; i < 11; i++)
            {
                factorial *= i;
                Console.WriteLine("Factorial de " + i + " = " + factorial);
            }




            Console.ReadLine();



        }
        
    }
}

