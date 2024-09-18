using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    internal class ReservaDeUsuario
    {
        public static void ReservaDeCita(string[] args)
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
        }


        static void MostrarSede(NodoSede sede)
        {
            Console.Clear();
            Console.WriteLine("Sede seleccionada: " + sede.Nombre);
            Console.WriteLine("Doctores disponibles:");

            NodoDoctor doctorActual = sede.Doctores;
            if (doctorActual == null)
            {
                Console.WriteLine("No hay doctores asignados a esta sede.");
            }
            else
            {
                int doctorCount = 1;
                while (doctorActual != null)
                {
                    Console.WriteLine("[" + doctorCount + "] " + doctorActual.Nombre + " (Especialidad: " + doctorActual.Especialidad + ")");
                    doctorActual = doctorActual.Siguiente;
                    doctorCount++;
                }

                Console.WriteLine("Seleccione un doctor (o 0 para cancelar):");
                string opcion = Console.ReadLine();
                int doctorSeleccionado;

                if (int.TryParse(opcion, out doctorSeleccionado) && doctorSeleccionado > 0 && doctorSeleccionado <= doctorCount)
                {
                    doctorActual = sede.Doctores;
                    for (int i = 1; i < doctorSeleccionado; i++)
                    {
                        doctorActual = doctorActual.Siguiente;
                    }

                    MostrarHorarios(doctorActual);
                }
                else
                {
                    Console.WriteLine("Selección cancelada.");
                }
            }

            Console.WriteLine("Presione Enter para regresar al menú principal...");
        }
        public static void MostrarHorarios(NodoDoctor doctor)
        {
            Console.Clear();
            Console.WriteLine("Horarios disponibles para " + doctor.Nombre + ":");
            for (int i = 0; i < doctor.Horarios.Count; i++)
            {
                if (doctor.Horarios[i].Disponible)
                {
                    Console.WriteLine("[" + (i + 1) + "] " + doctor.Horarios[i].DiaSemana + " de " + doctor.Horarios[i].HoraInicio + " a " + doctor.Horarios[i].HoraFin);
                }
            }

            Console.WriteLine("Seleccione un horario para reservar (o 0 para cancelar):");
            string opcion = Console.ReadLine();
            int horarioSeleccionado;

            if (int.TryParse(opcion, out horarioSeleccionado) && horarioSeleccionado > 0 && horarioSeleccionado <= doctor.Horarios.Count)
            {
                if (doctor.Horarios[horarioSeleccionado - 1].Disponible)
                {
                    doctor.Horarios[horarioSeleccionado - 1].Disponible = false;  // Marcar el horario como ocupado
                    Console.WriteLine("Cita reservada exitosamente.");
                }
                else
                {
                    Console.WriteLine("El horario ya está ocupado.");
                }
            }
            else
            {
                Console.WriteLine("Reserva cancelada.");
            }
        }
    }
}
