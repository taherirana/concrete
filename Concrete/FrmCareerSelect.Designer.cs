﻿namespace Concrete
{
    partial class FrmCareerSelect
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.dgwCarrier = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCarrier = new System.Windows.Forms.ComboBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSelect = new Telerik.WinControls.UI.RadButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.dgwCarrier);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbCarrier);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 277);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجوی Carrier";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnSearch.Location = new System.Drawing.Point(52, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSearch.GetChildAt(0))).Text = "جستجو";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSearch.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSearch.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSearch.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSearch.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // dgwCarrier
            // 
            this.dgwCarrier.AllowUserToAddRows = false;
            this.dgwCarrier.AllowUserToDeleteRows = false;
            this.dgwCarrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCarrier.Location = new System.Drawing.Point(0, 81);
            this.dgwCarrier.Name = "dgwCarrier";
            this.dgwCarrier.ReadOnly = true;
            this.dgwCarrier.Size = new System.Drawing.Size(691, 157);
            this.dgwCarrier.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "جستجو:";
            // 
            // cmbCarrier
            // 
            this.cmbCarrier.FormattingEnabled = true;
            this.cmbCarrier.Items.AddRange(new object[] {
            "نام راننده",
            "نام خانوادگی راننده",
            "پلاک ماشین",
            "نوع مالکیت"});
            this.cmbCarrier.Location = new System.Drawing.Point(408, 44);
            this.cmbCarrier.Name = "cmbCarrier";
            this.cmbCarrier.Size = new System.Drawing.Size(180, 32);
            this.cmbCarrier.TabIndex = 0;
            this.cmbCarrier.Text = "انتخاب کنید...";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnCancel.Location = new System.Drawing.Point(287, 244);
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
            // btnSelect
            // 
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnSelect.Location = new System.Drawing.Point(369, 244);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(76, 27);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "انتخاب";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSelect.GetChildAt(0))).Text = "انتخاب";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSelect.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSelect.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSelect.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSelect.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(134, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 31);
            this.txtSearch.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(590, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "جستجو براساس:";
            // 
            // FrmCareerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 269);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmCareerSelect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب Career";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private System.Windows.Forms.DataGridView dgwCarrier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCarrier;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSelect;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
    }
}