using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_EstructuraRepeticionPara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyeto 13- Estrcutura de repeticion FOR.");

            double saldo = 1000.00;
            double interes = 0.75 / 100; // 0.75% por mes
           // int iNumMes = 1; // inicialico el contador

            //Valor de partida; consicion de finalizacion; Valor de avance
            for (int iNumMes = 1; iNumMes <= 12; iNumMes++)
            {
                saldo += saldo * interes;
                Console.WriteLine("EL saldo luego del  " + iNumMes + " mes es:  " + saldo);
            }
;



          

            Console.ReadLine();
        }
    }
}
