using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmListadoMeses : Form
    {
        public FrmListadoMeses()
        {
            InitializeComponent();
        }

        private void FrmListadoMeses_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void CargarListado()
        {
            Entidades.Datos BE = new Entidades.Datos();
            Bussines.Proceso BS = new Bussines.Proceso();
            BE.IdTabla = 3;

            dgListado.DataSource = BS.Listado(BE).Tables[0];
            dgListado.Update();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmMes form = new frmMes();
            form.Estado = "M";
            form.ShowDialog();
        }
    }
}
