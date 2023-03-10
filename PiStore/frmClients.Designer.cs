namespace PiStore
{
    partial class frmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnAddClient = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoveClient = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveClient = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshClient = new DevExpress.XtraBars.BarButtonItem();
            this.btnAutoGenerateClient = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridClient = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRemoveAllClient = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnAddClient,
            this.btnRemoveClient,
            this.btnSaveClient,
            this.btnRefreshClient,
            this.btnAutoGenerateClient,
            this.btnRemoveAllClient});
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddClient),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoveClient),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoveAllClient),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveClient),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefreshClient),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAutoGenerateClient)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Caption = "New";
            this.btnAddClient.Id = 0;
            this.btnAddClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.ImageOptions.Image")));
            this.btnAddClient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddClient.ImageOptions.LargeImage")));
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddClient_ItemClick);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Caption = "Remove";
            this.btnRemoveClient.Id = 1;
            this.btnRemoveClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveClient.ImageOptions.Image")));
            this.btnRemoveClient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveClient.ImageOptions.LargeImage")));
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRemoveClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoveClient_ItemClick);
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Caption = "Save";
            this.btnSaveClient.Id = 2;
            this.btnSaveClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClient.ImageOptions.Image")));
            this.btnSaveClient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveClient.ImageOptions.LargeImage")));
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSaveClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveClient_ItemClick);
            // 
            // btnRefreshClient
            // 
            this.btnRefreshClient.Caption = "Refresh";
            this.btnRefreshClient.Id = 3;
            this.btnRefreshClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshClient.ImageOptions.Image")));
            this.btnRefreshClient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshClient.ImageOptions.LargeImage")));
            this.btnRefreshClient.Name = "btnRefreshClient";
            this.btnRefreshClient.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefreshClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshClient_ItemClick);
            // 
            // btnAutoGenerateClient
            // 
            this.btnAutoGenerateClient.Caption = "Auto generate";
            this.btnAutoGenerateClient.Id = 4;
            this.btnAutoGenerateClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoGenerateClient.ImageOptions.Image")));
            this.btnAutoGenerateClient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAutoGenerateClient.ImageOptions.LargeImage")));
            this.btnAutoGenerateClient.Name = "btnAutoGenerateClient";
            this.btnAutoGenerateClient.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAutoGenerateClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAutoGenerateClient_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 656);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1200, 36);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 656);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1200, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 656);
            // 
            // gridClient
            // 
            this.gridClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClient.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridClient.Location = new System.Drawing.Point(0, 0);
            this.gridClient.MainView = this.gridView1;
            this.gridClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridClient.MenuManager = this.barManager1;
            this.gridClient.Name = "gridClient";
            this.gridClient.Size = new System.Drawing.Size(1200, 656);
            this.gridClient.TabIndex = 4;
            this.gridClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 538;
            this.gridView1.GridControl = this.gridClient;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnRemoveAllClient
            // 
            this.btnRemoveAllClient.Caption = "Remove all";
            this.btnRemoveAllClient.Id = 5;
            this.btnRemoveAllClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnRemoveAllClient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnRemoveAllClient.Name = "btnRemoveAllClient";
            this.btnRemoveAllClient.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRemoveAllClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoveAllClient_ItemClick);
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gridClient);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClients";
            this.Text = "frmClients";
            this.Load += new System.EventHandler(this.frmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAddClient;
        private DevExpress.XtraBars.BarButtonItem btnRemoveClient;
        private DevExpress.XtraBars.BarButtonItem btnSaveClient;
        private DevExpress.XtraBars.BarButtonItem btnRefreshClient;
        private DevExpress.XtraGrid.GridControl gridClient;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnAutoGenerateClient;
        private DevExpress.XtraBars.BarButtonItem btnRemoveAllClient;
    }
}