using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvualativa_2
{

    //Constructor de la clase reserva 
    public abstract class Reserva
    {
        public string NombreCliente { get; set; }
        public int NumeroHabitacion { get; set; }
        public DateTime FechaReserva { get; set; }  
        public int DuracionEstadia { get; set; }


        public abstract decimal CalcularCosto();
    }
}
