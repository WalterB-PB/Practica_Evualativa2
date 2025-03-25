using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvualativa_2
{
    public static class ReservaFactory
    {
        public static Reserva CrearReserva(string tipoHabitacion)
        {
            switch (tipoHabitacion.ToLower())
            {
                case "estandar":
                    return new HabitacionEstandar();
                case "vip":
                    return new HabitacionVIP();
                default:
                    throw new ArgumentException("Tipo de habitación no válido");
            }
        }
    }
}

    