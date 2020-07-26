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
    public partial class FrmTipoTela : Form
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

        public FrmTipoTela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Datos BE = new Entidades.Datos();
            Bussines.Proceso BS = new Bussines.Proceso();
            BE.ValorCadena = txtTipoTela.Text;
            BE.IdTabla = 1;

            if (Estado == "N")
            {
                BS.GuardarNuevoDatos(BE);
            }
            
            if (Estado == "M")
            {
                BE.IdTipoTela = IdTipoTela;
                BE.ValorCadena = txtTipoTela.Text;
                BS.GuardarDatosModificados(BE);
            }

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTipoTela_Load(object sender, EventArgs e)
        {
            LinpiarCajas();
            if (Estado == "N") 
            {
                lblTitulo.Text = "Nuevo Tipo de Tela";

            }
            if (Estado == "M")
            {
                lblTitulo.Text = "Modificar Tipo de Tela";
                txtTipoTela.Text = Descripcion;
            }
        }

        private void LinpiarCajas() 
        {
            txtTipoTela.Text = "";
            lblTitulo.Text = "";
        }
    }
}
