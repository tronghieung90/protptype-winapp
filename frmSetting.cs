using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;

namespace eBHXH.Prototype
{
    public partial class frmSetting : MetroForm
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void dataGridViewX3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
