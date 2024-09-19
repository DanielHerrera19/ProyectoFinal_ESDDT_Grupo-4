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
                Console.ReadLine();
                Console.Clear();
                confirmacionDePago();
            }


            Console.Write("Mes(MM): ");
            string mesExp = Console.ReadLine();

            Console.Write("Año(YYYY): ");
            string añoExp = Console.ReadLine();

            if (int.TryParse(mesExp, out int mes) && int.TryParse(añoExp, out int año))
            {
                //Validamos el rango del mes
                if (mes < 1 && mes > 12)
                {
                    Console.WriteLine("Mes no válido. Debe estar entre 01 y 12.");
                    return;
                }

                //Obtenemos la fecha actual
                DateTime fechaActual = DateTime.Now;
                int añoActual = fechaActual.Year;
                int mesActual = fechaActual.Month;

                //Vemos la fecha de expiración
                DateTime expiracion = new DateTime(año, mes, DateTime.DaysInMonth(año, mes));

                //Verificamos si la tarjeta ha expirado
                if (año < añoActual || año == añoActual && mes < mesActual)
                {
                    Console.WriteLine("La tarjeta ha expirado.");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Asegúrese de ingresar números.");
            }

            ingresarCvv();
            ingresarDni();


            Console.Clear();
            Console.WriteLine("=========================================\n");
            Console.WriteLine("\n ¡Tu cita ha sido registrada con éxito\n ");
            Console.WriteLine(" \n=========================================\n");
            Console.WriteLine("Presione cualquier tecla para salir...");

            Console.ReadKey();


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
                Console.ReadLine();

               
            }
        }
    }
}
