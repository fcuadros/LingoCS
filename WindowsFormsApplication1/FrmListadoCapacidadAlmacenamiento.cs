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

    public partial class FrmListadoCapacidadAlmacenamiento : Form
    {
        private int idtipotela;
        private int idmes;
        private string valorcadena;
        private decimal valornumerico;

        public int IdTipoTela
        {
            get { return idtipotela; }
            set { idtipotela = value; }
        }

        public int IdMes
        {
            get { return idmes; }
            set { idmes = value; }
        }

        public string ValorCadena
        {
            get { return valorcadena; }
            set { valorcadena = value; }
        }

        public decimal ValorNumerico
        {
            get { return valornumerico; }
            set { valornumerico = value; }
        }

        public FrmListadoCapacidadAlmacenamiento()
        {
            InitializeComponent();
        }

        private void FrmListadoCapacidadAlmacenamiento_Load(object sender, EventArgs e)
        {
            CargarListado();
        }
        private void CargarListado()
        {
            Refrescar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refrescar()
        {
            Entidades.Datos BE = new Entidades.Datos();
            Bussines.Proceso BS = new Bussines.Proceso();
            BE.IdTabla = 5;

            dgListado.DataSource = BS.Listado(BE).Tables[0];
            dgListado.Update();
        }

        private void FrmListadoCapacidadAlmacenamiento_Activated(object sender, EventArgs e)
        {
            Refrescar();
        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FrmCapacidadAlmacenamiento form = new FrmCapacidadAlmacenamiento();
            form.Estado = "N";
            form.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IdMes == null)
            {
                return;
            }

            FrmCapacidadAlmacenamiento form = new FrmCapacidadAlmacenamiento();
            form.Estado = "M";
            form.Idmes = IdMes;
            form.Valor = ValorNumerico;
            form.ShowDialog();
        }
    }
}
