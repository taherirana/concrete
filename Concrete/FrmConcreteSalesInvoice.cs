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
    public partial class FrmConcreteSalesInvoice : Form
    {
        public FrmConcreteSalesInvoice()
        {
            InitializeComponent();
        }

        public void ClearTextBox()
        {
            txtCustomer.Clear();
            txtMixer.Clear();
            txtweight.Clear();
            txtCareer.Clear();
            textBox1.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            btnPrintInvoice.Enabled = false;
            btnPrintReceipt.Enabled = false;
            btnNewInvoice.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConcreteSalesInvoice_Load(object sender, EventArgs e)
        {
            language.Persian();
            btnPrintReceipt.Enabled = false;
            btnPrintInvoice.Enabled = false;
            btnNewInvoice.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void pbCustomerSearch_Click(object sender, EventArgs e)
        {
            FrmCustomerSelect fcss = new FrmCustomerSelect();
            fcss.ShowDialog();
        }

        private void pbMixerSearch_Click(object sender, EventArgs e)
        {
            FrmMixerSelect fms1 = new FrmMixerSelect();
            fms1.ShowDialog();
        }

        private void pbCareer_Click(object sender, EventArgs e)
        {
            FrmCareerSelect fcs3 = new FrmCareerSelect();
            fcs3.ShowDialog();
        }
    }
}
