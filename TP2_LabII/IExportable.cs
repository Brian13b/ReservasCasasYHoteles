using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_LabII
{
    public interface IExportable
    {
        void ExportarClientes(List<Cliente> clientes, string rutaArchivo);
        void ExportarReservas(List<Reserva> reservas);
    }
}
