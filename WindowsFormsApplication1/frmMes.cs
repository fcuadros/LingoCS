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
    public partial class frmMes : Form
    {
        private String estado;
        private decimal idmes;
        private decimal idtipotela;
        private String descripcion;
        private decimal valor;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public decimal Idmes
        {
            get { return idmes; }
            set { idmes = value; }
        }

        public decimal IdTipoTela
        {
            get { return idtipotela; }
            set { idtipotela = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public frmMes()
        {
            InitializeComponent();
        }

        private void frmMes_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            ConsultaMesesActual();

        }

        private void CargarComboBox()
        {
            Entidades.Datos BE = new Entidades.Datos();
            Bussines.Proceso BS = new Bussines.Proceso();
            BE.IdTabla = 10;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            dt = BS.CargarCombo(BE).Tables[0];
            dt1 = BS.CargarCombo(BE).Tables[0];

            cbMesDesde.DisplayMember = "DescripcionMes";
            cbMesDesde.ValueMember = "IdMes";


            cbMesHasta.DisplayMember = "DescripcionMes";
            cbMesHasta.ValueMember = "IdMes";

            cbMesDesde.DataSource = dt;
            cbMesHasta.DataSource = dt1;

        }

        private void ConsultaMesesActual()
        {
            Entidades.Datos BE = new Entidades.Datos();
            Bussines.Proceso BS = new Bussines.Proceso();
            BE.IdTabla = 3;
            DataTable dt = new DataTable();

            dt = BS.ConsultaMesesActual(BE).Tables[0];

            int intprimermes = Convert.ToInt32(dt.Rows[0]["IdPrimerMes"].ToString());
            int intultimomes = Convert.ToInt32(dt.Rows[0]["IdUltimoMes"].ToString());

            cbMesDesde.SelectedValue = intprimermes;
            cbMesHasta.SelectedValue = intultimomes;

            cbMesDesde.Update();
            cbMesHasta.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Datos BE = new Entidades.Datos();
            Bussines.Proceso BS = new Bussines.Proceso();
            
            BE.IdTabla = 1;

            if (Estado == "N")
            {

                BS.GuardarNuevoDatos(BE);
            }

            if (Estado == "M")
            {
                BE.IdMes = Idmes;
                BS.GuardarDatosModificados(BE);
            }

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
