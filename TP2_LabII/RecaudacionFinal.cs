using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_LabII
{
    public class RecaudacionFinal
    {
        Sistema miSistema;
        Recaudacion miRecaudacion;
        public List<Recaudacion> ListaRecaudacion {  get; set; }

        public RecaudacionFinal(Sistema misistema)
        {
            ListaRecaudacion = new List<Recaudacion>();
            miSistema= misistema;
        }

        public void ListarPropiedades()
        {
            foreach (Propiedad p in miSistema.Propiedades)
            {
                string nombre = p.Nombre;
                int cantidad = 0;
                double costo = 0;
                miRecaudacion = new Recaudacion { NombrePropiedad = nombre, CantReservas = cantidad, CostoTotal = costo };

                ListaRecaudacion.Add(miRecaudacion);
            }
        }

        public void CalcularRecaudacionTotal()
        {
            ListaRecaudacion.Clear();

            foreach(Reserva r in miSistema.Reservas)
            {
                Recaudacion recau = BuscarPorCodigoPropiedad(r.Propiedad.Codigo);

                if (recau != null)
                {
                    recau.CostoTotal += r.CostoTotal;
                    recau.CantReservas++;
                }
                else
                {
                    recau = new Recaudacion { Codigo = r.Propiedad.Codigo, NombrePropiedad = r.Propiedad.Nombre, CantReservas = 1 , CostoTotal = r.CostoTotal };
                    ListaRecaudacion.Add(recau);
                }
            }
        }

        public Recaudacion BuscarPorCodigoPropiedad(int codigo)
        {
            Recaudacion buscado = null;

            for( int i = 0; i < ListaRecaudacion.Count && buscado == null; i++)
            {
                if (ListaRecaudacion[i].Codigo == codigo)
                {
                    buscado = ListaRecaudacion[i];
                }
            }
            return buscado;
        }

    }
}
