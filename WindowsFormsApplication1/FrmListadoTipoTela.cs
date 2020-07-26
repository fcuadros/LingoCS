using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bussines;
using Entidades;

namespace WindowsFormsApplication1
{
    public partial class FrmListadoTipoTela : Form
    {
        private int idtipotela;
        private string tipotela;

        public int IdTipoTela
        {
            get { return idtipotela; }
            set { idtipotela = value; }
        }

        public string TipoTela
        {
            get { return tipotela; }
            set { tipotela = value; }
        }

        public FrmListadoTipoTela()
        {
            InitializeComponent();
        }

        private void FrmListadoTipoTela_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void CargarListado()
        {
            Refrescar();
                            
        }

        private void Refrescar()
        {
            Entidades.Datos BE = new Entidades.Datos();
            Bussines.Proceso BS = new Bussines.Proceso();
            BE.IdTabla = 1;

            dgListado.DataSource = BS.Listado(BE).Tables[0];
            dgListado.Update();
        }

        private void dgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmTipoTela form = new FrmTipoTela();
            form.Estado = "N";
            form.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoTipoTela_Activated(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IdTipoTela==null)
            {
                return;
            }

                FrmTipoTela form = new FrmTipoTela();
                form.Estado = "M";
                form.IdTipoTela = IdTipoTela;
                form.Descripcion = TipoTela;
                form.ShowDialog();
            
        }

        private void dgListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dgListado.Rows[index];
            IdTipoTela = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            TipoTela = selectedRow.Cells[1].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IdTipoTela == null)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Desea eliminar el registro seleccionado?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Entidades.Datos BE = new Entidades.Datos();
                Bussines.Proceso BS = new Bussines.Proceso();

                BE.IdTabla = 1;
                BE.IdTipoTela = IdTipoTela;

                BS.EliminarDatos(BE);
            }

            Refrescar();
        }
    }
}
