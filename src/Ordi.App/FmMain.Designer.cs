namespace Ordi.App
{
    partial class FmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.rbcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barTime = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.rbgMenu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.TrTimepiece = new System.Windows.Forms.Timer();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.rbcMain)).BeginInit();
            this.SuspendLayout();
            // 
            // rbcMain
            // 
            this.rbcMain.ButtonGroupsLayout = DevExpress.XtraBars.ButtonGroupsLayout.ThreeRows;
            this.rbcMain.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.rbcMain.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.rbcMain.DrawGroupsBorder = false;
            this.rbcMain.ExpandCollapseItem.Id = 0;
            this.rbcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbcMain.ExpandCollapseItem,
            this.barTime,
            this.barButtonItem1,
            this.barButtonItem2});
            this.rbcMain.ItemsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.rbcMain.Location = new System.Drawing.Point(0, 0);
            this.rbcMain.MaxItemId = 4;
            this.rbcMain.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Never;
            this.rbcMain.Name = "rbcMain";
            this.rbcMain.OptionsAnimation.PageCategoryShowAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.rbcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbgMenu,
            this.ribbonPage1});
            this.rbcMain.QuickToolbarItemLinks.Add(this.barButtonItem1);
            this.rbcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.rbcMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.rbcMain.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.rbcMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.rbcMain.ShowQatLocationSelector = false;
            this.rbcMain.ShowToolbarCustomizeItem = false;
            this.rbcMain.Size = new System.Drawing.Size(990, 126);
            this.rbcMain.StatusBar = this.ribbonStatusBar1;
            this.rbcMain.Toolbar.ShowCustomizeItem = false;
            this.rbcMain.SelectedPageChanging += new DevExpress.XtraBars.Ribbon.RibbonPageChangingEventHandler(this.RibbonControl1_SelectedPageChanging);
            this.rbcMain.SelectedPageChanged += new System.EventHandler(this.RibbonControl1_SelectedPageChanged);
            // 
            // barTime
            // 
            this.barTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barTime.Caption = "0000-00-00 00:00:00";
            this.barTime.Id = 1;
            this.barTime.Name = "barTime";
            this.barTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // rbgMenu
            // 
            this.rbgMenu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbgMenu.Name = "rbgMenu";
            this.rbgMenu.Text = "菜单";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barTime);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 664);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.rbcMain;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(990, 31);
            // 
            // TrTimepiece
            // 
            this.TrTimepiece.Enabled = true;
            this.TrTimepiece.Interval = 1000;
            this.TrTimepiece.Tick += new System.EventHandler(this.TrTimepiece_Tick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "配置";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // FmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 695);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.rbcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmMain";
            this.Ribbon = this.rbcMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbcMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbcMain;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarStaticItem barTime;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Timer TrTimepiece;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbgMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

