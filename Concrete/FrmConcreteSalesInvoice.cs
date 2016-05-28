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
        private int careerID ;
        private int MixerID ;
        
        DB db = new DB();

        public FrmConcreteSalesInvoice()
        {
            InitializeComponent();
        }

        public void ClearTextBox()
        {
            txtCustomer.Clear();
            txtMixer.Clear();
            txtCareer.Clear();
            txtweight.Clear();
            txtAddress.Clear();
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
          
            SetConcreteOperation();
            setConcreteOperatin();

            cmbConcretetype.SelectedIndex =-1;
            cmbOperation.SelectedIndex = -1;

            
            
        }

        

        

        private void SetConcreteOperation()
        {
            List<string> C = db.getConccretesType().Select(c => c.Type.ToString()).ToList<string>();
            cmbConcretetype.DataSource = C;
        }

        private void setConcreteOperatin()
        {
            List<string> C = db.getConccretesType().Select(c => c.Type.ToString()).ToList<string>();
            cmbOperation.DataSource = C;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            AddToDatagrid();

            
        }


        ConcreteSellOrder cso = new ConcreteSellOrder();

        private void AddToDatagrid()
        {
            

            SellItem si = getSellItem();
            cso.Add(si);
            
            dgwSalesInvoice.Rows.Add(getSellItemArray(si));

            if (!btnSave.Enabled)
                btnSave.Enabled = true;

            ClearTextBox();
            txtCustomer.Focus();

        }

        public SellItem getSellItem()
        {
            string CustomerName = txtCustomer.Text.Trim(),
                   MixerDriverName = txtMixer.Text.Trim(),
                   CareeDriverName = txtCareer.Text.Trim(),
                   ConcreteType = cmbConcretetype.Text.Trim(),
                   Operation = cmbOperation.Text.Trim(),
                   Address = txtAddress.Text.Trim();

            float WeightInTon = float.Parse(txtweight.Text.Trim()),
                  WeightInM2 = WeightInTon,
                  price = 0;

            cso.customer = new Customer(CustomerName,CustomerID);

            return  new SellItem(CustomerName,careerID , MixerID, ConcreteType, Operation, Address, WeightInTon, WeightInM2, price);

        }

        private void pbCustomerSearch_Click(object sender, EventArgs e)
        {
            FrmCustomerSelect frmSelectCustomer = new FrmCustomerSelect();
            frmSelectCustomer.ShowDialog();

            txtCustomer.Text = frmSelectCustomer.CustomerName;
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

            if (frmCareerSelect.ShowDialog() == DialogResult.OK)
            {
                careerID = int.Parse( frmCareerSelect.ID);
                txtCareer.Text = frmCareerSelect.Name;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            cso.user = new User();   //For Test
            cso.user.ID = 1;         // For Test

            db.ConcreteOrder(cso);
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

        private string[] getSellItemArray(SellItem si)
        {
           return new string[] { si.CustomerName, txtMixer.Text.Trim(), txtCareer.Text.Trim(), si.WeightInTon.ToString(), si.WeightInM2.ToString(), si.ConcreteType, si.price.ToString(),si.Operation, si.Address };
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
                if (keyData == Keys.F2)
            {
                AddToDatagrid();
            }
            else if (keyData == Keys.Escape)
            {
                this.Close();
            }
            else if (keyData == Keys.Enter)
            {
                if (cmbConcretetype.Focused)
                {
                    cmbOperation.Focus();
                    return true;
                }
                else
                    this.ProcessTabKey(true);
                
            }
            return false;
        }

       

        

        
    }
}
