using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TP2_LabII
{
    [Serializable]
    public class Reserva
    {
        private static int ultimoNumeroReserva; // Inicializa con 1000 y se irá incrementando

        public string CodigoReserva { get; private set; }
        public DateTime FechaIngreso { get; set; }
        public int TiempoEstadia { get; set; }
        public DateTime FechaEgreso { get; private set; }
        public Propiedad Propiedad { get; set; }
        public Cliente Cliente { get; set; }
        public double CostoTotal { get; private set; }
        public int NumeroHabitacion { get; set; }
        public int CantHuespedes { get; set; }

        public Reserva(DateTime fechaIngreso, DateTime fechaEgreso, Propiedad propiedad, Cliente cliente, int cantHuespedes)
        {
            int minimodias = 0;
            TiempoEstadia = 0;
            if (propiedad is Casa)
            {
                Casa c = (Casa)propiedad;
                minimodias = c.MinimoDias;
            }

            CodigoReserva = GenerarCodigoReserva(propiedad);
            FechaIngreso = fechaIngreso;
            TiempoEstadia = (int)(fechaEgreso - fechaIngreso).TotalDays;
            FechaEgreso = fechaEgreso;
            Propiedad = propiedad;
            Cliente = cliente;
            CantHuespedes = cantHuespedes;
            CalcularCosto(propiedad);

            if (TiempoEstadia < minimodias)
            {
                throw new MisExcepciones("El tiempo de estadía debe ser mayor a " + minimodias);
            }
        }

        public Reserva(DateTime fechaIngreso, DateTime fechaEgreso, Propiedad propiedad, Cliente cliente, int numeroHabitacion, int cantHuespedes)
        {
            this.NumeroHabitacion = numeroHabitacion;
            CodigoReserva = GenerarCodigoReserva(propiedad);
            FechaIngreso = fechaIngreso;
            TiempoEstadia = (int)(fechaEgreso - fechaIngreso).TotalDays;
            FechaEgreso = fechaEgreso;
            Propiedad = propiedad;
            Cliente = cliente;
            CantHuespedes = cantHuespedes;
            CalcularCosto(propiedad);
        }

        static Reserva()
        {
            ultimoNumeroReserva = ObtenerUltimoCodigo();
        }

        public static int ObtenerUltimoCodigo()
        {
            string rutaArchivo = "ultimocodigo.txt";

            if (File.Exists(rutaArchivo))
            {
                try
                {
                    string contenido = File.ReadAllText(rutaArchivo);
                    return int.Parse(contenido);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }

            return 0;
        }

        public static void GuardarUltimoCodigo()
        {
            string rutaArchivo = "ultimocodigo.txt";

            try
            {
                File.WriteAllText(rutaArchivo, ultimoNumeroReserva.ToString());
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private double CalcularCosto(Propiedad propiedad)
        {
            if (propiedad == null)
            {
                throw new InvalidOperationException("La propiedad de la reserva no puede ser nula.");
            }
            else if (propiedad is Hotel)
            {
                CostoTotal = ((Hotel)propiedad).CalcularPrecio(TiempoEstadia, NumeroHabitacion) + (((Hotel)propiedad).CalcularPrecio(TiempoEstadia, NumeroHabitacion) * 0.03);
            }
            else
            {
                CostoTotal = ((Casa)propiedad).CalcularPrecio(TiempoEstadia) + (((Casa)propiedad).CalcularPrecio(TiempoEstadia) * 0.03);
            }

            return CostoTotal;
        }

        private string GenerarCodigoReserva(Propiedad propiedad)
        {
            int numeroReserva = ultimoNumeroReserva;
            ultimoNumeroReserva++;

            if (propiedad is Hotel)
            {
                return "H" + numeroReserva.ToString();
            }
            else if (propiedad is Casa)
            {
                return "C" + numeroReserva.ToString();
            }

            return numeroReserva.ToString();
        }

        public string GenerarComprobante()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Reserva {CodigoReserva} en {Propiedad.ObtenerNombrePropiedad()} para {Cliente.Nombre} {Cliente.Apellido}");
            sb.AppendLine($"Fecha de ingreso: {FechaIngreso:d}");
            sb.AppendLine($"Fecha de egreso: {FechaEgreso:d}");
            sb.AppendLine($"Costo total: {CostoTotal:C}");
            return sb.ToString();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Reserva: {CodigoReserva} - {Propiedad}");
            sb.AppendLine($"Cliente: {Cliente}");
            sb.AppendLine($"Fecha Ingreso/Egreso: {FechaIngreso} - {FechaEgreso}");
            sb.AppendLine($"Costo Total: {CostoTotal:C}");
            return sb.ToString();
        }
    }
}

