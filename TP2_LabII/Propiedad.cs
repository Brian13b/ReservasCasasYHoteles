using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_LabII
{
    [Serializable]
    public abstract class Propiedad
    {
        private static int ultimoCodigo;
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string Ubicacion { get; set; }
        public double PrecioBase { get; set; }
        public string Descripcion { get; set; }
        public int Codigo { get; set; }
        public List<string> Servicios { get; set; }
        public Image[] listaImagenes {  get; set; }

        protected Propiedad(string nombre, string provincia, string localidad, string ubicacion, double precioBase)
        {
            Nombre = nombre;
            Provincia = provincia;
            Localidad = localidad;
            Ubicacion = ubicacion;
            PrecioBase = precioBase;
            Descripcion = "";
            Servicios = new List<string>();
            listaImagenes = new Image[5];
            Codigo = ++ultimoCodigo;
            GuardarUltimoCodigo(ultimoCodigo);
        }

        static Propiedad()
        {
            ultimoCodigo = ObtenerUltimoCodigo();
        }

        private static int ObtenerUltimoCodigo()
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

        private static void GuardarUltimoCodigo(int codigo)
        {
            string rutaArchivo = "ultimocodigo.txt";

            try
            {
                File.WriteAllText(rutaArchivo, codigo.ToString());
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        public abstract string ObtenerNombrePropiedad();
    }
}
