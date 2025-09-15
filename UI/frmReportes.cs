using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmReportes : Form
    {
        private Form1 form1;
        public frmReportes( Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + BL.BLSessionManager.GetInstance.Usuario.Nombre;
        }
    }
}
