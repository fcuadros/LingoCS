namespace WindowsFormsApplication1
{
    partial class Screem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoTelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capacidadProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.costoAlmacenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costoEmbalajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.costoProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarLingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteLingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestrosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // maestrosToolStripMenuItem
            // 
            this.maestrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesesToolStripMenuItem,
            this.tipoTelaToolStripMenuItem,
            this.demandaToolStripMenuItem,
            this.capacidadProdToolStripMenuItem,
            this.toolStripMenuItem1,
            this.costoAlmacenamientoToolStripMenuItem,
            this.costoEmbalajeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.costoProduccionToolStripMenuItem});
            this.maestrosToolStripMenuItem.Name = "maestrosToolStripMenuItem";
            this.maestrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.maestrosToolStripMenuItem.Text = "Maestros";
            // 
            // mesesToolStripMenuItem
            // 
            this.mesesToolStripMenuItem.Name = "mesesToolStripMenuItem";
            this.mesesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.mesesToolStripMenuItem.Text = "Meses";
            this.mesesToolStripMenuItem.Click += new System.EventHandler(this.mesesToolStripMenuItem_Click);
            // 
            // tipoTelaToolStripMenuItem
            // 
            this.tipoTelaToolStripMenuItem.Name = "tipoTelaToolStripMenuItem";
            this.tipoTelaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.tipoTelaToolStripMenuItem.Text = "Tipo Tela";
            this.tipoTelaToolStripMenuItem.Click += new System.EventHandler(this.tipoTelaToolStripMenuItem_Click);
            // 
            // demandaToolStripMenuItem
            // 
            this.demandaToolStripMenuItem.Name = "demandaToolStripMenuItem";
            this.demandaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.demandaToolStripMenuItem.Text = "Demanda";
            this.demandaToolStripMenuItem.Click += new System.EventHandler(this.demandaToolStripMenuItem_Click);
            // 
            // capacidadProdToolStripMenuItem
            // 
            this.capacidadProdToolStripMenuItem.Name = "capacidadProdToolStripMenuItem";
            this.capacidadProdToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.capacidadProdToolStripMenuItem.Text = "Capacidad Planta";
            this.capacidadProdToolStripMenuItem.Click += new System.EventHandler(this.capacidadProdToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 22);
            this.toolStripMenuItem1.Text = "Capacidad Almacenamiento";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // costoAlmacenamientoToolStripMenuItem
            // 
            this.costoAlmacenamientoToolStripMenuItem.Name = "costoAlmacenamientoToolStripMenuItem";
            this.costoAlmacenamientoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.costoAlmacenamientoToolStripMenuItem.Text = "Costo Almacenamiento";
            this.costoAlmacenamientoToolStripMenuItem.Click += new System.EventHandler(this.costoAlmacenamientoToolStripMenuItem_Click);
            // 
            // costoEmbalajeToolStripMenuItem
            // 
            this.costoEmbalajeToolStripMenuItem.Name = "costoEmbalajeToolStripMenuItem";
            this.costoEmbalajeToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.costoEmbalajeToolStripMenuItem.Text = "Costo Embalaje";
            this.costoEmbalajeToolStripMenuItem.Click += new System.EventHandler(this.costoEmbalajeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 22);
            this.toolStripMenuItem2.Text = "Costo Materia Prima";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // costoProduccionToolStripMenuItem
            // 
            this.costoProduccionToolStripMenuItem.Name = "costoProduccionToolStripMenuItem";
            this.costoProduccionToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.costoProduccionToolStripMenuItem.Text = "Costo Produccion";
            this.costoProduccionToolStripMenuItem.Click += new System.EventHandler(this.costoProduccionToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarLingoToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // generarLingoToolStripMenuItem
            // 
            this.generarLingoToolStripMenuItem.Name = "generarLingoToolStripMenuItem";
            this.generarLingoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.generarLingoToolStripMenuItem.Text = "Generar Lingo";
            this.generarLingoToolStripMenuItem.Click += new System.EventHandler(this.generarLingoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteLingoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteLingoToolStripMenuItem
            // 
            this.reporteLingoToolStripMenuItem.Name = "reporteLingoToolStripMenuItem";
            this.reporteLingoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.reporteLingoToolStripMenuItem.Text = "Reporte Lingo";
            this.reporteLingoToolStripMenuItem.Click += new System.EventHandler(this.reporteLingoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(836, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido Gerson O.";
            // 
            // Screem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.screem;
            this.ClientSize = new System.Drawing.Size(1013, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Screem";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Screem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoTelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capacidadProdToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem costoAlmacenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costoEmbalajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem costoProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarLingoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteLingoToolStripMenuItem;
    }
}

