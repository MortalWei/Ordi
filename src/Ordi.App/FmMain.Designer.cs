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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.RcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BarTime = new DevExpress.XtraBars.BarStaticItem();
            this.BarBtnRestart = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnMenuMaintain = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnPluginMaintain = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnCfgMaintain = new DevExpress.XtraBars.BarButtonItem();
            this.BarCompany = new DevExpress.XtraBars.BarStaticItem();
            this.RbgHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RbgMaintain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgMaintain = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RsTip = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.TrTimepiece = new System.Windows.Forms.Timer(this.components);
            this.dmMain = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.nativeMdiView1 = new DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nativeMdiView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RcMain
            // 
            this.RcMain.AllowMdiChildButtons = false;
            this.RcMain.AllowMinimizeRibbon = false;
            this.RcMain.ButtonGroupsLayout = DevExpress.XtraBars.ButtonGroupsLayout.ThreeRows;
            this.RcMain.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.RcMain.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.DrawGroupsBorder = false;
            this.RcMain.ExpandCollapseItem.Id = 0;
            this.RcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcMain.ExpandCollapseItem,
            this.BarTime,
            this.BarBtnRestart,
            this.BarBtnMenuMaintain,
            this.BarBtnPluginMaintain,
            this.BarBtnCfgMaintain,
            this.BarCompany});
            this.RcMain.ItemsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.RcMain.Location = new System.Drawing.Point(0, 0);
            this.RcMain.MaxItemId = 1;
            this.RcMain.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.RcMain.Name = "RcMain";
            this.RcMain.OptionsAnimation.PageCategoryShowAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RbgHome,
            this.RbgMaintain});
            this.RcMain.QuickToolbarItemLinks.Add(this.BarBtnRestart);
            this.RcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.RcMain.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.RcMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.RcMain.ShowQatLocationSelector = false;
            this.RcMain.ShowToolbarCustomizeItem = false;
            this.RcMain.Size = new System.Drawing.Size(790, 126);
            this.RcMain.StatusBar = this.RsTip;
            this.RcMain.Toolbar.ShowCustomizeItem = false;
            this.RcMain.SelectedPageChanging += new DevExpress.XtraBars.Ribbon.RibbonPageChangingEventHandler(this.RcMain_SelectedPageChanging);
            this.RcMain.SelectedPageChanged += new System.EventHandler(this.RcMain_SelectedPageChanged);
            this.RcMain.Merge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.RcMain_Merge);
            this.RcMain.UnMerge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.RcMain_UnMerge);
            // 
            // BarTime
            // 
            this.BarTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BarTime.Caption = "0000-00-00 00:00:00";
            this.BarTime.Id = 1;
            this.BarTime.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarTime.ImageOptions.Image")));
            this.BarTime.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BarTime.ImageOptions.LargeImage")));
            this.BarTime.Name = "BarTime";
            this.BarTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // BarBtnRestart
            // 
            this.BarBtnRestart.Caption = "重新启动";
            this.BarBtnRestart.Id = 2;
            this.BarBtnRestart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarBtnRestart.ImageOptions.Image")));
            this.BarBtnRestart.Name = "BarBtnRestart";
            // 
            // BarBtnMenuMaintain
            // 
            this.BarBtnMenuMaintain.Caption = "菜单管理";
            this.BarBtnMenuMaintain.Id = 4;
            this.BarBtnMenuMaintain.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarBtnMenuMaintain.ImageOptions.Image")));
            this.BarBtnMenuMaintain.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BarBtnMenuMaintain.ImageOptions.LargeImage")));
            this.BarBtnMenuMaintain.Name = "BarBtnMenuMaintain";
            this.BarBtnMenuMaintain.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnMenuMaintain_ItemClick);
            // 
            // BarBtnPluginMaintain
            // 
            this.BarBtnPluginMaintain.Caption = "插件管理";
            this.BarBtnPluginMaintain.Id = 5;
            this.BarBtnPluginMaintain.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarBtnPluginMaintain.ImageOptions.Image")));
            this.BarBtnPluginMaintain.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BarBtnPluginMaintain.ImageOptions.LargeImage")));
            this.BarBtnPluginMaintain.Name = "BarBtnPluginMaintain";
            this.BarBtnPluginMaintain.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnPluginMaintain_ItemClick);
            // 
            // BarBtnCfgMaintain
            // 
            this.BarBtnCfgMaintain.Caption = "配置管理";
            this.BarBtnCfgMaintain.Id = 6;
            this.BarBtnCfgMaintain.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarBtnCfgMaintain.ImageOptions.Image")));
            this.BarBtnCfgMaintain.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BarBtnCfgMaintain.ImageOptions.LargeImage")));
            this.BarBtnCfgMaintain.Name = "BarBtnCfgMaintain";
            this.BarBtnCfgMaintain.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnCfgMaintain_ItemClick);
            // 
            // BarCompany
            // 
            this.BarCompany.Caption = "Ordi";
            this.BarCompany.Id = 2;
            this.BarCompany.Name = "BarCompany";
            this.BarCompany.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // RbgHome
            // 
            this.RbgHome.Name = "RbgHome";
            this.RbgHome.Text = "首页";
            // 
            // RbgMaintain
            // 
            this.RbgMaintain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgMaintain});
            this.RbgMaintain.Name = "RbgMaintain";
            this.RbgMaintain.Text = "维护";
            // 
            // rpgMaintain
            // 
            this.rpgMaintain.ItemLinks.Add(this.BarBtnMenuMaintain);
            this.rpgMaintain.ItemLinks.Add(this.BarBtnPluginMaintain);
            this.rpgMaintain.ItemLinks.Add(this.BarBtnCfgMaintain);
            this.rpgMaintain.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.rpgMaintain.Name = "rpgMaintain";
            this.rpgMaintain.Text = "基础配置";
            // 
            // RsTip
            // 
            this.RsTip.ItemLinks.Add(this.BarTime);
            this.RsTip.ItemLinks.Add(this.BarCompany);
            this.RsTip.Location = new System.Drawing.Point(0, 568);
            this.RsTip.Name = "RsTip";
            this.RsTip.Ribbon = this.RcMain;
            this.RsTip.Size = new System.Drawing.Size(790, 31);
            // 
            // TrTimepiece
            // 
            this.TrTimepiece.Enabled = true;
            this.TrTimepiece.Interval = 1000;
            this.TrTimepiece.Tick += new System.EventHandler(this.TrTimepiece_Tick);
            // 
            // dmMain
            // 
            this.dmMain.MdiParent = this;
            this.dmMain.MenuManager = this.RcMain;
            this.dmMain.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.dmMain.View = this.nativeMdiView1;
            this.dmMain.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.nativeMdiView1});
            // 
            // nativeMdiView1
            // 
            this.nativeMdiView1.DocumentProperties.AllowClose = false;
            this.nativeMdiView1.DocumentProperties.AllowDock = false;
            this.nativeMdiView1.DocumentProperties.AllowFloat = false;
            this.nativeMdiView1.DocumentProperties.AllowMaximize = false;
            this.nativeMdiView1.DocumentProperties.ShowMaximizeButton = false;
            this.nativeMdiView1.LoadingIndicatorProperties.ShowCaption = false;
            this.nativeMdiView1.LoadingIndicatorProperties.ShowDescription = false;
            // 
            // FmMain
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.RsTip);
            this.Controls.Add(this.RcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FmMain";
            this.Ribbon = this.RcMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.RsTip;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nativeMdiView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl RcMain;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar RsTip;
        private DevExpress.XtraBars.BarStaticItem BarTime;
        private DevExpress.XtraBars.BarButtonItem BarBtnRestart;
        private System.Windows.Forms.Timer TrTimepiece;
        private DevExpress.XtraBars.Ribbon.RibbonPage RbgHome;
        private DevExpress.XtraBars.Ribbon.RibbonPage RgMaintain;
        private DevExpress.XtraBars.BarButtonItem BarBtnMenuMaintain;
        private DevExpress.XtraBars.BarButtonItem BarBtnCfgMaintain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgMaintain;
        private DevExpress.XtraBars.BarButtonItem BarBtnPluginMaintain;
        private DevExpress.XtraBars.BarStaticItem BarCompany;
        private DevExpress.XtraBars.Ribbon.RibbonPage RbgMaintain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgMaintain;
        private DevExpress.XtraBars.Docking2010.DocumentManager dmMain;
        private DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView nativeMdiView1;
    }
}

