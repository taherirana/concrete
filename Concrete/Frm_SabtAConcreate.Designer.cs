namespace Concrete
{
    partial class Frm_SabtAConcreate
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
            this.lblconcretetype = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.txtconcretetype = new System.Windows.Forms.TextBox();
            this.txtconcretePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblconcretetype
            // 
            this.lblconcretetype.AutoSize = true;
            this.lblconcretetype.Location = new System.Drawing.Point(193, 40);
            this.lblconcretetype.Name = "lblconcretetype";
            this.lblconcretetype.Size = new System.Drawing.Size(63, 23);
            this.lblconcretetype.TabIndex = 0;
            this.lblconcretetype.Text = "نوع بتن:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtconcretePrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtconcretetype);
            this.groupBox1.Controls.Add(this.lblconcretetype);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت نوع بتن";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnCancel.Location = new System.Drawing.Point(12, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 24);
            this.btnCancel.TabIndex = 10;
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
            this.btnSubmit.Location = new System.Drawing.Point(107, 134);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(69, 24);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Text = "ثبت";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // txtconcretetype
            // 
            this.txtconcretetype.Location = new System.Drawing.Point(12, 37);
            this.txtconcretetype.Name = "txtconcretetype";
            this.txtconcretetype.Size = new System.Drawing.Size(164, 30);
            this.txtconcretetype.TabIndex = 7;
            // 
            // txtconcretePrice
            // 
            this.txtconcretePrice.Location = new System.Drawing.Point(12, 85);
            this.txtconcretePrice.Name = "txtconcretePrice";
            this.txtconcretePrice.Size = new System.Drawing.Size(164, 30);
            this.txtconcretePrice.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "مبلغ:";
            // 
            // Frm_SabtAConcreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 170);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_SabtAConcreate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت بتن";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblconcretetype;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtconcretetype;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private System.Windows.Forms.TextBox txtconcretePrice;
        private System.Windows.Forms.Label label1;
    }
}