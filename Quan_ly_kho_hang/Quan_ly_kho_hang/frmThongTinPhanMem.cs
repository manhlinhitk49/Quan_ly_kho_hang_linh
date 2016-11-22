using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_ly_kho_hang
{
    public partial class frmThongTinPhanMem : Form
    {
        public frmThongTinPhanMem()
        {
            InitializeComponent();
        }

        private void frmThongTinPhanMem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
