using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    public class ReservaCita
    {
        public int Id { get; set; }
        public string NombrePaciente { get; set; }
        public string NombreDoctor { get; set; }
        public string Sede { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Confirmada { get; set; }

        public ReservaCita(int id, string nombrePaciente, string nombreDoctor, string sede, DateTime fechaHora)
        {
            Id = id;
            NombrePaciente = nombrePaciente;
            NombreDoctor = nombreDoctor;
            Sede = sede;
            FechaHora = fechaHora;
            Confirmada = false;
        }
    }

}
