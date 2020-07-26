using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class FrmGenerarLingo : Form
    {
        public FrmGenerarLingo()
        {
            InitializeComponent();
        }

        public struct CallbackData
        {
            public int nCallbacks;
            public int nIterations;
            public double dObjective;
        }
      
        private void btnGenerarLingo_Click(object sender, EventArgs e)
        {
            Class1.x();
        }
    }
}
