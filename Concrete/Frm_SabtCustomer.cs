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
        Customer c;

        public Frm_SabtCustomer()
        {
            InitializeComponent();
            c = new Customer();
        }

        public bool checkId_Code(string codeid)
        {
            bool flag = true;


            if (codeid.Length == 10)
                flag = true;

            else
                flag = false;


            for (int i = 0; i < codeid.Length - 1; i++)
            {
                if (codeid[i] == '-')
                    flag = false;
            }

            return flag;

        }

        public bool CheckMobileNumber(string mobilenumber)
        {
            bool flag = true;

            if (mobilenumber.Length == 11)
                flag = true;
            else
                flag = false;

            return flag;
        }

        public bool CheckPhoneNumber(string phonenumber)
        {
            bool flag = true;


            if (phonenumber.Length == 8)
                flag = true;
            else
                flag = false;

            return flag;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (CheckData())
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
            c.FirstName     = txtName.Text.Trim();
            c.LastName      = txtFamily.Text.Trim();
            c.NationalCode  = txtKmeli.Text.Trim();

            return c;
        }

        private void Frm_SabtCustomer_Load(object sender, EventArgs e)
        {
            language.Persian();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = true;
            }


            if (txtName.TextLength > 25)
            {
                e.Handled = true;
                MessageBox.Show("کاراکتر ورودی بیشتر از حد مجاز است");
            }
        }

        private void txtFamily_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = true;
            }

            if(txtFamily.TextLength >35)
            {
                e.Handled = true;
                MessageBox.Show("کاراکتر ورودی بیشتر از حد مجاز است");
            }
        }

        private void txtKmeli_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || !(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("لطفا عدد وارد کنید");
            }

        }

        private void txt_tell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || !(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("لطفا عدد وارد کنید");
            }
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || !(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("لطفا عدد وارد کنید");
            }
        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_address.TextLength > 200)
                MessageBox.Show("کاراکتر ورودی بیشتر از حد مجاز است");
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            AddPersonAddress();
        }

        public void ClearAddress()
        {
            txt_address.Text = "";
        }

        public void FocuseToAddress()
        {
            txt_address.Focus();
        }

        public void AddPersonAddress()
        {
            string add = txt_address.Text.Trim();
            c.AddAddress(add);
            lstAddresses.Items.Add(add);
            ClearAddress();
            FocuseToAddress();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1 | keyData == Keys.Enter)
            {
                AddPersonAddress();
                return true;
            }
            if (keyData == Keys.Escape)
            {
                this.Close();
            }

            return false;
        }

        public bool CheckData()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("لطفا نام را وارد کنید");
                return false;
            }
            
            if (txtFamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید");
                return  false;
            }
            
            if (txtKmeli.Text == "")
            {
                MessageBox.Show("لطفا کد ملی را وارد کنید");
                return false;
            }
            
            if (txt_tell.Text == "")
            {
                MessageBox.Show("لطفا تلفن را وارد کنید");
                return false;
            }
            
            if (txt_mobile.Text == "")
            {
                MessageBox.Show("لطفا موبایل را وارد کنید");
                return false;
            }
            
            /*if (txt_address.Text == "")
            {
                MessageBox.Show("لطفا آدرس را وارد کنید");
                return false;
            }*/

            if (checkId_Code(txtKmeli.Text.Trim()) == false)
            {
                MessageBox.Show("لطفا کد ملی را صحیح وارد کنید");
                return false;
            }
           
            if (CheckMobileNumber(txt_mobile.Text.Trim()) == false)
            {
                MessageBox.Show("لطفا موبایل را صحیح وارد کنید");
                return false;
            }
            
            if (CheckPhoneNumber(txt_tell.Text.Trim()) == false)
            {
                MessageBox.Show("لطفا تلفن را صحیح وارد کنید");
                return false;
            }
           
            return true;
        }
    }
}
