using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    internal class ReservaDeUsuario
    {
        static void ReservaDeCita(string[] args)
        {
            NodoSede sanJuanDeLurigancho = CrearSedeConDoctores("San Juan de Lurigancho", new string[] { "Dr. Juan Perez", "Dra. Maria Sanchez", "Dr. Julio " });
            NodoSede Magdalena = CrearSedeConDoctores("Magdalena", new string[] { "Dr. Carlos Gomez", "Dra. Ana Lopez" });
            NodoSede Ate = CrearSedeConDoctores("Ate", new string[] { "Dr. Pablo Ramirez", "Dr. Jose Vilchez " });
            NodoSede Comas = CrearSedeConDoctores("Comas", new string[] { "Dra. Julia Rojas", "Dr. Roberto Fernandez" });
            NodoSede Surquillo = CrearSedeConDoctores("Surquillo", new string[] { "Dr. Luis Castro", "Dra. Carmen Rivera" });


            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--------------------------");
                Console.WriteLine("--------- SEDES ----------");
                Console.WriteLine("--------------------------");
                Console.WriteLine("¡Bienvenido!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("- ¿En qué sede desea reservar su cita? : ");
                Console.WriteLine("[1] San Juan de Lurigancho");
                Console.WriteLine("[2] Magdalena ");
                Console.WriteLine("[3] Ate");
                Console.WriteLine("[4] Comas");
                Console.WriteLine("[5] Surquillo");
                Console.WriteLine("[6] SALIR ");


                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        MostrarSede(sanJuanDeLurigancho);
                        break;
                    case "2":
                        MostrarSede(Magdalena);
                        break;
                    case "3":
                        MostrarSede(Ate);
                        break;
                    case "4":
                        MostrarSede(Comas);
                        break;
                    case "5":
                        MostrarSede(Surquillo);
                        break;
                    case "6":
                        salir = true;
                        break;
                }

                Console.ReadLine();
                Console.ReadKey();
            }
            static NodoSede CrearSedeConDoctores(string nombreSede, string[] nombresDoctores)
            {
                NodoSede sede = new NodoSede { Nombre = nombreSede };

                NodoDoctor ultimoDoctor = null;
                foreach (string nombreDoctor in nombresDoctores)
                {
                    NodoDoctor nuevoDoctor = new NodoDoctor
                    {
                        Nombre = nombreDoctor,
                        Especialidad = "Oftalmología",
                        Horarios = new List<Horario>
             {
                 new Horario { DiaSemana = "Lunes", HoraInicio = "8:00 am", HoraFin = "8:45 am", Disponible = true },
                 new Horario { DiaSemana = "Lunes", HoraInicio = "9:00 am", HoraFin = "9:45 am", Disponible = true },
                 new Horario { DiaSemana = "Martes", HoraInicio = "10:00 am", HoraFin = "10:45 am", Disponible = true },
                 new Horario { DiaSemana = "Miercoles", HoraInicio = "12:00 am", HoraFin = "12:45 am", Disponible = true },
                 new Horario { DiaSemana = "Jueves", HoraInicio = "13:00 pm", HoraFin = "13:45 pm", Disponible = true },
                 new Horario { DiaSemana = "Viernes", HoraInicio = "15:00 pm", HoraFin = "15:45 pm", Disponible = true },
             }
                    };

                    if (ultimoDoctor == null)
                    {
                        sede.Doctores = nuevoDoctor;
                    }
                    else
                    {
                        ultimoDoctor.Siguiente = nuevoDoctor;
                    }

                    ultimoDoctor = nuevoDoctor;
                }

                return sede;
            }
        }

    }
}
