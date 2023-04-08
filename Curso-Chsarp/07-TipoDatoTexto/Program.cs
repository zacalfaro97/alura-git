using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_TipoDatoTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyeto 07-Tipo de dato Texto.");

            char primeraLetra = 'A';
            char letraComoNumero = (char)65;
            letraComoNumero = (char)(letraComoNumero + 1);


            String nombreCurso = " Curso de C# de Alura Latam + \nC# Primeros pasos";

            Console.WriteLine("Estoy en el : " + nombreCurso );


            Console.ReadLine();
        }
    }
}
