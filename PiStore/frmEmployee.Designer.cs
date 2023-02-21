namespace PiStore
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnAddEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAutoGenerateEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoveAllEmployee = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
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
            this.btnAddEmployee,
            this.btnDeleteEmployee,
            this.btnSaveEmployee,
            this.btnRefreshEmployee,
            this.btnAutoGenerateEmployee,
            this.btnRemoveAllEmployee});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddEmployee),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteEmployee),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoveAllEmployee),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveEmployee),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefreshEmployee),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAutoGenerateEmployee)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Caption = "New";
            this.btnAddEmployee.Id = 0;
            this.btnAddEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.ImageOptions.Image")));
            this.btnAddEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.ImageOptions.LargeImage")));
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddEmployee_ItemClick);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Caption = "Remove";
            this.btnDeleteEmployee.Id = 1;
            this.btnDeleteEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.ImageOptions.Image")));
            this.btnDeleteEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.ImageOptions.LargeImage")));
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDeleteEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteEmployee_ItemClick);
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Caption = "Save";
            this.btnSaveEmployee.Id = 2;
            this.btnSaveEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveEmployee.ImageOptions.Image")));
            this.btnSaveEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveEmployee.ImageOptions.LargeImage")));
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSaveEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveEmployee_ItemClick);
            // 
            // btnRefreshEmployee
            // 
            this.btnRefreshEmployee.Caption = "Refresh";
            this.btnRefreshEmployee.Id = 3;
            this.btnRefreshEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshEmployee.ImageOptions.Image")));
            this.btnRefreshEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshEmployee.ImageOptions.LargeImage")));
            this.btnRefreshEmployee.Name = "btnRefreshEmployee";
            this.btnRefreshEmployee.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefreshEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshEmployee_ItemClick);
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
            // gridEmployee
            // 
            this.gridEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridEmployee.Location = new System.Drawing.Point(0, 0);
            this.gridEmployee.MainView = this.gridView1;
            this.gridEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridEmployee.MenuManager = this.barManager1;
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.Size = new System.Drawing.Size(1200, 656);
            this.gridEmployee.TabIndex = 4;
            this.gridEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 538;
            this.gridView1.GridControl = this.gridEmployee;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnAutoGenerateEmployee
            // 
            this.btnAutoGenerateEmployee.Caption = "Auto generate";
            this.btnAutoGenerateEmployee.Id = 4;
            this.btnAutoGenerateEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image1")));
            this.btnAutoGenerateEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage1")));
            this.btnAutoGenerateEmployee.Name = "btnAutoGenerateEmployee";
            this.btnAutoGenerateEmployee.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAutoGenerateEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAutoGenerateEmployee_ItemClick);
            // 
            // btnRemoveAllEmployee
            // 
            this.btnRemoveAllEmployee.Caption = "Remove all";
            this.btnRemoveAllEmployee.Id = 5;
            this.btnRemoveAllEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnRemoveAllEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnRemoveAllEmployee.Name = "btnRemoveAllEmployee";
            this.btnRemoveAllEmployee.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRemoveAllEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoveAllEmployee_ItemClick);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnAddEmployee;
        private DevExpress.XtraBars.BarButtonItem btnDeleteEmployee;
        private DevExpress.XtraBars.BarButtonItem btnSaveEmployee;
        private DevExpress.XtraBars.BarButtonItem btnRefreshEmployee;
        private DevExpress.XtraGrid.GridControl gridEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnAutoGenerateEmployee;
        private DevExpress.XtraBars.BarButtonItem btnRemoveAllEmployee;
    }
}