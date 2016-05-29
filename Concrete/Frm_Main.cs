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
            FrmMixerSubmit fsm = new FrmMixerSubmit();
            fsm.ShowDialog();
        }

        private void rbe_SabtAConcreate_Click(object sender, EventArgs e)
        {
            FrmConcreteTypeSubmit fsac = new FrmConcreteTypeSubmit();
            fsac.ShowDialog();
        }

        private void rbe_SInvoice_Click(object sender, EventArgs e)
        {
            FrmConcreteSalesInvoice fcsi = new FrmConcreteSalesInvoice();
            fcsi.ShowDialog();
        }

        private void rbecarrierSubmit_Click(object sender, EventArgs e)
        {
            FrmCarrierSubmit fcs = new FrmCarrierSubmit();
            fcs.ShowDialog();
        }

        private void rbeCustomerManage_Click(object sender, EventArgs e)
        {
            FrmCustomerManage fcm = new FrmCustomerManage();
            fcm.ShowDialog();
        }

        private void rbeMixerManage_Click(object sender, EventArgs e)
        {
            FrmMixerManage fmm = new FrmMixerManage();
            fmm.ShowDialog();
        }

        private void rbeCarrierManage_Click(object sender, EventArgs e)
        {
            FrmCarrierManage fcm = new FrmCarrierManage();
            fcm.ShowDialog();
        }

        private void rbeConcreteTypeManage_Click(object sender, EventArgs e)
        {
            FrmConcreteTypeManage fctm = new FrmConcreteTypeManage();
            fctm.ShowDialog();
        }

        private void rbeCompanySubbmit_Click(object sender, EventArgs e)
        {
            FrmCompanySubmit fCs1 = new FrmCompanySubmit();
            fCs1.ShowDialog();
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            FrmConcreteTypeManage fctm1 = new FrmConcreteTypeManage();
            fctm1.ShowDialog();
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            FrmConcreteTypeSubmit fcts1 = new FrmConcreteTypeSubmit();
            fcts1.ShowDialog();
        }

        private void rbeCompanyManaage_Click(object sender, EventArgs e)
        {
            FrmCompanyManage fcm2 = new FrmCompanyManage();
            fcm2.ShowDialog();

        }
    }
}
