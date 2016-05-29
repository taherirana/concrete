﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concrete
{
    public partial class FrmCompanyManage : Form
    {
        public FrmCompanyManage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCompanyManage_Load(object sender, EventArgs e)
        {
            language.Persian();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSubmit.Enabled = false;
            txtCompany.Enabled = false;
            txtTell.Enabled = false;
            txtFox.Enabled = false;
            txtAddress.Enabled = false;

        }
    }
}
