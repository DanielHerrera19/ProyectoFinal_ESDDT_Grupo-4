using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    public class NodoReservaCita
    {
        public ReservaCita Reserva { get; set; }
        public NodoReservaCita Siguiente { get; set; }

        public NodoReservaCita(ReservaCita reserva)
        {
            Reserva = reserva;
            Siguiente = null;
        }
    }
}
