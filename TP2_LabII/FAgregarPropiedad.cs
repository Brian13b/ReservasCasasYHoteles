using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP2_LabII
{
    public partial class FAgregarPropiedad : Form
    {
        Sistema miSistema;
        public Propiedad p;
        public FAgregarPropiedad(Sistema miSistema)
        {
            InitializeComponent();
            this.miSistema = miSistema;
        }
        int codigo;

        public string[] rutasArchivos= new string [5];

        private void btnAdjuntarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    if (openFileDialog1.FileNames.Length < 6)
                    {
                        rutasArchivos = openFileDialog1.FileNames;
                    }
                    else
                        throw new MisExcepciones ("Debe seleccionar hasta 5 imagenes");
                }
                catch(MisExcepciones ex)
                {
                    MessageBox.Show(ex.Message);
                }              
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(txtCodigo.Text);

            p = miSistema.BuscarPropiedad(codigo);

            txtNombre.Text = p.Nombre;
            txtProvincia.Text = p.Provincia;
            txtLocalidad.Text = p.Localidad;
            txtUbicacion.Text = p.Ubicacion;
            txtPrecioBase.Text = Convert.ToString(p.PrecioBase);
            txtDescripcion.Text = p.Descripcion;
        }
    }
}
