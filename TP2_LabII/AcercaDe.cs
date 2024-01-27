using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace TP2_LabII
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
            this.Text = String.Format("Acerca de AireBnB");
            this.labelProductName.Text = "AireBnB";
            this.labelVersion.Text = String.Format("Versión 1.0.1");
            this.labelCopyright.Text = "Copyright 2023";
            this.labelCompanyName.Text = "TUP";
            this.textBoxDescription.Text = "Sistema de alquileres temporales";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<1)
                this.Opacity += 0.1;
            else
                timer1.Enabled = false;
        }

    }
}
