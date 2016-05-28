namespace Concrete
{
    partial class FrmCompanyManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.dgwCompany = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblconcretetype = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompany)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnDelete.Location = new System.Drawing.Point(60, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDelete.GetChildAt(0))).Text = "حذف";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnEdit.Location = new System.Drawing.Point(142, 302);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 27);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "ویرایش";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEdit.GetChildAt(0))).Text = "ویرایش";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnEdit.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnEdit.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnEdit.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnEdit.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // dgwCompany
            // 
            this.dgwCompany.AllowUserToAddRows = false;
            this.dgwCompany.AllowUserToDeleteRows = false;
            this.dgwCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompany.Location = new System.Drawing.Point(9, 15);
            this.dgwCompany.Name = "dgwCompany";
            this.dgwCompany.ReadOnly = true;
            this.dgwCompany.Size = new System.Drawing.Size(287, 266);
            this.dgwCompany.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.lblconcretetype);
            this.groupBox1.Location = new System.Drawing.Point(6, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 132);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات شرکت";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnCancel.Location = new System.Drawing.Point(54, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 27);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnCancel.GetChildAt(0))).Text = "انصراف";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnSubmit.Location = new System.Drawing.Point(136, 90);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 27);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "ثبت";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Text = "ثبت";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(13, 42);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(180, 31);
            this.txtCompanyName.TabIndex = 3;
            // 
            // lblconcretetype
            // 
            this.lblconcretetype.AutoSize = true;
            this.lblconcretetype.Location = new System.Drawing.Point(212, 46);
            this.lblconcretetype.Name = "lblconcretetype";
            this.lblconcretetype.Size = new System.Drawing.Size(64, 24);
            this.lblconcretetype.TabIndex = 0;
            this.lblconcretetype.Text = "نام شرکت:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwCompany);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 501);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // FrmCompanyManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 501);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmCompanyManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت اطلاعات شرکت";
            this.Load += new System.EventHandler(this.FrmCompanyManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompany)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private System.Windows.Forms.DataGridView dgwCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblconcretetype;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}