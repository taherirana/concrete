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
    public partial class FrmMixerManage : Form
    {
        public FrmMixerManage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            /////////////////////////////////////
        }

        private void FrmMixerManage_Load(object sender, EventArgs e)
        {
            language.Persian();
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
