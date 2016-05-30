namespace Concrete
{
    partial class Frm_SabtCustomer
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
            this.components = new System.ComponentModel.Container();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_tell = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtKmeli = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lstAddresses = new System.Windows.Forms.ListBox();
            this.btnAddAddress = new Telerik.WinControls.UI.RadButton();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(747, 39);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(31, 26);
            this.lblFirstName.TabIndex = 100;
            this.lblFirstName.Text = "نام:";
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnAddAddress);
            this.grpMain.Controls.Add(this.lstAddresses);
            this.grpMain.Controls.Add(this.btnCancel);
            this.grpMain.Controls.Add(this.btnSubmit);
            this.grpMain.Controls.Add(this.txt_address);
            this.grpMain.Controls.Add(this.txt_mobile);
            this.grpMain.Controls.Add(this.txt_tell);
            this.grpMain.Controls.Add(this.lblMobile);
            this.grpMain.Controls.Add(this.txtKmeli);
            this.grpMain.Controls.Add(this.txtFamily);
            this.grpMain.Controls.Add(this.txtName);
            this.grpMain.Controls.Add(this.lblNationalCode);
            this.grpMain.Controls.Add(this.lblPhone);
            this.grpMain.Controls.Add(this.lblAddress);
            this.grpMain.Controls.Add(this.lblLastName);
            this.grpMain.Controls.Add(this.lblFirstName);
            this.grpMain.Location = new System.Drawing.Point(1, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(791, 380);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "ثبت مشتری";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnCancel.Location = new System.Drawing.Point(570, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 27);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "انصراف Esc";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnCancel.GetChildAt(0))).Text = "انصراف Esc";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnSubmit.Location = new System.Drawing.Point(653, 347);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 27);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "ثبت F2";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Text = "ثبت F2";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(102, 188);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(629, 33);
            this.txt_address.TabIndex = 5;
            this.txt_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_address_KeyPress);
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(259, 104);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(180, 33);
            this.txt_mobile.TabIndex = 4;
            this.txt_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobile_KeyPress);
            // 
            // txt_tell
            // 
            this.txt_tell.Location = new System.Drawing.Point(551, 104);
            this.txt_tell.Name = "txt_tell";
            this.txt_tell.Size = new System.Drawing.Size(180, 33);
            this.txt_tell.TabIndex = 3;
            this.txt_tell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tell_KeyPress);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(460, 107);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(50, 26);
            this.lblMobile.TabIndex = 108;
            this.lblMobile.Text = "موبایل:";
            // 
            // txtKmeli
            // 
            this.txtKmeli.Location = new System.Drawing.Point(12, 36);
            this.txtKmeli.Name = "txtKmeli";
            this.txtKmeli.Size = new System.Drawing.Size(180, 33);
            this.txtKmeli.TabIndex = 2;
            this.txtKmeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKmeli_KeyPress);
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(259, 36);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(180, 33);
            this.txtFamily.TabIndex = 1;
            this.txtFamily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFamily_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(551, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 33);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(193, 43);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(52, 26);
            this.lblNationalCode.TabIndex = 104;
            this.lblNationalCode.Text = "کدملی:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(741, 107);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 26);
            this.lblPhone.TabIndex = 103;
            this.lblPhone.Text = "تلفن:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(737, 191);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 26);
            this.lblAddress.TabIndex = 102;
            this.lblAddress.Text = "آدرس:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(442, 43);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 26);
            this.lblLastName.TabIndex = 101;
            this.lblLastName.Text = "نام خانوادگی:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lstAddresses
            // 
            this.lstAddresses.FormattingEnabled = true;
            this.lstAddresses.ItemHeight = 26;
            this.lstAddresses.Location = new System.Drawing.Point(102, 228);
            this.lstAddresses.Name = "lstAddresses";
            this.lstAddresses.Size = new System.Drawing.Size(627, 82);
            this.lstAddresses.TabIndex = 1111;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnAddAddress.Location = new System.Drawing.Point(20, 192);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(76, 27);
            this.btnAddAddress.TabIndex = 6;
            this.btnAddAddress.Text = "افزودن F1";
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnAddAddress.GetChildAt(0))).Text = "افزودن F1";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnAddAddress.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnAddAddress.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnAddAddress.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnAddAddress.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            // 
            // Frm_SabtCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 409);
            this.ControlBox = false;
            this.Controls.Add(this.grpMain);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_SabtCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت مشتری";
            this.Load += new System.EventHandler(this.Frm_SabtCustomer_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtKmeli;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_tell;
        private System.Windows.Forms.Label lblMobile;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lstAddresses;
        private Telerik.WinControls.UI.RadButton btnAddAddress;
    }
}