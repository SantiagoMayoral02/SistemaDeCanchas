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
    public partial class FormHorarios : Form
    {
        private Admin admin;
        public FormHorarios(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + BL.BLSessionManager.GetInstance.Usuario.Nombre;
        }
    }
}
