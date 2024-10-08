﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    public class PantallasSecundarias
    {
        public static int PersonalMedico()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|-----------------------------------|");
                Console.WriteLine("|         PERSONAL MEDICO           |");
                Console.WriteLine("|-----------------------------------|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Disponibilidad de Sedes");
                Console.WriteLine("2. Disponibilidad de Horarios");
                Console.WriteLine("3. Gestion de citas reservadas");
                Console.WriteLine("4. Subir resultados");
                Console.WriteLine("5. Gestion de la farmacia");
                Console.WriteLine("6. Salir/atras ");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Eliga opcion:"); opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        
                        break;
                    case 2:

                        break;
                    case 3:
                        PantallasSecundarias.MenuReservas();
                        break;
                    case 4:
                        PantallasSecundarias.MenuResultadosMedicos();
                        break;
                    case 5:

                        break;
                    case 0:
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opcion != 6);
            return opcion;
        }

        public static int Usuario()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("|         USUARIO           |");
                Console.WriteLine("|---------------------------|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Agendar cita");
                Console.WriteLine("2. Resultado medico");
                Console.WriteLine("3. Farmacia");
                Console.WriteLine("4. Editar Perfil");
                Console.WriteLine("5. Salir/atras");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Eliga opcion:"); opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        ReservaDeUsuario.ReservaDeCita();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 0:
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opcion != 5);
            return opcion;
        }

        private static ResultadoMedicoManager resultadoManager = new ResultadoMedicoManager();

        public static void MenuResultadosMedicos()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("|      RESULTADOS MÉDICOS   |");
                Console.WriteLine("|---------------------------|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Agregar resultado");
                Console.WriteLine("2. Mostrar resultados");
                Console.WriteLine("3. Actualizar resultado");
                Console.WriteLine("4. Eliminar resultado");
                Console.WriteLine("5. Salir");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Elija opción:");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Lógica para agregar resultado
                        break;
                    case 2:
                        resultadoManager.MostrarResultadosMedicos();
                        break;
                    case 3:
                        // Lógica para actualizar resultado
                        break;
                    case 4:
                        // Lógica para eliminar resultado
                        break;
                    default:
                        break;
                }

                Console.ReadKey();
            } while (opcion != 5);            
        }

        public static void MenuReservas()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("|     RESERVAS DE CITAS     |");
                Console.WriteLine("|---------------------------|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Agregar cita");
                Console.WriteLine("2. Mostrar cita");
                Console.WriteLine("3. Actualizar cita");
                Console.WriteLine("4. Eliminar cita");
                Console.WriteLine("5. Salir");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Elija opción:");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        //Agregar Cita
                        break;
                    case 2:
                        //Mostrar cita
                        break;
                    case 3:
                        //Actualizar cita
                        break;
                    case 4:
                        //Eliminar cita
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            } while (opcion != 5);
        }
    }
}

