using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_LabII
{
    [Serializable]
    public class Hotel : Propiedad
    {
        public List<Habitacion> Habitaciones { get; set; }
        public int Estrellas { get; set; }
        public List<Reserva> Reservas { get; set; }

        public Hotel(string nombre, string provincia, string localidad, string ubicacion, double precioBase, int estrellas)
            : base(nombre, provincia, localidad, ubicacion, precioBase)
        {
            Estrellas = estrellas;
            Habitaciones = new List<Habitacion>();
            Reservas = new List<Reserva>();
        }
        public void AgregarHabitacion(string tipo)
        {
            Habitaciones.Add(new Habitacion(tipo));
            Habitaciones.Sort((h1, h2) => h1.Numero.CompareTo(h2.Numero));
        }

        public double CalcularPrecio(int tiempoEstadia, int numeroHabitacion)
        {
            double precioTotal = PrecioBase;

            if (Estrellas != 2)
                precioTotal *= 1.4;

            int numero = tiempoEstadia * 2;

            Habitacion habitacion = BuscarHabitacion(numeroHabitacion);

            if (habitacion != null)
            {
                double incremento = habitacion.Incremento();
                precioTotal *= incremento;
            }
            else
            {
                throw new InvalidOperationException("La habitación especificada no está disponible en este hotel.");
            }

            precioTotal *= tiempoEstadia;

            return precioTotal;
        }

        public Habitacion BuscarHabitacion(int numeroHabitacion)
        {
            foreach (Habitacion habitacion in Habitaciones)
            {
                if (habitacion.Numero == numeroHabitacion)
                {
                    return habitacion;
                }
            }
            return null;
        }

        public int ObtenerCapacidadMaximaHabitaciones(int viajeros)
        {
            int capacidadMaxima = 0;

            foreach (Habitacion habitacion in Habitaciones)
            {
                if (viajeros <= 1 && habitacion.Tipo == "Simple")
                {
                    capacidadMaxima = Math.Max(capacidadMaxima, 1); 
                }
                else if (viajeros <= 3 && habitacion.Tipo == "Doble")
                {
                    capacidadMaxima = Math.Max(capacidadMaxima, 3); 
                }
                else if (viajeros <= 5 && habitacion.Tipo == "Triple")
                {
                    capacidadMaxima = Math.Max(capacidadMaxima, 5); 
                }
            }
            return capacidadMaxima;
        }

        public List<int> ObtenerHabitacionesDisponibles()
        {
            List<int> habitacionesDisponibles = new List<int>();

            foreach (Habitacion habitacion in Habitaciones)
            {
                if (habitacion.Disponible)
                {
                    habitacionesDisponibles.Add(habitacion.Numero);
                }
            }

            return habitacionesDisponibles;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre} ");
            sb.AppendLine($"Estrellas: {Estrellas} ");
            sb.AppendLine($"Precio Base: {PrecioBase:C} ");
            sb.AppendLine($" ");
            sb.AppendLine($"Descripcion:");
            sb.AppendLine($"{Descripcion}");
            return sb.ToString();
        }

        public override string ObtenerNombrePropiedad()
        {
            return $"Hotel: {Nombre} (Estrellas: {Estrellas})";
        }
    }
}
