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
            String Name = txtName.Text.Trim();
            String Family = txtFamily.Text.Trim();
            string IDCode = txtKmeli.Text.Trim();

            Customer c = new Customer(Name,Family,IDCode);

            c.AddPhone(txt_mobile.Text.Trim());
            c.AddAddress(txt_address.Text.Trim());

            DB db = new DB();

            db.InserCustomer(c);
        }


    }
}
