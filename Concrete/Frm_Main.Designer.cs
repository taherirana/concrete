namespace Concrete
{
    partial class Frm_Main
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
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.rmi_tarifavaliye = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem3 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuSeparatorItem4 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radRibbonBarGroup5 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.rbeCompanySubmit = new Telerik.WinControls.UI.RadButtonElement();
            this.rbeCompanyManage = new Telerik.WinControls.UI.RadButtonElement();
            this.rbe_sabtCustomer = new Telerik.WinControls.UI.RadButtonElement();
            this.rbeCustomerManage = new Telerik.WinControls.UI.RadButtonElement();
            this.rbe_SabtMixer = new Telerik.WinControls.UI.RadButtonElement();
            this.rbeMixerManage = new Telerik.WinControls.UI.RadButtonElement();
            this.rbecarrierSubmit = new Telerik.WinControls.UI.RadButtonElement();
            this.rbeCarrierManage = new Telerik.WinControls.UI.RadButtonElement();
            this.rbe_SabtAConcreate = new Telerik.WinControls.UI.RadButtonElement();
            this.rbeConcreteTypeManage = new Telerik.WinControls.UI.RadButtonElement();
            this.rbe_SInvoice = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2,
            this.ribbonTab3});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.Size = new System.Drawing.Size(1104, 172);
            this.radRibbonBar1.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmi_tarifavaliye,
            this.radMenuSeparatorItem2,
            this.radMenuItem2});
            this.radRibbonBar1.StartMenuRightColumnItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuSeparatorItem4});
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "Frm_Main";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup5,
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3,
            this.radRibbonBarGroup4});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "تعاریف اولیه";
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.AutoSize = false;
            this.radRibbonBarGroup2.Bounds = new System.Drawing.Rectangle(0, 0, 155, 100);
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rbe_sabtCustomer,
            this.rbeCustomerManage});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "مشتری";
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.AutoSize = false;
            this.radRibbonBarGroup3.Bounds = new System.Drawing.Rectangle(0, 0, 307, 100);
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rbe_SabtMixer,
            this.rbeMixerManage,
            this.rbecarrierSubmit,
            this.rbeCarrierManage});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "میکسر ---- Carrier";
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.AutoSize = false;
            this.radRibbonBarGroup4.Bounds = new System.Drawing.Rectangle(0, 0, 160, 100);
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rbe_SabtAConcreate,
            this.rbeConcreteTypeManage});
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "بتن";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "خرید";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.IsSelected = false;
            this.ribbonTab3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "فروش";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AutoSize = false;
            this.radRibbonBarGroup1.Bounds = new System.Drawing.Rectangle(0, 0, 150, 97);
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rbe_SInvoice});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "ثبت فاکتور";
            // 
            // rmi_tarifavaliye
            // 
            this.rmi_tarifavaliye.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuSeparatorItem1});
            this.rmi_tarifavaliye.Name = "rmi_tarifavaliye";
            this.rmi_tarifavaliye.Text = "تعاریف اولیه";
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuSeparatorItem3});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "خرید";
            // 
            // radMenuSeparatorItem3
            // 
            this.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuSeparatorItem4
            // 
            this.radMenuSeparatorItem4.Name = "radMenuSeparatorItem4";
            this.radMenuSeparatorItem4.Text = "radMenuSeparatorItem4";
            this.radMenuSeparatorItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radRibbonBarGroup5
            // 
            this.radRibbonBarGroup5.AutoSize = false;
            this.radRibbonBarGroup5.Bounds = new System.Drawing.Rectangle(0, 0, 155, 97);
            this.radRibbonBarGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rbeCompanySubmit,
            this.rbeCompanyManage});
            this.radRibbonBarGroup5.Name = "radRibbonBarGroup5";
            this.radRibbonBarGroup5.Text = "ثبت اطلاعات شرکت";
            // 
            // rbeCompanySubmit
            // 
            this.rbeCompanySubmit.AutoSize = false;
            this.rbeCompanySubmit.Bounds = new System.Drawing.Rectangle(0, 0, 75, 75);
            this.rbeCompanySubmit.Image = global::Concrete.Properties.Resources._1464208647_home;
            this.rbeCompanySubmit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbeCompanySubmit.Name = "rbeCompanySubmit";
            this.rbeCompanySubmit.Text = "ثبت شرکت";
            this.rbeCompanySubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // rbeCompanyManage
            // 
            this.rbeCompanyManage.AutoSize = false;
            this.rbeCompanyManage.Bounds = new System.Drawing.Rectangle(0, 0, 74, 75);
            this.rbeCompanyManage.Image = global::Concrete.Properties.Resources._1464178473_setting;
            this.rbeCompanyManage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbeCompanyManage.Name = "rbeCompanyManage";
            this.rbeCompanyManage.Text = "مدیریت شرکت";
            this.rbeCompanyManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // rbe_sabtCustomer
            // 
            this.rbe_sabtCustomer.AutoSize = false;
            this.rbe_sabtCustomer.Bounds = new System.Drawing.Rectangle(0, 0, 75, 75);
            this.rbe_sabtCustomer.Image = global::Concrete.Properties.Resources._1464176801_add_user;
            this.rbe_sabtCustomer.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbe_sabtCustomer.Name = "rbe_sabtCustomer";
            this.rbe_sabtCustomer.Text = "ثبت مشتری";
            this.rbe_sabtCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbe_sabtCustomer.Click += new System.EventHandler(this.rbe_sabtCustomer_Click);
            // 
            // rbeCustomerManage
            // 
            this.rbeCustomerManage.AutoSize = false;
            this.rbeCustomerManage.Bounds = new System.Drawing.Rectangle(0, 0, 75, 75);
            this.rbeCustomerManage.Image = global::Concrete.Properties.Resources._1464176811_edit_user;
            this.rbeCustomerManage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbeCustomerManage.Name = "rbeCustomerManage";
            this.rbeCustomerManage.Text = "مدیریت مشتری";
            this.rbeCustomerManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbeCustomerManage.Click += new System.EventHandler(this.rbeCustomerManage_Click);
            // 
            // rbe_SabtMixer
            // 
            this.rbe_SabtMixer.AutoSize = true;
            this.rbe_SabtMixer.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.rbe_SabtMixer.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.rbe_SabtMixer.Image = global::Concrete.Properties.Resources.mixer21;
            this.rbe_SabtMixer.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbe_SabtMixer.Name = "rbe_SabtMixer";
            this.rbe_SabtMixer.Text = "ثبت میکسر";
            this.rbe_SabtMixer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbe_SabtMixer.Click += new System.EventHandler(this.rbe_SabtMixer_Click);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.rbe_SabtMixer.GetChildAt(1).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.rbe_SabtMixer.GetChildAt(1).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            // 
            // rbeMixerManage
            // 
            this.rbeMixerManage.AutoSize = false;
            this.rbeMixerManage.Bounds = new System.Drawing.Rectangle(0, 0, 75, 75);
            this.rbeMixerManage.Image = global::Concrete.Properties.Resources._1464178473_setting;
            this.rbeMixerManage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbeMixerManage.Name = "rbeMixerManage";
            this.rbeMixerManage.Text = "مدیریت میکسر";
            this.rbeMixerManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbeMixerManage.Click += new System.EventHandler(this.rbeMixerManage_Click);
            // 
            // rbecarrierSubmit
            // 
            this.rbecarrierSubmit.AutoSize = false;
            this.rbecarrierSubmit.Bounds = new System.Drawing.Rectangle(0, 0, 75, 75);
            this.rbecarrierSubmit.Image = global::Concrete.Properties.Resources.Foden_Concrete_Truck;
            this.rbecarrierSubmit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbecarrierSubmit.Name = "rbecarrierSubmit";
            this.rbecarrierSubmit.Text = "ثبت carrier";
            this.rbecarrierSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbecarrierSubmit.Click += new System.EventHandler(this.rbecarrierSubmit_Click);
            // 
            // rbeCarrierManage
            // 
            this.rbeCarrierManage.AutoSize = false;
            this.rbeCarrierManage.Bounds = new System.Drawing.Rectangle(0, 0, 75, 75);
            this.rbeCarrierManage.Image = global::Concrete.Properties.Resources._1464178473_setting;
            this.rbeCarrierManage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbeCarrierManage.Name = "rbeCarrierManage";
            this.rbeCarrierManage.Text = "مدیریت carrier";
            this.rbeCarrierManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbeCarrierManage.Click += new System.EventHandler(this.rbeCarrierManage_Click);
            // 
            // rbe_SabtAConcreate
            // 
            this.rbe_SabtAConcreate.AutoSize = false;
            this.rbe_SabtAConcreate.Bounds = new System.Drawing.Rectangle(0, 0, 75, 75);
            this.rbe_SabtAConcreate.Image = global::Concrete.Properties.Resources.new1;
            this.rbe_SabtAConcreate.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbe_SabtAConcreate.Name = "rbe_SabtAConcreate";
            this.rbe_SabtAConcreate.Text = "ثبت نوع بتن";
            this.rbe_SabtAConcreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbe_SabtAConcreate.Click += new System.EventHandler(this.rbe_SabtAConcreate_Click);
            // 
            // rbeConcreteTypeManage
            // 
            this.rbeConcreteTypeManage.AutoSize = false;
            this.rbeConcreteTypeManage.Bounds = new System.Drawing.Rectangle(0, 0, 80, 75);
            this.rbeConcreteTypeManage.Image = global::Concrete.Properties.Resources._1464178473_setting;
            this.rbeConcreteTypeManage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbeConcreteTypeManage.Name = "rbeConcreteTypeManage";
            this.rbeConcreteTypeManage.Text = "مدیریت نوع بتن";
            this.rbeConcreteTypeManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbeConcreteTypeManage.Click += new System.EventHandler(this.rbeConcreteTypeManage_Click);
            // 
            // rbe_SInvoice
            // 
            this.rbe_SInvoice.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbe_SInvoice.Image = global::Concrete.Properties.Resources.eTMox9jTn;
            this.rbe_SInvoice.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbe_SInvoice.Name = "rbe_SInvoice";
            this.rbe_SInvoice.Text = "ثبت فاکتور فروش";
            this.rbe_SInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbe_SInvoice.Click += new System.EventHandler(this.rbe_SInvoice_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 634);
            this.Controls.Add(this.radRibbonBar1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.UI.RadMenuItem rmi_tarifavaliye;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem3;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem4;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement rbe_sabtCustomer;
        private Telerik.WinControls.UI.RadButtonElement rbe_SabtMixer;
        private Telerik.WinControls.UI.RadButtonElement rbe_SabtAConcreate;
        private Telerik.WinControls.UI.RadButtonElement rbe_SInvoice;
        private Telerik.WinControls.UI.RadButtonElement rbecarrierSubmit;
        private Telerik.WinControls.UI.RadButtonElement rbeCustomerManage;
        private Telerik.WinControls.UI.RadButtonElement rbeMixerManage;
        private Telerik.WinControls.UI.RadButtonElement rbeCarrierManage;
        private Telerik.WinControls.UI.RadButtonElement rbeConcreteTypeManage;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup5;
        private Telerik.WinControls.UI.RadButtonElement rbeCompanySubmit;
        private Telerik.WinControls.UI.RadButtonElement rbeCompanyManage;
    }
}