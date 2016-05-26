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
    public partial class Frm_SabtCustomer : Form
    {
        public Frm_SabtCustomer()
        {
            InitializeComponent();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkError())
            {
                 DB db = new DB();
                
                db.InserCustomer(GetCustomer());
            }

            
        }

        /// <summary>
        /// Getting Customer Info from related TextBox
        /// </summary>
        /// <returns>Customer</returns> 
        private Customer GetCustomer()
        {
            String Name = txtName.Text.Trim();
            String Family = txtFamily.Text.Trim();
            string IDCode = txtKmeli.Text.Trim();

            Customer c = new Customer(Name, Family, IDCode);

            c.AddPhone(txt_mobile.Text.Trim());
            c.AddAddress(txt_address.Text.Trim());
            return c;
        }

        private void Frm_SabtCustomer_Load(object sender, EventArgs e)
        {
            language.Persian();
        }

        private bool checkError()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "نام مشتری را وارد کنید.");
                return false;

            }
            else if (string.IsNullOrWhiteSpace(txtFamily.Text))
            {
                errorProvider1.SetError(txtFamily, "نام خانوادگی را وارد کنید");
                return false;

            }
            else if (string.IsNullOrWhiteSpace(txtKmeli.Text))
            {
                errorProvider1.SetError(txtKmeli, "کدملی را وارد کنید");
                return false;

            }
            else if (string.IsNullOrWhiteSpace(txt_tell.Text))
            {
                errorProvider1.SetError(txt_tell, "شماره تلفن را وارد کنید");
                return false;

            }
            else if (string.IsNullOrWhiteSpace(txt_mobile.Text))
            {
                errorProvider1.SetError(txt_mobile, "شماره موبایل را وارد کنید");
                return false;

            }
            else if (string.IsNullOrWhiteSpace(txt_address.Text))
            {
                errorProvider1.SetError(txt_address, "آدرس را وارد کنید");
                return false;

            }

            else
            {
                errorProvider1.SetError(txtName, "");
                errorProvider1.SetError(txtFamily, "");
                errorProvider1.SetError(txtKmeli, "");
                errorProvider1.SetError(txt_tell, "");
                errorProvider1.SetError(txt_mobile, "");
                errorProvider1.SetError(txt_address, "");
                return true;

            }
           // return true;
        }
    }

}
