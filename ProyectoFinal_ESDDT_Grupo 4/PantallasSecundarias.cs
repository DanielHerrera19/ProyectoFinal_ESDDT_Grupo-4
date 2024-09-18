using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    internal class PantallasSecundarias
    {
        public static int PersonalMedico()
        {
            int opcion = 0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("             PERSONAL MEDICO                 ");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("1. Disponibilidad de Sedes");
                    Console.WriteLine("2. Disponibilidad de Horarios");
                    Console.WriteLine("3. Gestion de citas reservadas");
                    Console.WriteLine("4. Subir resultados");
                    Console.WriteLine("5. Gestion de la farmacia");
                    Console.WriteLine("6. Salir/atras ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Eliga opcion:"); opcion = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("El valor ingresado debe ser númerico");
                    Console.ReadKey();
                }

            } while (opcion != 6);
            return opcion;
        }

        public static int Usuario()
        {
            int opcion = 0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("USUARIO");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("1. Agendar cita");
                    Console.WriteLine("2. Resultado medico");
                    Console.WriteLine("3. Farmacia");
                    Console.WriteLine("4. Editar Perfil");
                    Console.WriteLine("5. Salir/atras");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Eliga opcion:"); opcion = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("El valor ingresado debe ser númerico");
                    Console.ReadKey();
                }

            } while (opcion != 5);
            return opcion;
        }
    }
}
