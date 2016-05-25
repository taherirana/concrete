using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concrete
{
    public partial class FrmCarrierManage : Form
    {
        public FrmCarrierManage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCarrierManage_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSubmit.Enabled = false;
            txtDriverName.Enabled = false;
            txtDriverFamily.Enabled = false;
            cmbmmixer.Enabled = false;
            p1.Enabled = false;
            p2.Enabled = false;
            p3.Enabled = false;
            p4.Enabled = false;
            p5.Enabled = false;
        }
    }
}
