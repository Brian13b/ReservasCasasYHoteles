using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_LabII
{
    public partial class FormReserva : Form
    {
        public string Codigo { get; set; }
        Sistema system;
        public FormReserva(Sistema miSistema)
        {
            InitializeComponent();
            system = miSistema;
        }
        Reserva reservaAnular;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Codigo = txtCodigo.Text;
            reservaAnular = system.BuscarReserva(Codigo);
            listBox1.Items.Add(reservaAnular.ToString());
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            system.CancelarReserva(reservaAnular);
        }
    }
}
