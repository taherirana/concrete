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
        public FrmCarrierSubmit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Career cr = new Career("fname","Lname","PQ","ow");
            DB db= new DB();
            db.InsertCareer(cr);
        }

        private void FrmCarrierSubmit_Load(object sender, EventArgs e)
        {
            language.Persian();
        }
    }
}
