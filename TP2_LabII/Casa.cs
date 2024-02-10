using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_LabII
{
    [Serializable]
    public class Casa : Propiedad
    {
        public int Camas { get; set; }
        public int MinimoDias { get; set; }
        public bool EsFinde { get; set; }
        public List<Reserva> Reservas { get; set; }

        public Casa(string nombre, string provincia, string localidad, string ubicacion, double precioBase, int camas, int minimoDias, bool esFinde)
    : base(nombre, provincia, localidad, ubicacion, precioBase)
        {
            Camas = camas;
            MinimoDias = minimoDias;
            EsFinde = esFinde;
            //Reservas = new List<Reserva>();
        }

        public double CalcularPrecio(int tiempoEstadia)
        {
            double descuento = 0;
            double precioTotal = PrecioBase;

            if (EsFinde)
            {
                // implementar
            }
            else
            {
                if (tiempoEstadia > MinimoDias)
                {
                    descuento = (tiempoEstadia - MinimoDias) * (0.1 * PrecioBase); 
                }
            }

            precioTotal *= tiempoEstadia;
            precioTotal -= descuento;

            return precioTotal;
        }
        public override string ObtenerNombrePropiedad()
        {
            return $"Casa: {Nombre} ({Camas} camas)";
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre} ");
            sb.AppendLine($"Capacidad: {Camas} ");
            sb.AppendLine($"Precio Base: {PrecioBase:C} ");
            sb.AppendLine($" ");
            sb.AppendLine($"Descripcion:");
            sb.AppendLine($"{Descripcion}");
            return sb.ToString();
        }
    }
}
