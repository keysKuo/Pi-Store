namespace PiStore
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAddProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoveProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAutoGenerateProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoveAllProduct = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProduct
            // 
            this.gridProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridProduct.Location = new System.Drawing.Point(0, 2);
            this.gridProduct.MainView = this.gridView1;
            this.gridProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(1200, 645);
            this.gridProduct.TabIndex = 0;
            this.gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 538;
            this.gridView1.GridControl = this.gridProduct;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddProduct,
            this.barButtonItem2,
            this.btnRemoveProduct,
            this.btnRefreshProduct,
            this.btnSaveProduct,
            this.btnAutoGenerateProduct,
            this.btnRemoveAllProduct});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.FloatLocation = new System.Drawing.Point(734, 582);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoveProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoveAllProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefreshProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAutoGenerateProduct)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Caption = "New";
            this.btnAddProduct.Id = 0;
            this.btnAddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.ImageOptions.Image")));
            this.btnAddProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.ImageOptions.LargeImage")));
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddProduct_ItemClick);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Caption = "Remove";
            this.btnRemoveProduct.Id = 2;
            this.btnRemoveProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveProduct.ImageOptions.Image")));
            this.btnRemoveProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveProduct.ImageOptions.LargeImage")));
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRemoveProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoveProduct_ItemClick);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Caption = "Save";
            this.btnSaveProduct.Id = 4;
            this.btnSaveProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.ImageOptions.Image")));
            this.btnSaveProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.ImageOptions.LargeImage")));
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSaveProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveProduct_ItemClick);
            // 
            // btnRefreshProduct
            // 
            this.btnRefreshProduct.Caption = "Refresh";
            this.btnRefreshProduct.Id = 3;
            this.btnRefreshProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshProduct.ImageOptions.Image")));
            this.btnRefreshProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshProduct.ImageOptions.LargeImage")));
            this.btnRefreshProduct.Name = "btnRefreshProduct";
            this.btnRefreshProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefreshProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshProduct_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1200, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 658);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1200, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 658);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1200, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 658);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Edit";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnAutoGenerateProduct
            // 
            this.btnAutoGenerateProduct.Caption = "Auto generate";
            this.btnAutoGenerateProduct.Id = 5;
            this.btnAutoGenerateProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image1")));
            this.btnAutoGenerateProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage1")));
            this.btnAutoGenerateProduct.Name = "btnAutoGenerateProduct";
            this.btnAutoGenerateProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAutoGenerateProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAutoGenerateProduct_ItemClick);
            // 
            // btnRemoveAllProduct
            // 
            this.btnRemoveAllProduct.Caption = "Remove all";
            this.btnRemoveAllProduct.Id = 6;
            this.btnRemoveAllProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnRemoveAllProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnRemoveAllProduct.Name = "btnRemoveAllProduct";
            this.btnRemoveAllProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRemoveAllProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoveAllProduct_ItemClick);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAddProduct;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnRemoveProduct;
        private DevExpress.XtraBars.BarButtonItem btnRefreshProduct;
        private DevExpress.XtraBars.BarButtonItem btnSaveProduct;
        private DevExpress.XtraBars.BarButtonItem btnAutoGenerateProduct;
        private DevExpress.XtraBars.BarButtonItem btnRemoveAllProduct;
    }
}