using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_PalabraReservada_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Ejecutando el proyeto 13- Estructura de repeticion FOR Anidadas.");

            double saldo = 1000.00;
            double interes = 0.75 / 100; // 0.75% por mes
                                         // int iNumMes = 1; // inicialico el contador
            for (int iNumAso = 0; iNumAso <= 5; iNumAso++)
            {
                Console.WriteLine("Año " + iNumAso);

                if (iNumAso >= 5)
                {

                    interes = 0.90 / 100;


                }
                else if (iNumAso >= 3)
                {
                    interes = 0.85 / 100;

                }

                //Valor de partida; consicion de finalizacion; Valor de avance
                for (int iNumMes = 1; iNumMes <= 12; iNumMes++)
                {
                    saldo += saldo * interes;
                    if (saldo > 1200)
                        break;


                    Console.WriteLine("EL saldo luego del  " + iNumMes + " mes es:  " + saldo);
                }


                if (saldo > 1200)
                    break;

            }



            Console.ReadLine();
        }
    }
}
