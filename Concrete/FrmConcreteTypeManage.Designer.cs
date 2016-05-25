namespace Concrete
{
    partial class FrmConcreteTypeManage
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
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtconcretePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconcretetype = new System.Windows.Forms.TextBox();
            this.lblconcretetype = new System.Windows.Forms.Label();
            this.dgwConcreteType = new System.Windows.Forms.DataGridView();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConcreteType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnCancel.Location = new System.Drawing.Point(54, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 27);
            this.btnCancel.TabIndex = 6;
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
            this.btnSubmit.Location = new System.Drawing.Point(136, 147);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 27);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "ثبت";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Text = "ثبت";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtconcretePrice);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtconcretetype);
            this.groupBox1.Controls.Add(this.lblconcretetype);
            this.groupBox1.Location = new System.Drawing.Point(2, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 192);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات نوع بتن";
            // 
            // txtconcretePrice
            // 
            this.txtconcretePrice.Location = new System.Drawing.Point(13, 96);
            this.txtconcretePrice.Name = "txtconcretePrice";
            this.txtconcretePrice.Size = new System.Drawing.Size(180, 31);
            this.txtconcretePrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(226, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "مبلغ:";
            // 
            // txtconcretetype
            // 
            this.txtconcretetype.Location = new System.Drawing.Point(13, 42);
            this.txtconcretetype.Name = "txtconcretetype";
            this.txtconcretetype.Size = new System.Drawing.Size(180, 31);
            this.txtconcretetype.TabIndex = 3;
            // 
            // lblconcretetype
            // 
            this.lblconcretetype.AutoSize = true;
            this.lblconcretetype.Location = new System.Drawing.Point(212, 46);
            this.lblconcretetype.Name = "lblconcretetype";
            this.lblconcretetype.Size = new System.Drawing.Size(53, 24);
            this.lblconcretetype.TabIndex = 0;
            this.lblconcretetype.Text = "نوع بتن:";
            // 
            // dgwConcreteType
            // 
            this.dgwConcreteType.AllowUserToAddRows = false;
            this.dgwConcreteType.AllowUserToDeleteRows = false;
            this.dgwConcreteType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwConcreteType.Location = new System.Drawing.Point(2, 2);
            this.dgwConcreteType.Name = "dgwConcreteType";
            this.dgwConcreteType.ReadOnly = true;
            this.dgwConcreteType.Size = new System.Drawing.Size(287, 266);
            this.dgwConcreteType.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnDelete.Location = new System.Drawing.Point(56, 274);
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
            this.btnEdit.Location = new System.Drawing.Point(138, 274);
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
            // FrmConcreteTypeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 498);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgwConcreteType);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmConcreteTypeManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت اطلاعات نوع بتن";
            this.Load += new System.EventHandler(this.FrmConcreteTypeManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConcreteType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtconcretePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconcretetype;
        private System.Windows.Forms.Label lblconcretetype;
        private System.Windows.Forms.DataGridView dgwConcreteType;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnEdit;
    }
}