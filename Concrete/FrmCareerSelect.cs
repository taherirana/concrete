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
    public partial class FrmCareerSelect : Form
    {
        public String Name, ID;
        public FrmCareerSelect()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("لطفا متنی را داخل کادر جستجو وارد نمایید");
                return;
            }

            DB db = new DB();
            var C = db.getCareersbyPlaque(txtSearch.Text.Trim());
            dgwCarrier.DataSource = C;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgwCarrier.SelectedRows.Count > 0)
            {
                Name = dgwCarrier.SelectedRows[0].Cells[0].Value.ToString();
                ID = dgwCarrier.SelectedRows[0].Cells[4].Value.ToString();
                //this.Hide();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                /// دادن پاسخ مناسب
            }
        }
    }
}
