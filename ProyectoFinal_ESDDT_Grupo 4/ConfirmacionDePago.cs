using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    internal class ConfirmacionDePago
    {
        public static void confirmacionDePago()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|      Confirmación de Reserva     |");
            Console.WriteLine("|----------------------------------|\n");

            
        }   
        public static void ingresarTarjeta()
        {
            Console.WriteLine("Ingrese el número de la tarjeta :");

            string numero = Console.ReadLine();

            //Validamos exactamente 16 dígitos 
            if (numero.Length == 16)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Número de tarjeta no válido. Debe contener exactamente 16 dígitos.");              
                ingresarTarjeta();

                return;
            }
        }
        public static void ingresarMes()
        {
            //Solicitar al usuario que ingrese el mes de vencimiento
            Console.Write("Mes(MM): ");
            string mesExp = Console.ReadLine();

            if(int.TryParse(mesExp, out int mes))
            {
                if (mes >= 1 && mes <= 12)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("El mes ingresado no es válido. Debe estar entre 1 y 12.");
                    ingresarMes();
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
                ingresarMes();
            }
        }
        public static void ingresarAño()
        {
            //Solicitar al usuario que ingrese el año de expiración
            Console.Write("Año(YYYY): ");
            string añoExp = Console.ReadLine();
             
            if (int.TryParse(añoExp, out int año))
            {
                int añoActual = DateTime.Now.Year;

                // Validar que el año sea igual o mayor al actual
                if (año >= añoActual && año <= añoActual + 10)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("El año ingresado no es válido. Debe ser un año futuro razonable.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número de 4 dígitos.");
                ingresarAño();
            }
        }

        public static void ingresarCvv()
        {
            //Solicitar al usuario el CVV            
            Console.WriteLine("Ingrese el CVV de la tarjeta (3 dígitos):");
            string cvv = Console.ReadLine();

            if (cvv.Length == 3 && long.TryParse(cvv, out _))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("CVV no válido. Debe ser un número de 3 dígitos.");
                ingresarCvv();
            }
        }
        public static void ingresarDni()
        {
            Console.WriteLine("Ingrese su DNI: ");
            string dni = Console.ReadLine();

            //Validamos el Dni
            if (dni.Length == 8 && long.TryParse(dni, out _))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("DNI no válido. Debe ser un número de 8 dígitos.");

                ingresarDni();
               
            }

            Console.Clear();
            Console.WriteLine("=========================================\n");
            Console.WriteLine("\n ¡Tu cita ha sido registrada con éxito\n ");
            Console.WriteLine(" \n=========================================\n");
            Console.WriteLine("Presione cualquier tecla para salir...");

            Console.ReadKey();
        }
    }
}
