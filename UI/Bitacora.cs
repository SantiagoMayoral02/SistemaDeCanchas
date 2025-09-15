using BL;
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
    public partial class Bitacora : Form
    {
        BLBitacora bitacora = new BLBitacora();
        Admin admin;
        public Bitacora(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            bitacora.InsertarBitacora((BLSessionManager.GetInstance).Usuario, "Ingreso a la pantalla bitacora");
            lblUsu.Text = (BLSessionManager.GetInstance).Usuario.Nombre;
            List<BE.Bitacora> listBitacora = bitacora.ListarBitacora();
            dataGridView1.DataSource = listBitacora;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            bitacora.InsertarBitacora((BLSessionManager.GetInstance).Usuario, "Vuelta a la pantalla admin desde bitacora");
            admin.Show();
            this.Close();   
        }
    }
}
