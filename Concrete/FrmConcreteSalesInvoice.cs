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
        private int CustomerID;
        private string careerID;

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
            FrmCustomerSelect frmSelectCustomer = new FrmCustomerSelect();
            frmSelectCustomer.ShowDialog();

            txtCustomer.Text = frmSelectCustomer.Name;
            CustomerID = frmSelectCustomer.ID;
            frmSelectCustomer.Close();

        }

        private void pbMixerSearch_Click(object sender, EventArgs e)
        {
            FrmMixerSelect fms1 = new FrmMixerSelect();
            fms1.ShowDialog();
        }

        private void pbCareer_Click(object sender, EventArgs e)
        {
            FrmCareerSelect frmCareerSelect = new FrmCareerSelect();
            frmCareerSelect.ShowDialog();
            careerID = frmCareerSelect.ID;
            txtCareer.Text = frmCareerSelect.Name;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {

        }

        private void dgwSalesInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        
    }
}
