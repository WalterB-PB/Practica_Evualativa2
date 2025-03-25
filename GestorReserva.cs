using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEvualativa_2
{
    public sealed class GestorReservas
    {
        private static GestorReservas _instancia;
        private List<Reserva> _reservas;

        private GestorReservas()
        {
            _reservas = new List<Reserva>();
        }

        public static GestorReservas Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new GestorReservas();
                }
                return _instancia;
            }
        }

        public void AgregarReserva(Reserva reserva)
        {
            // Validar reglas de negocio antes de agregar
            if (string.IsNullOrEmpty(reserva.NombreCliente))
            {
                throw new ArgumentException("El nombre del cliente es obligatorio");
            }

            if (reserva.FechaReserva == default(DateTime))
            {
                throw new ArgumentException("La fecha de reserva es obligatoria");
            }

            if (reserva.DuracionEstadia <= 0)
            {
                throw new ArgumentException("La duración debe ser mayor a 0 noches");
            }

            if (reserva is HabitacionEstandar estandar && estandar.TarifaFija <= 0)
            {
                throw new ArgumentException("La tarifa debe ser mayor a cero");
            }

            if (_reservas.Any(r => r.NumeroHabitacion == reserva.NumeroHabitacion &&
                                  r.FechaReserva.Date == reserva.FechaReserva.Date))
            {
                throw new ArgumentException("Ya existe una reserva para esta habitación en la fecha indicada");
            }

            _reservas.Add(reserva);
        }

        public bool EditarReserva(int index, Reserva nuevaReserva)
        {
            try
            {
                if (index >= 0 && index < _reservas.Count)
                {
                    _reservas[index] = nuevaReserva;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarReserva(int index)
        {
            try
            {
                if (index >= 0 && index < _reservas.Count)
                {
                    _reservas.RemoveAt(index);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public List<Reserva> ListarReservas()
        {
            return new List<Reserva>(_reservas);
        }

        public Reserva ObtenerReserva(int index)
        {
            if (index >= 0 && index < _reservas.Count)
            {
                return _reservas[index];
            }
            return null;
        }
    }
}