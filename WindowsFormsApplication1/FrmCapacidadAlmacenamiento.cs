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
    public partial class FrmCapacidadAlmacenamiento : Form
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

        public FrmCapacidadAlmacenamiento()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Datos BE = new Entidades.Datos();
            Bussines.Proceso BS = new Bussines.Proceso();
            BE.ValorNumerico = Convert.ToDecimal(txtCapAlm.Text);
            BE.IdTabla = 6;

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


        private void LinpiarCajas()
        {
            txtCapAlm.Text = "";
            lblTitulo.Text = "";
            CargarComboBox(); 

        }

        private void CargarComboBox() 
        {
            Entidades.Datos BE = new Entidades.Datos();
            Bussines.Proceso BS = new Bussines.Proceso();
            BE.IdTabla = 3;
            DataTable dt = new DataTable();

            dt = BS.CargarCombo(BE).Tables[0];

            cbMes.DisplayMember = "DescripcionMes";
            cbMes.ValueMember = "IdMes";
            
            cbMes.DataSource = dt;

        }

        private void FrmCapacidadAlmacenamiento_Load_1(object sender, EventArgs e)
        {
            LinpiarCajas();
            if (Estado == "N")
            {
                lblTitulo.Text = "Nueva Cap. Alm.";

            }
            if (Estado == "M")
            {
                lblTitulo.Text = "Modificar Cap. Alm.";
                cbMes.SelectedItem = Idmes;
                txtCapAlm.Text = Valor.ToString();
            }
            
        }
    }
}
