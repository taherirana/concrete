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
    public partial class FrmCustomerSelect : Form
    {
        public int ID;
        public string CustomerName;

        public FrmCustomerSelect()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ID =  GetId();
            Name = GetName();
            this.Hide();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            var result =db.GetCustomersIDByCodeID(txtSaerch.Text.Trim());
            dgwCustomer.DataSource = result;
        }

        private int GetId()
        {
            var r = dgwCustomer.SelectedRows[0].Cells[0].Value;
            return int.Parse( r.ToString());
        }

        private string GetName()
        {
            var r = dgwCustomer.SelectedRows[0].Cells[1].Value;
            return r.ToString();
        }
    }
}
