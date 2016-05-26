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
    public partial class FrmConcreteTypeSubmit : Form
    {
        public FrmConcreteTypeSubmit()
        {
            InitializeComponent();
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Concrete ce = new Concrete( int.Parse( txtconcretetype.Text.Trim() ), int.Parse( txtconcretePrice.Text.Trim() ) );

            DB db = new DB();

            if (db.InsertConcrete(ce))
            {
                txtconcretePrice.Text = "";
                txtconcretetype.Text = "";
            }
            else
            {
                MessageBox.Show("اطلاعات ثبت نشد");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
