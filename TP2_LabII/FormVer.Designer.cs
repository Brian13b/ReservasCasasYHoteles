namespace TP2_LabII
{
    partial class FormVer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVer));
            this.btnReservar = new System.Windows.Forms.Button();
            this.calReserva = new System.Windows.Forms.MonthCalendar();
            this.cbxHabitacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCargarHusped = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbCargarHusped.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReservar.Location = new System.Drawing.Point(598, 515);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(290, 52);
            this.btnReservar.TabIndex = 4;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // calReserva
            // 
            this.calReserva.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.calReserva.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calReserva.Location = new System.Drawing.Point(598, 298);
            this.calReserva.MaxSelectionCount = 90;
            this.calReserva.Name = "calReserva";
            this.calReserva.ShowToday = false;
            this.calReserva.TabIndex = 5;
            this.calReserva.TabStop = false;
            // 
            // cbxHabitacion
            // 
            this.cbxHabitacion.FormattingEnabled = true;
            this.cbxHabitacion.Location = new System.Drawing.Point(96, 29);
            this.cbxHabitacion.Name = "cbxHabitacion";
            this.cbxHabitacion.Size = new System.Drawing.Size(158, 24);
            this.cbxHabitacion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Habitacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxHabitacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(696, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel";
            // 
            // gbCargarHusped
            // 
            this.gbCargarHusped.Controls.Add(this.label4);
            this.gbCargarHusped.Controls.Add(this.dtpNacimiento);
            this.gbCargarHusped.Controls.Add(this.txtDni);
            this.gbCargarHusped.Controls.Add(this.label3);
            this.gbCargarHusped.Controls.Add(this.label2);
            this.gbCargarHusped.Controls.Add(this.txtNombreApellido);
            this.gbCargarHusped.Controls.Add(this.btnCargar);
            this.gbCargarHusped.Enabled = false;
            this.gbCargarHusped.Location = new System.Drawing.Point(456, 109);
            this.gbCargarHusped.Name = "gbCargarHusped";
            this.gbCargarHusped.Size = new System.Drawing.Size(548, 182);
            this.gbCargarHusped.TabIndex = 9;
            this.gbCargarHusped.TabStop = false;
            this.gbCargarHusped.Text = "Cargar Huespedes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(302, 65);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(215, 22);
            this.dtpNacimiento.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(22, 132);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(212, 22);
            this.txtDni.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre y Apellido";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Location = new System.Drawing.Point(22, 65);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(212, 22);
            this.txtNombreApellido.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(352, 120);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(98, 46);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(22, 34);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(178, 22);
            this.tbCantidad.TabIndex = 15;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            this.tbCantidad.Leave += new System.EventHandler(this.tbCantidad_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCantidad);
            this.groupBox3.Location = new System.Drawing.Point(456, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 91);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad Huespedes";
            // 
            // btnSig
            // 
            this.btnSig.BackgroundImage = global::TP2_LabII.Properties.Resources.flecha_der;
            this.btnSig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSig.Location = new System.Drawing.Point(387, 141);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(40, 40);
            this.btnSig.TabIndex = 2;
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.BackColor = System.Drawing.Color.Transparent;
            this.btnAnt.BackgroundImage = global::TP2_LabII.Properties.Resources.flecha_izq;
            this.btnAnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnt.Location = new System.Drawing.Point(12, 141);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(40, 40);
            this.btnAnt.TabIndex = 1;
            this.btnAnt.UseVisualStyleBackColor = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagen.Location = new System.Drawing.Point(12, 18);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(419, 296);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(12, 320);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(419, 242);
            this.txtDescripcion.TabIndex = 17;
            // 
            // FormVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1020, 574);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbCargarHusped);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calReserva);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.pbImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVer";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.FormVer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCargarHusped.ResumeLayout(false);
            this.gbCargarHusped.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReservar;
        public System.Windows.Forms.PictureBox pbImagen;
        public System.Windows.Forms.Button btnAnt;
        public System.Windows.Forms.Button btnSig;
        public System.Windows.Forms.MonthCalendar calReserva;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxHabitacion;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbCargarHusped;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        public System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtDescripcion;
    }
}