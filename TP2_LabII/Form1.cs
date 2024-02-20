using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace TP2_LabII
{
    public partial class Form1 : Form
    {
        private Cliente cliente;
        public Sistema miSistema;

        private int nroPag=0;
        Image imfondo;
        Bitmap imlogo;
        string ResumenPropiedad;
        string[] huesped;

        public Form1()
        {
            InitializeComponent();
        }

        #region Botones

        string archivoInicial = Application.StartupPath + "\\sistema.bin";
        BinaryFormatter datosBinarios = new BinaryFormatter();

        private void Form1_Load_1(object sender, EventArgs e)
        {
            FileStream fs = null;

            try
            {
                if (File.Exists(archivoInicial))
                {
                    fs = new FileStream(archivoInicial, FileMode.Open, FileAccess.Read);
                    miSistema = (Sistema)datosBinarios.Deserialize(fs);
                }
                else
                    miSistema = new Sistema();

                MostrarVentanaIngreso();
                PersonalizarInterfaz();
                CargarDatagrid();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //string rutaArchivo = Application.StartupPath + "\\clientes.txt";
            FileStream fs = null;

            if (File.Exists(archivoInicial))
                File.Delete(archivoInicial);

            try
            {
                fs = new FileStream(archivoInicial, FileMode.CreateNew, FileAccess.Write);
                datosBinarios.Serialize(fs, miSistema);
                //miSistema.ExportarClientes(miSistema.Clientes, rutaArchivo);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void cargaPropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAgregarPropiedad vAdmin = new FAgregarPropiedad(miSistema);

            if (vAdmin.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombre = vAdmin.txtNombre.Text;
                    string provincia = vAdmin.txtProvincia.Text;
                    string localidad = vAdmin.txtLocalidad.Text;
                    string ubicacion = vAdmin.txtUbicacion.Text;
                    double precioBase = Convert.ToDouble(vAdmin.txtPrecioBase.Text);

                    if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(provincia) || string.IsNullOrEmpty(localidad) || string.IsNullOrEmpty(ubicacion))
                    {
                        MessageBox.Show("Por favor, complete todos los campos requeridos.");
                        return;
                    }

                    Propiedad nuevaPropiedad = null;

                    if (vAdmin.rbHotel.Checked)
                    {
                        int estrellas = Convert.ToInt16(vAdmin.numEstrellas.Value);
                        nuevaPropiedad = new Hotel(nombre, provincia, localidad, ubicacion, precioBase, estrellas);

                        if (nuevaPropiedad is Hotel)
                        {
                            int cantidadS = Convert.ToInt32(vAdmin.numSimple.Value);
                            int cantidadD = Convert.ToInt32(vAdmin.numDoble.Value);
                            int cantidadT = Convert.ToInt32(vAdmin.numTriple.Value);

                            Hotel nuevoHotel = (Hotel)nuevaPropiedad;
                            for (int i = 0; i < cantidadS; i++)
                            {
                                nuevoHotel.AgregarHabitacion("Simple");
                            }

                            for (int i = 0; i < cantidadD; i++)
                            {
                                nuevoHotel.AgregarHabitacion("Doble");
                            }

                            for (int i = 0; i < cantidadT; i++)
                            {
                                nuevoHotel.AgregarHabitacion("Triple");
                            }

                            if (vAdmin.chbCochera.Checked) nuevoHotel.Servicios.Add("Cochera");
                            if (vAdmin.chbDesayuno.Checked) nuevoHotel.Servicios.Add("Desayuno");
                            if (vAdmin.chbLimpieza.Checked) nuevoHotel.Servicios.Add("Limpieza");
                            if (vAdmin.chbMascotas.Checked) nuevoHotel.Servicios.Add("Mascotas");
                            if (vAdmin.chbPileta.Checked) nuevoHotel.Servicios.Add("Pileta");
                            if (vAdmin.chbWifi.Checked) nuevoHotel.Servicios.Add("Wi-Fi");

                            nuevoHotel.Descripcion = vAdmin.txtDescripcion.Text;

                            for (int i = 0; i < vAdmin.rutasArchivos.Length; i++)
                            {
                                Image imagen = Image.FromFile(vAdmin.rutasArchivos[i]);
                                nuevaPropiedad.listaImagenes[i] = imagen;
                            }
                        }
                    }
                    else if (vAdmin.rbCasa.Checked)
                    {
                        int maxPersonas = Convert.ToInt32(vAdmin.txtMaxPersonas.Text); //Seria lo mismo que camas.
                        int minDias = Convert.ToInt32(vAdmin.numDiasMinimos.Value);
                        bool esFindeSemana = false;
                        if (vAdmin.chbFinde.Checked)
                            esFindeSemana = true;

                        nuevaPropiedad = new Casa(nombre, provincia, localidad, ubicacion, precioBase, maxPersonas, minDias, esFindeSemana);

                        if (vAdmin.chbCochera.Checked) nuevaPropiedad.Servicios.Add("Cochera");
                        if (vAdmin.chbDesayuno.Checked) nuevaPropiedad.Servicios.Add("Desayuno");
                        if (vAdmin.chbLimpieza.Checked) nuevaPropiedad.Servicios.Add("Limpieza");
                        if (vAdmin.chbMascotas.Checked) nuevaPropiedad.Servicios.Add("Mascotas");
                        if (vAdmin.chbPileta.Checked) nuevaPropiedad.Servicios.Add("Pileta");
                        if (vAdmin.chbWifi.Checked) nuevaPropiedad.Servicios.Add("Wi-Fi");

                        nuevaPropiedad.Descripcion = vAdmin.txtDescripcion.Text;

                        for (int i = 0; i < vAdmin.rutasArchivos.Length; i++)
                        {
                            Image imagen = Image.FromFile(vAdmin.rutasArchivos[i]);
                            nuevaPropiedad.listaImagenes[i] = imagen;
                        }

                    }

                    if (nuevaPropiedad != null)
                    {
                        miSistema.AgregarPropiedad(nuevaPropiedad);
                        MessageBox.Show("Propiedad registrada con éxito.");
                        CargarDatagrid();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione el tipo de propiedad (Hotel o Casa).");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("formato no valido, procure ingresar los campos correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la propiedad: " + ex.Message);
                }
            }
        }  // Alta Propiedad

        private void dgvMostrarPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMostrarPropiedades.Columns["colVerMas"].Index)
            {
                MostrarVentanaVerMas(e.RowIndex);
            }
        }  // Boton Ver Mas 

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioIngreso vIngreso = new FormularioIngreso();
            vIngreso.groupBox1.Visible = false;
            vIngreso.groupBox2.Visible = true;

            if (vIngreso.ShowDialog() == DialogResult.Yes)
            {
                string nombre = vIngreso.txtNombreRegistro.Text;
                string apellido = vIngreso.txtApellidoRegistro.Text;
                string correoElectronico = vIngreso.txtCorreo.Text;
                int dni = Convert.ToInt32(vIngreso.txtDni.Text);
                string contraseña = vIngreso.txtContraseñar.Text;
                string usuario = vIngreso.txtusuarior.Text;

                cliente = new Cliente(nombre, apellido, dni, correoElectronico, contraseña, usuario);

                miSistema.Clientes.Add(cliente);

                MessageBox.Show("Cliente registrado con éxito.");
            }
        } // Agrega un nuevo Usuario

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (nroPag >= 2)
            {
                nroPag = 0;
            }
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resource", "Logo.png");
            imlogo = new Bitmap(ruta);
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            Brush brush = new SolidBrush(Color.Black);

            int margenDerecho = 100;
            int margenSuperior = 250;

            int anchoImagen = 200;
            int altoImagen = 200;

            int xImagen = e.PageBounds.Width - anchoImagen - 50;
            int yImagen = 40;

            int anchoContenido = e.PageBounds.Width - margenDerecho * 2;
            int altoContenido = e.PageBounds.Height - margenSuperior * 2;

            Pen penContenido = new Pen(Color.Black, 2);
            if (nroPag < 2)
            {
                if (nroPag == 0)
                {
                    // Página 1
                    g.DrawImage(imlogo, xImagen - 500, yImagen, anchoImagen, altoImagen);
                    g.DrawImage(imfondo, xImagen, yImagen, anchoImagen, altoImagen);
                    g.DrawRectangle(penContenido, margenDerecho, margenSuperior, anchoContenido, altoContenido);
                    g.DrawString(ResumenPropiedad, font, brush, new RectangleF(margenDerecho + 10, margenSuperior + 10, anchoContenido + 10, altoContenido + 10));
                    g.DrawString("Original", font, brush, 30, 30);
                    int contayuday = 400;
                    int contayudax = margenDerecho + 10;
                    for (int i = 0; i < huesped.Length; i++)
                    {
                        string nombre;
                        string dni;
                        string nacimiento;
                        string[] dato = new string[3];

                        dato = huesped[i].Split(';');

                        nombre = dato[0];
                        dni = dato[1];
                        nacimiento = dato[2];
                        g.DrawString(nombre, font, brush, contayudax, contayuday);
                        g.DrawString(dni, font, brush, contayudax + 300, contayuday);
                        g.DrawString(nacimiento, font, brush, contayudax + 400, contayuday);
                        contayuday += 50;
                    }

                }
                else if (nroPag == 1)
                {
                    // Página 2
                    g.DrawImage(imlogo, xImagen - 500, yImagen, anchoImagen, altoImagen);
                    g.DrawImage(imfondo, xImagen, yImagen, anchoImagen, altoImagen);
                    g.DrawRectangle(penContenido, margenDerecho, margenSuperior, anchoContenido, altoContenido);
                    g.DrawString(ResumenPropiedad, font, brush, new RectangleF(margenDerecho + 10, margenSuperior + 10, anchoContenido + 10, altoContenido + 10));
                    g.DrawString("Copia", font, brush, 30, 30);
                    int contayuday = 400;
                    int contayudax = margenDerecho + 10;
                    for (int i = 0; i < huesped.Length; i++)
                    {
                        string nombre;
                        string dni;
                        string nacimiento;
                        string[] dato = new string[3];

                        dato = huesped[i].Split(';');

                        nombre = dato[0];
                        dni = dato[1];
                        nacimiento = dato[2];
                        g.DrawString(nombre, font, brush, contayudax, contayuday);
                        g.DrawString(dni, font, brush, contayudax + 300, contayuday);
                        g.DrawString(nacimiento, font, brush, contayudax + 400, contayuday);
                        contayuday += 50;
                    }
                }

                nroPag++;
            }
            else
            {
                nroPag = 0;
            }

            // Indica si hay más páginas
            e.HasMorePages = nroPag < 2;


            font.Dispose();
            brush.Dispose();
            penContenido.Dispose();
        }  // Imprimible 

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ciudad = cbCiudad.SelectedItem.ToString();

            DateTime desde = dtDesde.Value;
            DateTime hasta = dtHasta.Value;

            string tipo = "";
            bool esFinde = false;

            int viajeros = Convert.ToInt32(numViajeros.Value);

            if (rbCasa.Checked)
                tipo = "Casa";
            else if (rbHotel.Checked)
                tipo = "Hotel";
            else if (rbCasaFinde.Checked)
            {
                tipo = "Casa";
                esFinde = true;
            }

            List<Propiedad> propiedadesFiltradas = miSistema.FiltrarPropiedades(ciudad, desde, hasta, viajeros, tipo, esFinde);

            MostarPropiedadesEnDGV(propiedadesFiltradas);
        }  // Filtra

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            cbCiudad.SelectedIndex = 0;
            dtDesde.Value = DateTime.Now;
            dtHasta.Value = DateTime.Now;
            numViajeros.Value = 1;
            rbCasa.Checked = false;
            rbHotel.Checked = false;
            rbCasaFinde.Checked = false;

            CargarDatagrid();
        } // Limpia y muestra

        private void modificarPropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAgregarPropiedad vModificar = new FAgregarPropiedad(miSistema);
            vModificar.label4.Visible = true;
            vModificar.txtCodigo.Visible = true;
            vModificar.btnBuscar.Visible = true;

            if (vModificar.ShowDialog() == DialogResult.OK)
            {
                Propiedad p = vModificar.p;

                p.Nombre = vModificar.txtNombre.Text;
                p.Provincia = vModificar.txtProvincia.Text;
                p.Localidad = vModificar.txtLocalidad.Text;
                p.Ubicacion = vModificar.txtUbicacion.Text;
                p.PrecioBase = Convert.ToDouble(vModificar.txtPrecioBase.Text);
                p.Descripcion = vModificar.txtDescripcion.Text;
            }

            CargarDatagrid();
        }  // Modificar Propiedad 

        private void bajaPropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show($"Seleccione la propiedad a eliminar antes de ingresar a 'Baja propidad. ¿Ya selecciono la propiedad?", "Seleccion confirmar", MessageBoxButtons.YesNo);
            DataGridViewRow selectedRow = dgvMostrarPropiedades.CurrentRow;

            if (resultado == DialogResult.Yes)
            {
                string codigoPropiedad = selectedRow.Cells["colCodigo"].Value.ToString();
                Propiedad propiedadSeleccionada = null;

                foreach (Propiedad propiedad in miSistema.Propiedades)
                {
                    if (propiedad.Codigo.ToString() == codigoPropiedad)
                    {
                        propiedadSeleccionada = propiedad;
                    }
                }

                if (propiedadSeleccionada != null)
                {
                    DialogResult result = MessageBox.Show($"¿Estás seguro de dar de baja la propiedad {propiedadSeleccionada.Nombre}?", "Confirmar baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        miSistema.BajaPropiedad(propiedadSeleccionada);
                        CargarDatagrid();

                        MessageBox.Show("Propiedad dada de baja exitosamente");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la propiedad correspondiente al código seleccionado");
                }
            }
        }  // Baja propiedad 

        private void anularReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReserva ventAnular = new FormReserva(miSistema);

            if (ventAnular.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se cancelo cheto bb");
            }
        }  // Anular Reserva 

        private void ExportarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto|*.txt|Archivo CSV|*.csv";
            saveFileDialog.Title = "Guardar clientes en archivo de texto";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;
                miSistema.ExportarClientes(miSistema.Clientes, rutaArchivo);
            }
        } // Exportar clientes

        private void exportarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miSistema.ExportarReservas(miSistema.Reservas);
        } // Exportar reservas 

        private void guardarCalendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                FormCSV FExportar = new FormCSV();
                foreach (Propiedad p in miSistema.Propiedades)
                {
                    FExportar.cbPropiedades.Items.Add(p.Nombre.ToString());

                }

                if (FExportar.ShowDialog() == DialogResult.OK)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivo CSV|*.csv";
                    saveFileDialog.Title = "Guardar calendario";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        path = saveFileDialog.FileName;
                        string nombrePropiedad = FExportar.cbPropiedades.Text;
                        miSistema.ExportarCalendario(nombrePropiedad, path);
                    }
                }

                else if (FExportar.ShowDialog() == DialogResult.Yes)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Archivo CSV|*.csv";
                    openFileDialog.Title = "Imprtar calendario";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        path = openFileDialog.FileName;
                        string nombrePropiedad = FExportar.cbPropiedades.Text;
                        miSistema.ImportarCalendario(path);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.StackTrace);
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaArchivoHTML = Application.StartupPath + "\\Ayuda\\ayuda.html";

            try
            {
                System.Diagnostics.Process.Start(rutaArchivoHTML);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo HTML: " + ex.Message);
            }
        } // Ventana ayuda

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Opacity = 0;
            acercaDe.StartPosition = FormStartPosition.CenterParent;
            acercaDe.timer1.Enabled = true;
            acercaDe.ShowDialog();
            acercaDe.Dispose();
        } // Ventana Acerca de 

        private void cantidadDeReservasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormEstadisticas miEstadistica = new FormEstadisticas();
            miEstadistica.panel2.Visible = false;
            miEstadistica.panel1.Visible = true;
            miEstadistica.Load += (s, args) =>
            {
                Panel panelGrafico = miEstadistica.panel1; 

                panelGrafico.Paint += (senderPanel, argsPanel) =>
                {
                    Graphics dibujar = argsPanel.Graphics;
                    Brush brush = new SolidBrush(Color.Black);
                    Color colores = new Color();
                    Font font = new Font("Arial", 15, FontStyle.Underline);
                    Random random = new Random();

                    dibujar.DrawString("Porcentaje de reservas y tipo de alojamiento.", font, brush, 370, 50);

                    int posicion = 0;
                    int cuadradoY = 100;
                    int totalReservasCasas = 0;
                    int totalReservasHoteles = 0;
                    int totalReservasFindes = 0;
                    int totalReservas = 0;

                    foreach (Reserva b in miSistema.Reservas)
                    {
                        if (b.Propiedad is Casa)
                        {
                            if (((Casa)b.Propiedad).EsFinde)
                            {
                                totalReservasFindes++;
                            }
                            else
                            {
                                totalReservasCasas++;
                            }

                        }
                        if (b.Propiedad is Hotel)
                        {
                            totalReservasHoteles++;
                        }
                    }

                    totalReservas = totalReservasCasas + totalReservasHoteles + totalReservasFindes;

                    // Porcion Casas
                    colores = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    brush = new SolidBrush(colores);
                    int movimientoC = (totalReservasCasas * 360) / totalReservas;
                    dibujar.FillPie(brush, 50, 80, 300, 300, posicion, movimientoC);
                    posicion += movimientoC;

                    double porcentaje = (double)(totalReservasCasas * 100) / totalReservas;

                    font = new Font("Arial", 15);
                    dibujar.FillRectangle(brush, new System.Drawing.RectangleF(400, cuadradoY, 25, 25));
                    string texto = $"% {porcentaje:f2} Casas";
                    dibujar.DrawString(texto, font, brush, 430, cuadradoY);
                    cuadradoY += 35;

                    // Porcion Hoteles
                    colores = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    brush = new SolidBrush(colores);
                    int movimientoH = (totalReservasHoteles * 360) / totalReservas;
                    dibujar.FillPie(brush, 50, 80, 300, 300, posicion, movimientoH);
                    posicion += movimientoH;

                    porcentaje = (double)(totalReservasHoteles * 100) / totalReservas;

                    font = new Font("Arial", 15);
                    dibujar.FillRectangle(brush, new System.Drawing.RectangleF(400, cuadradoY, 25, 25));
                    texto = $"% {porcentaje:f2} Hotel";
                    dibujar.DrawString(texto, font, brush, 430, cuadradoY);
                    cuadradoY += 35;

                    // Porcion Casas Finde
                    colores = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    brush = new SolidBrush(colores);
                    int movimientoCF = (totalReservasFindes * 360) / totalReservas;
                    dibujar.FillPie(brush, 50, 80, 300, 300, posicion, movimientoCF);
                    posicion += movimientoCF;

                    porcentaje = (double)(totalReservasFindes * 100) / totalReservas;

                    font = new Font("Arial", 15);
                    dibujar.FillRectangle(brush, new System.Drawing.RectangleF(400, cuadradoY, 25, 25));
                    texto = $"% {porcentaje:f2} Casas Fin de Semana";
                    dibujar.DrawString(texto, font, brush, 430, cuadradoY);
                    cuadradoY += 35;
                };

                // Invalidar el panel para que se dispare el evento Paint
                panelGrafico.Invalidate();
            };
            miEstadistica.ShowDialog();
        }    // Grafico de torta 

        private void cantidadDeHuespedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormEstadisticas miEstadistica1 = new FormEstadisticas();
            miEstadistica1.panel1.Visible = false;
            miEstadistica1.panel2.Visible = true;

            miEstadistica1.Load += (s, args) =>
            {
                
                Panel panelGrafico = miEstadistica1.panel2; 

                panelGrafico.Paint += (senderPanel, argsPanel) =>
                {

                    Graphics dibujar = argsPanel.Graphics;
                    Brush brushTitulo = new SolidBrush(Color.Black);
                    Brush brush = new SolidBrush(Color.Black);
                    Font fontTitulo = new Font("Arial", 15, FontStyle.Underline);
                    Font font = new Font("Arial", 14);
                    Color colores = new Color();
                    Random random = new Random();

                    dibujar.DrawString("Porcentaje de reservas segun cantidad de huespedes.", fontTitulo, brushTitulo, 200, 60);

                    int posX = 180;
                    int posY = 130;
                    int largo = 1000;
                    int ancho = 30;

                    int[] h = new int[5];
                    int reservasTotales = miSistema.Reservas.Count;

                    foreach (Reserva r in miSistema.Reservas)
                    {
                        if (r.CantHuespedes == 1)
                        {
                            h[0] += 1;
                        }
                        if (r.CantHuespedes == 2)
                        {
                            h[1] += 1;
                        }
                        if (r.CantHuespedes == 3)
                        {
                            h[2] += 1;
                        }
                        if (r.CantHuespedes == 4)
                        {
                            h[3] += 1;
                        }
                        if (r.CantHuespedes == 5)
                        {
                            h[4] += 1;
                        }
                        if (r.CantHuespedes >= 6)
                        {
                            h[5] += 1;
                        }
                    }

                    for (int i = 0; i < h.Length; i++)
                    {
                        colores = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                        brush = new SolidBrush(colores);

                        int largoFinal = (h[i] * largo) / reservasTotales;
                        dibujar.FillRectangle(brush, posX + 30, posY, largoFinal, ancho);
                        string texto = "%" + h[i] * 100 / reservasTotales + " de reservas totales.";
                        dibujar.DrawString(texto, font, brushTitulo, posX + 30, posY + 5);
                        dibujar.DrawString("Huespedes: " + (i + 1), font, brushTitulo, posX - 130, posY + 6);
                        posY += 50;
                    }
                    
                };
                panelGrafico.Invalidate();
            };
            miEstadistica1.ShowDialog();



        }  // Grafico de barras 

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        } // Boton Salir 

        #endregion

        #region Metodos

        private void PersonalizarInterfaz()
        {
            if (cliente != null)
            {
                lblNombreCliente.Text = $"Bienvenido {cliente.Apellido}, {cliente.Nombre}";
            }
            else
            {
                lblNombreCliente.Text = "No se ha identificado al cliente.";
            }
        }

        private void MostrarVentanaIngreso()
        {
            //miSistema.ImportarClientes();
            FormularioIngreso vIngreso = new FormularioIngreso();
            vIngreso.StartPosition = FormStartPosition.CenterParent;
            vIngreso.Width = 365;
            vIngreso.groupBox1.Visible = true;
            vIngreso.btnIngresar.Visible = true;

            if (vIngreso.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(vIngreso.txtUsuario.Text) || string.IsNullOrEmpty(vIngreso.txtContraseña.Text))
                {
                    throw new Exception("Por favor, ingrese usuario y contraseña.");
                }
                else
                {
                    foreach (Cliente c in miSistema.Clientes)
                    {
                        if (c.Usuario == vIngreso.txtUsuario.Text && c.Contraseña == vIngreso.txtContraseña.Text)
                        {
                            if (c.Usuario != "admin")
                            {
                                edicionToolStripMenuItem.Enabled = false;
                                nuevoToolStripMenuItem.Enabled = false;
                                if (c.Usuario != "empleado")
                                {
                                    ExportarClientesToolStripMenuItem.Enabled = false;
                                }
                            }
                            MessageBox.Show($"Cliente encontrado. {c.Nombre} {c.Apellido}");
                            cliente = c;
                        }
                        else
                        {
                            vIngreso.lblMensaje.Text = "Cliente no encontrado. Por favor complete el formulario de registro.";
                        }
                    }
                }
            }
        }

        private void CargarDatagrid()
        {
            dgvMostrarPropiedades.Rows.Clear();

            dgvMostrarPropiedades.ColumnCount = 7;
            dgvMostrarPropiedades.RowCount = miSistema.Propiedades.Count;
            dgvMostrarPropiedades.RowHeadersVisible = false;
            int nuevaAltura = 50;
            foreach (DataGridViewRow fila in dgvMostrarPropiedades.Rows)
            {
                fila.Height = nuevaAltura;
            }

            int cont = 0;

            foreach (Propiedad p in miSistema.Propiedades)
            {
                dgvMostrarPropiedades.Rows[cont].Cells["colCodigo"].Value = p.Codigo;
                dgvMostrarPropiedades.Rows[cont].Cells["colTipo"].Value = p.GetType().Name;
                dgvMostrarPropiedades.Rows[cont].Cells["colNombre"].Value = p.Nombre;
                dgvMostrarPropiedades.Rows[cont].Cells["colUbicacion"].Value = p.Localidad + " - " + p.Provincia;
                dgvMostrarPropiedades.Rows[cont].Cells["colPrecio"].Value = p.PrecioBase;
                dgvMostrarPropiedades.Rows[cont].Cells["colImagen"].Value = p.listaImagenes[0];

                cont++;
            }

            List<string> provincias = new List<string>();
            List<string> ciudades = new List<string>();

            foreach (Propiedad p in miSistema.Propiedades)
            {
                if (!provincias.Contains(p.Provincia))
                {
                    provincias.Add(p.Provincia);
                }

                ciudades.Add(p.Provincia + ";" + p.Localidad);
            }

            cbCiudad.Items.Clear();

            foreach (string provincia in provincias)
            {
                cbCiudad.Items.Add("--" + provincia);

                foreach (string ciudad in ciudades)
                {
                    if (ciudad != provincia && ciudad.StartsWith(provincia))
                    {
                        string[] partes = ciudad.Split(';');
                        string nombreCiudad;

                        if (partes.Length > 1)
                        {
                            nombreCiudad = partes[1].Trim();
                        }
                        else
                        {
                            nombreCiudad = ciudad;
                        }

                        cbCiudad.Items.Add($"{nombreCiudad}");
                    }
                }
            }
        }

        private void MostarPropiedadesEnDGV(List<Propiedad> propiedades)
        {
            dgvMostrarPropiedades.Rows.Clear();

            dgvMostrarPropiedades.ColumnCount = 7;
            dgvMostrarPropiedades.RowCount = propiedades.Count;
            dgvMostrarPropiedades.RowHeadersVisible = false;
            int nuevaAltura = 50;
            foreach (DataGridViewRow fila in dgvMostrarPropiedades.Rows)
            {
                fila.Height = nuevaAltura;
            }

            int cont = 0;

            foreach (Propiedad p in propiedades)
            {
                dgvMostrarPropiedades.Rows[cont].Cells["colCodigo"].Value = p.Codigo;
                dgvMostrarPropiedades.Rows[cont].Cells["colTipo"].Value = p.GetType().Name;
                dgvMostrarPropiedades.Rows[cont].Cells["colNombre"].Value = p.Nombre;
                dgvMostrarPropiedades.Rows[cont].Cells["colUbicacion"].Value = p.Localidad;
                dgvMostrarPropiedades.Rows[cont].Cells["colPrecio"].Value = p.PrecioBase;
                dgvMostrarPropiedades.Rows[cont].Cells["colImagen"].Value = p.listaImagenes[0];

                cont++;
            }
        }

        private void MostrarVentanaVerMas(int rowIndex)
        {
            FormVer ventanaVerMas = new FormVer();
            ventanaVerMas.Text = dgvMostrarPropiedades.Rows[rowIndex].Cells["colNombre"].Value.ToString();

            string codigoseleccionado = dgvMostrarPropiedades.Rows[rowIndex].Cells["colCodigo"].Value.ToString();

            foreach (Propiedad p in miSistema.Propiedades)
            {
                if (Convert.ToString(p.Codigo) == codigoseleccionado)
                {
                    ventanaVerMas.txtDescripcion.Text = p.ToString();
                    DateTime fechaActual = DateTime.Now;

                    for (int i = 0; i < p.listaImagenes.Length; i++)
                    {
                        ventanaVerMas.imagenesAuxiliares[i] = p.listaImagenes[i];
                        imfondo = ventanaVerMas.imagenesAuxiliares[0];
                    }

                    if (p is Hotel)
                    {
                        ventanaVerMas.groupBox1.Enabled = true;

                        List<int> habitacionesDisponibles = ((Hotel)p).ObtenerHabitacionesDisponibles();
                        ventanaVerMas.cbxHabitacion.Items.Clear();
                        foreach (int numeroHabitacion in habitacionesDisponibles)
                        {
                            ventanaVerMas.cbxHabitacion.Items.Add(numeroHabitacion);
                        }
                        ventanaVerMas.cbxHabitacion.SelectedIndexChanged += (sender, e) =>
                        {
                            int habitacionSeleccionada = Convert.ToInt32(ventanaVerMas.cbxHabitacion.SelectedItem);

                            List<DateTime> fechasResaltadas = miSistema.PintarHabitacion((Hotel)p, habitacionSeleccionada);

                            ventanaVerMas.calReserva.BoldedDates = fechasResaltadas.ToArray();
                        };
                    }
                    if (p is Casa)
                    {
                        ventanaVerMas.groupBox1.Enabled = false;
                        List<DateTime> fechasResaltadas = miSistema.Pintar(p);
                        ventanaVerMas.calReserva.BoldedDates = fechasResaltadas.ToArray();
                    }

                    if (ventanaVerMas.ShowDialog() == DialogResult.OK)
                    {
                        ManejarReserva(ventanaVerMas, p);
                    }
                }
            }
        }

        private void ManejarReserva(FormVer ventanaVerMas, Propiedad propiedad)
        {
            try
            {
                huesped = new string[ventanaVerMas.huespedes.Length];
                for (int i = 0; i < huesped.Length; i++)
                {
                    huesped[i] = ventanaVerMas.huespedes[i];
                }

                DateTime fechaIngreso = ventanaVerMas.calReserva.SelectionStart;
                DateTime fechaEgreso = ventanaVerMas.calReserva.SelectionEnd;
                int diasTotales = (int)(fechaEgreso - fechaIngreso).TotalDays;
                int cantHuespedes = ventanaVerMas.Cantidad;

                if (propiedad is Casa)
                {
                    Casa casa = (Casa)propiedad;
                    Reserva reservaCasa = miSistema.GenerarReserva(casa, fechaIngreso, fechaEgreso, cliente, cantHuespedes);
                    ResumenPropiedad = reservaCasa.GenerarComprobante();
                    ImprimirComprobante(reservaCasa);
                }
                else if (propiedad is Hotel)
                {
                    Hotel hotel = (Hotel)propiedad;
                    int numeroHabitacion = Convert.ToInt32(ventanaVerMas.cbxHabitacion.SelectedItem);

                    if (numeroHabitacion != 0)
                    {
                        Reserva reservaHotel = miSistema.GenerarReserva(hotel, fechaIngreso, fechaEgreso, cliente, numeroHabitacion, cantHuespedes);
                        ResumenPropiedad = reservaHotel.GenerarComprobante();
                        ImprimirComprobante(reservaHotel);
                    }
                }
            }
            catch (MisExcepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImprimirComprobante(Reserva reserva)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                nroPag = 0;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
        }

        #endregion
    }
}

