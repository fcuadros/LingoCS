namespace WindowsFormsApplication1
{
    partial class FrmGenerarLingo
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
            this.btnGenerarLingo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLingo
            // 
            this.btnGenerarLingo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerarLingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarLingo.Location = new System.Drawing.Point(151, 102);
            this.btnGenerarLingo.Name = "btnGenerarLingo";
            this.btnGenerarLingo.Size = new System.Drawing.Size(112, 63);
            this.btnGenerarLingo.TabIndex = 0;
            this.btnGenerarLingo.Text = "Generar Lingo";
            this.btnGenerarLingo.UseVisualStyleBackColor = false;
            this.btnGenerarLingo.Click += new System.EventHandler(this.btnGenerarLingo_Click);
            // 
            // FrmGenerarLingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 286);
            this.Controls.Add(this.btnGenerarLingo);
            this.Name = "FrmGenerarLingo";
            this.Text = "FrmGenerarLingo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLingo;
    }
}