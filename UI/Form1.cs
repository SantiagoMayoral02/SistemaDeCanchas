using BE;
using BL;
using Seguridad;
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
    public partial class Form1 : Form
    {
        BLUsuarioConexion BLUsu = new BLUsuarioConexion();
        BLBitacora BLBita = new BLBitacora();
        Encrypting encryptManager = new Encrypting();
        public Form1()
        {
            InitializeComponent();
            if (HayDatosCorruptos())
                MessageBox.Show("Checksum de tabla bitacora alterado");
        }
        //private void 
        //if(digitoVerificador.comprobarTablas())
        //    {
        //        button1.Enabled = false;
        //        button2.Enabled = true;
        //        button2.Visible = true;
        //    }
    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ValidarIngresoDeCampos())
            {
                string nom = txtNombre.Text;
                string pass = txtContra.Text;
                Usuario usu = BLUsu.ValidarUsuario(nom, pass);
                if (usu != null)
                {
                    BLSessionManager.login(usu);
                    BLBita.InsertarBitacora((BL.BLSessionManager.GetInstance).Usuario, "Ingreso de usuario");
                    Form2 formLogin = new Form2();
                    formLogin.Show();
                    //switch (usu.Permisos[0].Id)
                    //{
                    //    case 1:
                    //        Admin form2 = new Admin(this);
                    //        form2.Show();
                    //        this.Hide();
                    //        break;
                    //    case 3:
                    //        Venta form3 = new Venta(this);
                    //        form3.Show();
                    //        this.Hide();
                    //        break;
                    //    case 10:
                    //        Venta form4 = new Venta(this);
                    //        form4.Show();
                    //        this.Hide();
                    //        break;
                    //    case 12:
                    //        Venta form5 = new Venta(this);
                    //        form5.Show();
                    //        this.Hide();
                    //        break;
                    //    case 5:
                    //        Analisis_de_equipo form6 = new Analisis_de_equipo(this);
                    //        form6.Show();
                    //        this.Hide();
                    //        break;
                    //    case 6:
                    //        Analista_de_campo form7 = new Analista_de_campo(this);
                    //        form7.Show();
                    //        this.Hide();
                    //        break;
                    //    case 4:
                    //        Instalador form8 = new Instalador(this);
                    //        form8.Show();
                    //        this.Hide();
                    //        break;
                    //    case 8:
                    //        Cliente form9 = new Cliente(this);
                    //        form9.Show();
                    //        this.Hide();
                    //        break;
                    //    default:
                    //        MessageBox.Show("Roll no valido");
                    //        break;
                    //}
                }
            }
        }
        private bool ValidarIngresoDeCampos()
        {
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroForm formRegistro = new RegistroForm();
            formRegistro.Show();
        }
        private bool HayDatosCorruptos()
        {
            string resultado = BLBita.VerificarIntegridadTabla();
            if (resultado == "La tabla ha sido alterada o se ha eliminado un registro.")
            {
                MessageBox.Show("La tabla bitacora tiene registros alterados o eliminados");
                return true;
            }
            return false;
        }
    }
}
