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

        public Pomp GetCareer()
        {
            string DriverFname = txtDriverName.Text.Trim();
            string DriverLname = txtDriverFamily.Text.Trim();

            string Plaque =p5.Text.Trim() + " " + p5.Text.Trim()  +" " + p3.Text.Trim() + " " + p2.Text.Trim() + " " + P1.Text.Trim();

            string OwnerShipType = cmbCarrierOwnerShipType.Text.Trim();

            //return new Pomp(DriverFname, DriverLname, Plaque, OwnerShipType);
            return null;

        }

        public void ClearTextBoxs()
        {
            txtDriverFamily.Text = "";
            txtDriverName.Text = "";
            P1.Text = "";
            p2.Text = "";
            p3.Text = "";
            p5.Text = "";

        }

        private void FrmCarrierSubmit_Load(object sender, EventArgs e)
        {
            language.Persian();
        }
    }
}
