using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notas Clase");

            int numalumnos;
            Console.WriteLine("Número de Alumnos:");
            numalumnos = Convert.ToInt32(Console.ReadLine());

            int[] dni = new int[numalumnos];
            string[] name = new string[numalumnos];
            int[] nota = new int[numalumnos];
            string[] calificación = new string[numalumnos];

            Random s = new Random();

            for (int i = 0; i < numalumnos; i++)
            {
                Console.WriteLine("Escribe sus Dnis");
                dni[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe sus nombres");
                name[i] = Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("Dni" + "\t\t" + "Nombre" + "\t\t" + "Nota" + "\t\t" + "Calificación");
            Console.WriteLine("-----------------------------------------------------------------------");


            for (int j = 0; j < dni.Length; j++)
            {
                nota[j] = s.Next(0, 10);
            }
            for (int j = 0; j < dni.Length; j++)
            {
                if (nota[j] < 5)
                {
                    calificación[j] = "SS";

                }
                if ((nota[j] < 7) && (nota[j] >= 5))
                {
                    calificación[j] = "AP";
                }
                if ((nota[j] < 9) && (nota[j] >= 7))
                {
                    calificación[j] = "NT";
                }
                if (nota[j] >= 9)
                {
                    calificación[j] = "SB";

                }
                Console.WriteLine(dni[j] + "\t\t" + name[j] + "\t\t" + nota[j] + "\t\t" + calificación[j]);
            }

            Console.WriteLine("Los aprobados y Jalados");
            for (int j = 0; j < dni.Length; j++)
            {
                if (nota[j] >= 5)
                {
                    Console.WriteLine("Los aprobados son" + name[j]);
                }
                if (nota[j] < 5)
                {
                    Console.WriteLine("Los reprobados son" + name[j]);
                }

            }
                int maxnota = nota.Max();
                int minnota = nota.Min();
                for (int x = 0; x < name.Length; x++)
                {
                    if (nota[x] == maxnota)
                    {
                        Console.WriteLine("La mejor nota la tiene" + name[x]);
                    }
                    if (nota[x] == minnota)
                    {
                        Console.WriteLine("la minima nota es de " + name[x]);
                    }
                }


            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
