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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void rbe_sabtCustomer_Click(object sender, EventArgs e)
        {
            Frm_SabtCustomer fsc = new Frm_SabtCustomer();
            fsc.ShowDialog();

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void rbe_SabtMixer_Click(object sender, EventArgs e)
        {
            Frm_SabtMixer fsm = new Frm_SabtMixer();
            fsm.ShowDialog();
        }
    }
}
