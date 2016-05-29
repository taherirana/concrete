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
                errorProvider1.SetError(txtCompany, "نام شرکت را وارد کنید.");
            else
            {
                string Name    = txtCompany.Text.Trim()   ,
                       Fax     = txtFax.Text.Trim()       ,
                       Address = txtAddress.Text.Trim()   ,
                       Tell    = txtTell.Text.Trim()      ;
               

                DB db = new DB();
                if (db.InsertCompanyInfo(Name, Fax , Tell ,  Address))
                {
                    MessageBox.Show("اطلاعات شرکت ثبت شد");
                    errorProvider1.SetError(txtCompany, "");
                    ClearAllText();
                }
                else
                    MessageBox.Show("خطا!اطلاعات ثبت نشد.لطفا مجددا سعی  کنید");
                
            }
        }

        public void ClearAllText()
        {
            txtAddress.Text  = "";
            txtCompany.Text  = "";
            txtFax.Text      = "";
            txtTell.Text     = "";
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
