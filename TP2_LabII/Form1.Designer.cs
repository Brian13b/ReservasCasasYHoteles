namespace TP2_LabII
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.dgvMostrarPropiedades = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.colVerMas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numViajeros = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCasaFinde = new System.Windows.Forms.RadioButton();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaPropiedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPropiedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaPropiedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.anularReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeHuespedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPropiedades)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numViajeros)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.Yellow;
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 44);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(220, 30);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Bienvenido Battauz, Brian";
            // 
            // dgvMostrarPropiedades
            // 
            this.dgvMostrarPropiedades.AllowUserToAddRows = false;
            this.dgvMostrarPropiedades.AllowUserToDeleteRows = false;
            this.dgvMostrarPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarPropiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colTipo,
            this.colNombre,
            this.colUbicacion,
            this.colPrecio,
            this.colImagen,
            this.colVerMas});
            this.dgvMostrarPropiedades.Location = new System.Drawing.Point(12, 232);
            this.dgvMostrarPropiedades.Name = "dgvMostrarPropiedades";
            this.dgvMostrarPropiedades.ReadOnly = true;
            this.dgvMostrarPropiedades.RowHeadersWidth = 51;
            this.dgvMostrarPropiedades.RowTemplate.Height = 24;
            this.dgvMostrarPropiedades.Size = new System.Drawing.Size(902, 378);
            this.dgvMostrarPropiedades.TabIndex = 6;
            this.dgvMostrarPropiedades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarPropiedades_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCodigo.Width = 60;
            // 
            // colTipo
            // 
            this.colTipo.FillWeight = 246.8085F;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTipo.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNombre.Width = 120;
            // 
            // colUbicacion
            // 
            this.colUbicacion.FillWeight = 51.06383F;
            this.colUbicacion.HeaderText = "Ubicacion";
            this.colUbicacion.MinimumWidth = 6;
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.ReadOnly = true;
            this.colUbicacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUbicacion.Width = 120;
            // 
            // colPrecio
            // 
            this.colPrecio.FillWeight = 51.06383F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPrecio.Width = 80;
            // 
            // colImagen
            // 
            this.colImagen.HeaderText = "Imagen";
            this.colImagen.MinimumWidth = 6;
            this.colImagen.Name = "colImagen";
            this.colImagen.ReadOnly = true;
            this.colImagen.Width = 150;
            // 
            // colVerMas
            // 
            this.colVerMas.HeaderText = "";
            this.colVerMas.MinimumWidth = 6;
            this.colVerMas.Name = "colVerMas";
            this.colVerMas.ReadOnly = true;
            this.colVerMas.Text = "Ver Mas";
            this.colVerMas.ToolTipText = "Ver Mas";
            this.colVerMas.UseColumnTextForButtonValue = true;
            this.colVerMas.Width = 83;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numViajeros);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCiudad);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtHasta);
            this.groupBox1.Controls.Add(this.dtDesde);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtar";
            // 
            // numViajeros
            // 
            this.numViajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numViajeros.Location = new System.Drawing.Point(31, 111);
            this.numViajeros.Name = "numViajeros";
            this.numViajeros.Size = new System.Drawing.Size(186, 24);
            this.numViajeros.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Viajeros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::TP2_LabII.Properties.Resources.l;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(768, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 122);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lugar";
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(31, 55);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(186, 26);
            this.cbCiudad.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCasaFinde);
            this.groupBox2.Controls.Add(this.rbHotel);
            this.groupBox2.Controls.Add(this.rbCasa);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(558, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 122);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // rbCasaFinde
            // 
            this.rbCasaFinde.AutoSize = true;
            this.rbCasaFinde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCasaFinde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbCasaFinde.Location = new System.Drawing.Point(16, 54);
            this.rbCasaFinde.Name = "rbCasaFinde";
            this.rbCasaFinde.Size = new System.Drawing.Size(114, 22);
            this.rbCasaFinde.TabIndex = 2;
            this.rbCasaFinde.TabStop = true;
            this.rbCasaFinde.Text = "Casa Finde";
            this.rbCasaFinde.UseVisualStyleBackColor = true;
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHotel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbHotel.Location = new System.Drawing.Point(16, 82);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(69, 22);
            this.rbHotel.TabIndex = 3;
            this.rbHotel.TabStop = true;
            this.rbHotel.Text = "Hotel";
            this.rbHotel.UseVisualStyleBackColor = true;
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCasa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbCasa.Location = new System.Drawing.Point(16, 29);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(68, 22);
            this.rbCasa.TabIndex = 1;
            this.rbCasa.TabStop = true;
            this.rbCasa.Text = "Casa";
            this.rbCasa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(266, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(266, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Desde:";
            // 
            // dtHasta
            // 
            this.dtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Location = new System.Drawing.Point(269, 104);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(245, 23);
            this.dtHasta.TabIndex = 4;
            // 
            // dtDesde
            // 
            this.dtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Location = new System.Drawing.Point(269, 49);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(245, 23);
            this.dtDesde.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem1,
            this.estadisticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.toolStripSeparator3,
            this.ExportarClientesToolStripMenuItem,
            this.exportarReservasToolStripMenuItem,
            this.impoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(223, 6);
            // 
            // ExportarClientesToolStripMenuItem
            // 
            this.ExportarClientesToolStripMenuItem.Name = "ExportarClientesToolStripMenuItem";
            this.ExportarClientesToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.ExportarClientesToolStripMenuItem.Text = "Exportar Clientes";
            this.ExportarClientesToolStripMenuItem.Click += new System.EventHandler(this.ExportarClientesToolStripMenuItem_Click);
            // 
            // exportarReservasToolStripMenuItem
            // 
            this.exportarReservasToolStripMenuItem.Name = "exportarReservasToolStripMenuItem";
            this.exportarReservasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.exportarReservasToolStripMenuItem.Text = "Exportar Reservas";
            this.exportarReservasToolStripMenuItem.Click += new System.EventHandler(this.exportarReservasToolStripMenuItem_Click);
            // 
            // impoToolStripMenuItem
            // 
            this.impoToolStripMenuItem.Name = "impoToolStripMenuItem";
            this.impoToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.impoToolStripMenuItem.Text = "Impo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaPropiedadToolStripMenuItem,
            this.modificarPropiedadToolStripMenuItem,
            this.bajaPropiedadToolStripMenuItem,
            this.toolStripSeparator2,
            this.anularReservaToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // cargaPropiedadToolStripMenuItem
            // 
            this.cargaPropiedadToolStripMenuItem.Name = "cargaPropiedadToolStripMenuItem";
            this.cargaPropiedadToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.cargaPropiedadToolStripMenuItem.Text = "Alta Propiedad";
            this.cargaPropiedadToolStripMenuItem.Click += new System.EventHandler(this.cargaPropiedadToolStripMenuItem_Click);
            // 
            // modificarPropiedadToolStripMenuItem
            // 
            this.modificarPropiedadToolStripMenuItem.Name = "modificarPropiedadToolStripMenuItem";
            this.modificarPropiedadToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.modificarPropiedadToolStripMenuItem.Text = "Modificar Propiedad";
            this.modificarPropiedadToolStripMenuItem.Click += new System.EventHandler(this.modificarPropiedadToolStripMenuItem_Click);
            // 
            // bajaPropiedadToolStripMenuItem
            // 
            this.bajaPropiedadToolStripMenuItem.Name = "bajaPropiedadToolStripMenuItem";
            this.bajaPropiedadToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.bajaPropiedadToolStripMenuItem.Text = "Baja Propiedad";
            this.bajaPropiedadToolStripMenuItem.Click += new System.EventHandler(this.bajaPropiedadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
            // 
            // anularReservaToolStripMenuItem
            // 
            this.anularReservaToolStripMenuItem.Name = "anularReservaToolStripMenuItem";
            this.anularReservaToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.anularReservaToolStripMenuItem.Text = "Anular Reserva";
            this.anularReservaToolStripMenuItem.Click += new System.EventHandler(this.anularReservaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(91, 24);
            this.acercaDeToolStripMenuItem1.Text = "Acerca De";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeReservasToolStripMenuItem,
            this.cantidadDeHuespedToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // cantidadDeReservasToolStripMenuItem
            // 
            this.cantidadDeReservasToolStripMenuItem.Name = "cantidadDeReservasToolStripMenuItem";
            this.cantidadDeReservasToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cantidadDeReservasToolStripMenuItem.Text = "Cantidad de Reservas";
            this.cantidadDeReservasToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeReservasToolStripMenuItem_Click_1);
            // 
            // cantidadDeHuespedToolStripMenuItem
            // 
            this.cantidadDeHuespedToolStripMenuItem.Name = "cantidadDeHuespedToolStripMenuItem";
            this.cantidadDeHuespedToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cantidadDeHuespedToolStripMenuItem.Text = "Cantidad de Huesped";
            this.cantidadDeHuespedToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeHuespedToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(935, 626);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMostrarPropiedades);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AireBnB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPropiedades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numViajeros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMostrarPropiedades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewImageColumn colImagen;
        private System.Windows.Forms.DataGridViewButtonColumn colVerMas;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCasaFinde;
        private System.Windows.Forms.RadioButton rbHotel;
        private System.Windows.Forms.RadioButton rbCasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numViajeros;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExportarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cargaPropiedadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPropiedadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaPropiedadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem anularReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeHuespedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impoToolStripMenuItem;
    }
}

