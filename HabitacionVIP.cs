using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvualativa_2
{
    public class HabitacionVIP : Reserva
    {
        public decimal TarifaFija {  get; set; }
        private const decimal DescuentoVIP = 0.2m;

        public override decimal CalcularCosto()
        {
            decimal costo = TarifaFija * DuracionEstadia;
            return DuracionEstadia > 5 ? costo * (1 - DescuentoVIP) : costo;
        }
    }



}

