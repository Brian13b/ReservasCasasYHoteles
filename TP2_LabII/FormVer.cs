using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TP2_LabII
{
    public partial class FormVer : Form
    {
        
        public int Cantidad { set; get; }
        public string[] huespedes;
        public FormVer()
        {
            InitializeComponent();
        }

        public Image[] imagenesAuxiliares = new Image[5];
        int i = 1;
        int contador = 0;

        private void FormVer_Load(object sender, EventArgs e)
        {
            pbImagen.Image = imagenesAuxiliares[0];
            btnAnt.Enabled = false;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (i < imagenesAuxiliares.Length - 1)
            {
                i++;
                pbImagen.Image = imagenesAuxiliares[i];
                btnAnt.Enabled = true;
            }
            else
                btnSig.Enabled = false;
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {

            if (i > 0)
            {
                i--;
                pbImagen.Image = imagenesAuxiliares[i];
                btnSig.Enabled = true;
            }
            else
                btnAnt.Enabled = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string nombreApellido = txtNombreApellido.Text;
            string dni = txtDni.Text;
            string nacimiento = Convert.ToString((dtpNacimiento.Value).ToString());

            huespedes[contador] = nombreApellido + ";" + dni + ";" + nacimiento;
            contador++;
            txtNombreApellido.Clear();
            txtDni.Clear();
        }

        private void tbCantidad_Leave(object sender, EventArgs e)
        {
            Cantidad = Convert.ToInt32(tbCantidad.Text);
            huespedes = new string[Cantidad];
        }
    }
}
