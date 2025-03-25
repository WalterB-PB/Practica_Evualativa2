using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvualativa_2
{
    public  class HabitacionEstandar : Reserva
    {
        public decimal TarifaFija {  get; set; }


        public override decimal CalcularCosto ()
        {
            if (TarifaFija <= 0)
                throw new ArgumentException("La tarifa debe ser mayor a cero");
            return TarifaFija * DuracionEstadia;

        }

    }
}
