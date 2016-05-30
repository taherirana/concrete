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
    public partial class FrmMixerSubmit : Form
    {
        public FrmMixerSubmit()
        {
            InitializeComponent();
        }

        public void clearTextBox()
        {
            txtDriverName.Clear();
            txtDriverFamily.Clear();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMixerSubmit_Load(object sender, EventArgs e)
        {
            language.Persian();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtDriverName.Text == "")
            {
                MessageBox.Show("لطفا نام راننده را وارد کنید");
                return;
            }
            else if(txtDriverFamily.Text=="")
            {
                MessageBox.Show("لطفا نام خانوادگی راننده را وارد کنید");
                return;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2)
            {
                // AddToDatagrid();
            }
            else if (keyData == Keys.Escape)
            {
                this.Close();
            }
            else if (keyData == Keys.Enter)
            {

                this.ProcessTabKey(true);
            }
            return false;
        }

    }
}
