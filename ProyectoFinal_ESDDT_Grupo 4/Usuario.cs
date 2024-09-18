using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ESDDT_Grupo_4
{
    internal class Usuario
    {
        public int Número;
        public int Mes;
        public int Año;
        public int Cvv;
        public int Dni;
        public Usuario sgte;

        public Usuario(int número, int mes, int año, int cvv, int dni)
        {
            this.Número = número;
            this.Mes = mes;
            this.Año = año;
            this.Cvv = cvv;
            this.Dni = dni;
            sgte = null;
        }
    }
}
