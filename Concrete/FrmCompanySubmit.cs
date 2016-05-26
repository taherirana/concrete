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
    public partial class FrmCompanySubmit : Form
    {
        public FrmCompanySubmit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCompanySubmit_Load(object sender, EventArgs e)
        {
            language.Persian();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompany.Text))
            {
                errorProvider1.SetError(txtCompany, "نام شرکت را وارد کنید.");

            }

            else
            {
                errorProvider1.SetError(txtCompany, "");

            }
        }


    }
}
