using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Entidades.Datos;
//using Bussines.Proceso;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Datos BE = new Entidades.Datos();
            Bussines.Proceso PR = new Bussines.Proceso();

            BE.Usuario = txtUsuario.Text;
            BE.Password = txtPassword.Text;

            DataSet ds = PR.Logueo(BE);
            string strNombre = "";

            if (ds.Tables[0].Rows.Count > 1)
            {
                strNombre = ds.Tables[0].Rows.ToString();
                label1.Text = strNombre;
                Login.ActiveForm.Hide();
            }
            else
            {
                txtUsuario.Focus();
            }

        }
    }
}
