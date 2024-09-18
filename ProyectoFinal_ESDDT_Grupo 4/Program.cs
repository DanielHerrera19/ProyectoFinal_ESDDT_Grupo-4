using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("  Bienvenido a clinica oftalmologica ");
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*                                    ");
                Console.WriteLine("             ▄█████▄                 ");
                Console.WriteLine("           ███  █  ███               ");
                Console.WriteLine("          ███   █   ███              ");
                Console.WriteLine("           ███  █  ███               ");
                Console.WriteLine("             ▀█████▀                 ");
                Console.WriteLine("                                    *");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("          1.Personal médico          ");
                Console.WriteLine("          2.Usuario                  ");
                Console.WriteLine("          3.Salir                    ");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Eliga opcion:");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = PantallasSecundarias.PersonalMedico();
                        break;
                    case 2:
                        opcion = PantallasSecundarias.Usuario();
                        break;
                    case 0:
                    default:
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 3);
        }
    }
}
