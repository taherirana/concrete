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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Frm_Main f1 = new Frm_Main();
            this.Hide();
            f1.ShowDialog();
            
           
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2)
            {
                // AddToDatagrid();
            }
            else if (keyData == Keys.Escape)
            {
                Application.Exit();
            }
            else if (keyData == Keys.Enter)
            {

                this.ProcessTabKey(true);
            }
            return false;
        }
    }
}
