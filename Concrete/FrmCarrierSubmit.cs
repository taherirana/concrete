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
    public partial class FrmCarrierSubmit : Form
    {
        DB db = new DB();

        public FrmCarrierSubmit()
        {
            InitializeComponent();
            SetOwnerShipType();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Career cr = new Career("fname","Lname","PQ","ow");

            if (db.InsertCareer(GetCareer()))
            {
                ClearTextBoxs();
                MessageBox.Show("اطلاعات ثبت شد");
            }
            else
                MessageBox.Show("اطلاعات ثبت نشد");
            
        }


        private void SetOwnerShipType()
        {
            List<string> OwnerShipTypes = db.getAllownerShiptype();
            cmbCarrierOwnerShipType.DataSource = OwnerShipTypes;
        }

        public Career GetCareer()
        {
            string DriverFname = txtDriverName.Text.Trim();
            string DriverLname = txtDriverFamily.Text.Trim();

            string Plaque =p4.Text.Trim() + " " + p5.Text.Trim()  +" " + p3.Text.Trim() + " " + p2.Text.Trim() + " " + p1.Text.Trim();

            string OwnerShipType = cmbCarrierOwnerShipType.Text.Trim();

            return new Career(DriverFname, DriverLname, Plaque, OwnerShipType);

        }

        public void ClearTextBoxs()
        {
            txtDriverFamily.Text = "";
            txtDriverName.Text = "";
            p1.Text = "";
            p2.Text = "";
            p3.Text = "";
            //p4.Text = "";
            p5.Text = "";

        }
    }
}
