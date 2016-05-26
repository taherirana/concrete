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
    public partial class FrmMixerSubmit : Form
    {
        public FrmMixerSubmit()
        {
            InitializeComponent();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMixerSubmit_Load(object sender, EventArgs e)
        {
            language.Persian();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
