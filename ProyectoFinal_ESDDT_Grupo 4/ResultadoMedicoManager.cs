using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    public class ResultadoMedicoManager
    {
        private NodoResultadoMedico cabeza;

        public void AgregarResultadoMedico(string nombrePaciente, string resultado)
        {
            NodoResultadoMedico nuevoResultado = new NodoResultadoMedico
            {
                NombrePaciente = nombrePaciente,
                Resultado = resultado,
                Siguiente = null
            };

            if (cabeza == null)
            {
                cabeza = nuevoResultado; // Si la lista está vacía, el nuevo nodo es la cabeza
            }
            else
            {
                NodoResultadoMedico actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoResultado; // Añadir al final de la lista
            }
        }

        public void MostrarResultadosMedicos()
        {
            if (cabeza == null)
            {
                Console.WriteLine("No hay resultados médicos.");
                return;
            }

            NodoResultadoMedico actual = cabeza;
            while (actual != null)
            {
                Console.WriteLine($"Paciente: {actual.NombrePaciente}, Resultado: {actual.Resultado}");
                actual = actual.Siguiente;
            }
        }

        public void ActualizarResultadoMedico(string nombrePaciente, string nuevoResultado)
        {
            NodoResultadoMedico actual = cabeza;
            while (actual != null)
            {
                if (actual.NombrePaciente == nombrePaciente)
                {
                    actual.Resultado = nuevoResultado;
                    Console.WriteLine("Resultado médico actualizado.");
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine("Paciente no encontrado.");
        }

        public void EliminarResultadoMedico(string nombrePaciente)
        {
            NodoResultadoMedico actual = cabeza;
            NodoResultadoMedico anterior = null;

            while (actual != null)
            {
                if (actual.NombrePaciente == nombrePaciente)
                {
                    if (anterior == null)
                    {
                        cabeza = actual.Siguiente; // Eliminar el primer nodo
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente; // Eliminar el nodo intermedio
                    }
                    Console.WriteLine("Resultado médico eliminado.");
                    return;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
            Console.WriteLine("Paciente no encontrado.");
        }
    }
}
