using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_caso1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Control de Aprobación de Curso ---\n");
            double nota = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Ingrese la nota final del estudiante (0 a 100): ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out nota))
                {
                    if (nota >= 0 && nota <= 100)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: La nota debe estar estrictamente entre 0 y 100. Intente otra vez.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un valor numérico válido (ej. 75 o 85.5). Intente otra vez.");
                }
            }

            string resultado;
            if (nota >= 70)
            {
                resultado = "Aprobado";
            }
            else
            {
                resultado = "Reprobado";
            }

            Console.WriteLine($"\nEl estudiante: {resultado} (Nota registrada: {nota})");


        }
    }
}
