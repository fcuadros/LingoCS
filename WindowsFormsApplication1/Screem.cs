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
    public partial class Screem : Form
    {
        public Screem()
        {
            InitializeComponent();
        }

        private void Screem_Load(object sender, EventArgs e)
        {

        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoMeses form = new FrmListadoMeses();
            form.Show();
        }

        private void tipoTelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoTipoTela form = new FrmListadoTipoTela();
            form.ShowDialog();
        }

        private void demandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoDemanda form = new FrmListadoDemanda();
            form.ShowDialog();
        }

        private void capacidadProdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoCapacidadPlanta form = new FrmListadoCapacidadPlanta();
            form.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListadoCapacidadAlmacenamiento form = new FrmListadoCapacidadAlmacenamiento();
            form.ShowDialog();
        }

        private void costoAlmacenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoCostoAlmacenamiento form = new FrmListadoCostoAlmacenamiento();
            form.ShowDialog();
        }

        private void costoEmbalajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoCostoEmbalaje form = new FrmListadoCostoEmbalaje();
            form.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmListadoCostoMateriaPrima form = new FrmListadoCostoMateriaPrima();
            form.ShowDialog();
        }

        private void costoProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoCostoProduccion form = new FrmListadoCostoProduccion();
            form.ShowDialog();
        }

        private void reporteLingoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteLingo form = new FrmReporteLingo();
            form.ShowDialog();
        }

        private void generarLingoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarLingo form = new FrmGenerarLingo();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
