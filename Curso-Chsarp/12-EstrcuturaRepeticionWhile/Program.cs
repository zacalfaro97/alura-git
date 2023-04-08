using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EstrcuturaRepeticionWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyeto 12- Estrcutura de repeticion While.");

            double saldo = 1000.00;
            double interes = 0.75 / 100; // 0.75% por mes
            int iNumMes = 1; // inicialico el contador


            while (iNumMes <= 24)
            {
                
                saldo +=saldo * interes;
                Console.WriteLine("EL saldo luego del  " +iNumMes+ " mes es:  " + saldo);

               // iNumMes = iNumMes + 1; ;// le suman uno al copntador y se sale 
                iNumMes++;

            }






            Console.ReadLine(); 
        }
    }
}
