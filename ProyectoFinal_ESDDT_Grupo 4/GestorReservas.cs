using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    public class GestorReservas
    {
        private NodoReservaCita cabeza;
        private int idCounter = 1;

        public GestorReservas()
        {
            cabeza = null;
        }

        public void CrearReserva(string nombrePaciente, string nombreDoctor, string sede, DateTime fechaHora)
        {
            ReservaCita nuevaReserva = new ReservaCita(idCounter++, nombrePaciente, nombreDoctor, sede, fechaHora);
            NodoReservaCita nuevoNodo = new NodoReservaCita(nuevaReserva);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                NodoReservaCita actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }

            Console.WriteLine("Reserva creada con éxito.");
        }

        public NodoReservaCita ObtenerReservaPorId(int id)
        {
            NodoReservaCita actual = cabeza;
            while (actual != null)
            {
                if (actual.Reserva.Id == id)
                    return actual;
                actual = actual.Siguiente;
            }
            return null;
        }

        public void EliminarReserva(int id)
        {
            if (cabeza == null) return;

            if (cabeza.Reserva.Id == id)
            {
                cabeza = cabeza.Siguiente;
                Console.WriteLine("Reserva eliminada con éxito.");
                return;
            }

            NodoReservaCita actual = cabeza;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Reserva.Id == id)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    Console.WriteLine("Reserva eliminada con éxito.");
                    return;
                }
                actual = actual.Siguiente;
            }

            Console.WriteLine("Reserva no encontrada.");
        }

        public void GenerarReporteReserva(int idReserva)
        {
            NodoReservaCita nodoReserva = ObtenerReservaPorId(idReserva);
            if (nodoReserva != null)
            {
                ReservaCita reserva = nodoReserva.Reserva;
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("            REPORTE DE RESERVA           ");
                Console.WriteLine("=========================================");
                Console.WriteLine($"ID de Reserva: {reserva.Id}");
                Console.WriteLine($"Nombre del Paciente: {reserva.NombrePaciente}");
                Console.WriteLine($"Nombre del Doctor: {reserva.NombreDoctor}");
                Console.WriteLine($"Sede: {reserva.Sede}");
                Console.WriteLine($"Fecha y Hora: {reserva.FechaHora}");
                Console.WriteLine($"Confirmada: {(reserva.Confirmada ? "Sí" : "No")}");
                Console.WriteLine("=========================================");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se encontró la reserva.");
            }
        }

        // Otros métodos CRUD (LeerReservas, ActualizarReserva) se pueden implementar de manera similar.
    }
}
