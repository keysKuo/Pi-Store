namespace PiStore
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grOrder = new DevExpress.XtraEditors.GroupControl();
            this.gridPlaceOrder = new DevExpress.XtraGrid.GridControl();
            this.gridViewPlaceOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grClient = new DevExpress.XtraEditors.GroupControl();
            this.gridClient = new DevExpress.XtraGrid.GridControl();
            this.gridViewClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grProduct = new DevExpress.XtraEditors.GroupControl();
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnSelectProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grOrder)).BeginInit();
            this.grOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlaceOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlaceOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grClient)).BeginInit();
            this.grClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grProduct)).BeginInit();
            this.grProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1167, 603);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grOrder);
            this.xtraTabPage1.Controls.Add(this.grClient);
            this.xtraTabPage1.Controls.Add(this.grProduct);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1165, 578);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // grOrder
            // 
            this.grOrder.AppearanceCaption.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grOrder.AppearanceCaption.Options.UseFont = true;
            this.grOrder.Controls.Add(this.gridPlaceOrder);
            this.grOrder.Location = new System.Drawing.Point(583, 4);
            this.grOrder.Name = "grOrder";
            this.grOrder.Size = new System.Drawing.Size(575, 324);
            this.grOrder.TabIndex = 4;
            this.grOrder.Text = "Place Order";
            // 
            // gridPlaceOrder
            // 
            this.gridPlaceOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPlaceOrder.Location = new System.Drawing.Point(2, 23);
            this.gridPlaceOrder.MainView = this.gridViewPlaceOrder;
            this.gridPlaceOrder.Name = "gridPlaceOrder";
            this.gridPlaceOrder.Size = new System.Drawing.Size(571, 299);
            this.gridPlaceOrder.TabIndex = 0;
            this.gridPlaceOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPlaceOrder});
            // 
            // gridViewPlaceOrder
            // 
            this.gridViewPlaceOrder.GridControl = this.gridPlaceOrder;
            this.gridViewPlaceOrder.Name = "gridViewPlaceOrder";
            this.gridViewPlaceOrder.OptionsView.ShowGroupPanel = false;
            // 
            // grClient
            // 
            this.grClient.AppearanceCaption.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grClient.AppearanceCaption.Options.UseFont = true;
            this.grClient.Controls.Add(this.gridClient);
            this.grClient.Location = new System.Drawing.Point(585, 334);
            this.grClient.Name = "grClient";
            this.grClient.Size = new System.Drawing.Size(573, 245);
            this.grClient.TabIndex = 2;
            this.grClient.Text = "Clients";
            // 
            // gridClient
            // 
            this.gridClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClient.Location = new System.Drawing.Point(2, 23);
            this.gridClient.MainView = this.gridViewClient;
            this.gridClient.Name = "gridClient";
            this.gridClient.Size = new System.Drawing.Size(569, 220);
            this.gridClient.TabIndex = 0;
            this.gridClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClient});
            // 
            // gridViewClient
            // 
            this.gridViewClient.GridControl = this.gridClient;
            this.gridViewClient.Name = "gridViewClient";
            // 
            // grProduct
            // 
            this.grProduct.AppearanceCaption.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProduct.AppearanceCaption.Options.UseFont = true;
            this.grProduct.Controls.Add(this.gridProduct);
            this.grProduct.Location = new System.Drawing.Point(3, 5);
            this.grProduct.Name = "grProduct";
            this.grProduct.Size = new System.Drawing.Size(574, 580);
            this.grProduct.TabIndex = 3;
            this.grProduct.Text = "Products";
            // 
            // gridProduct
            // 
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduct.Location = new System.Drawing.Point(2, 23);
            this.gridProduct.MainView = this.gridViewProduct;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(570, 555);
            this.gridProduct.TabIndex = 0;
            this.gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProduct});
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.GridControl = this.gridProduct;
            this.gridViewProduct.Name = "gridViewProduct";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1165, 578);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSelectProduct});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSelectProduct)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnSelectProduct
            // 
            this.btnSelectProduct.Caption = "Select";
            this.btnSelectProduct.Id = 0;
            this.btnSelectProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectProduct.ImageOptions.Image")));
            this.btnSelectProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSelectProduct.ImageOptions.LargeImage")));
            this.btnSelectProduct.Name = "btnSelectProduct";
            this.btnSelectProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSelectProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelectProduct_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1167, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 603);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1167, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 603);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1167, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 603);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 629);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grOrder)).EndInit();
            this.grOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPlaceOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlaceOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grClient)).EndInit();
            this.grClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grProduct)).EndInit();
            this.grProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl grOrder;
        private DevExpress.XtraGrid.GridControl gridPlaceOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPlaceOrder;
        private DevExpress.XtraEditors.GroupControl grProduct;
        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduct;
        private DevExpress.XtraEditors.GroupControl grClient;
        private DevExpress.XtraGrid.GridControl gridClient;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClient;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSelectProduct;
    }
}