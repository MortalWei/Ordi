using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.NativeMdi;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using Ordi.App.Menus;
using Ordi.Utils.Data;
using Ordi.Utils.Funcs;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Ordi.App
{
    /// <summary>
    /// 主界面
    /// </summary>
    public partial class FmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /// <summary>
        /// 默认构造
        /// </summary>
        public FmMain()
        {
            InitializeComponent();
        }

        private void TrTimepiece_Tick(object sender, System.EventArgs e)
        {
            BarTime.Caption = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void FmMenu_Load(object sender, EventArgs e)
        {
            TopMost = false;

            //dmMain.View = new NativeMdiView();

            //设置弹出框句柄
            OrdiMsg.SetHandle(this);
            //加载菜单信息

            //加载插件信息

            //加载配置信息

            //加载首页(若有首页)

            FmTest fm = new FmTest
            {
                MdiParent = this
            };
            fm.Show();

            FmTest2 fm2 = new FmTest2
            {
                MdiParent = this
            };
            fm2.Show();






            //FmTest fm = new FmTest();

            //RibbonPage _RibbonPage = new RibbonPage(fm.Text);//创建一个新RibbonPage 

            //FieldInfo[] fi = fm.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            //foreach (FieldInfo pFieldInfo in fi)
            //{
            //    if (pFieldInfo.FieldType.Equals(typeof(RibbonControl)))
            //    {
            //        try
            //        {
            //            RibbonControl ribbon = pFieldInfo.GetValue(fm) as RibbonControl;
            //            ribbon.Toolbar.ShowCustomizeItem = false;
            //            ribbon.ShowToolbarCustomizeItem = false;
            //            _RibbonPage = ribbon.Pages[0];
            //            _RibbonPage.Text = fm.Text;

            //            this.RcMain.Pages.Add(_RibbonPage);
            //        }
            //        catch (Exception ex)
            //        { throw ex; }
            //    }
            //}

            //RcMain.SelectedPage = _RibbonPage;

            //XtraTabPage page = new XtraTabPage()
            //{
            //    Text = fm.Text,
            //};

            //Text = "Ordi-" + fm.Text;

            //fm.TopLevel = false;
            //fm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //fm.Dock = System.Windows.Forms.DockStyle.Fill;
            //fm.Parent = page;
            //fm.Show();

            //TabMain.TabPages.Add(page);
            //TabMain.SelectedTabPage = page;
        }

        /// <summary>
        /// 初始化菜单列表
        /// </summary>
        private void InitializeMenus()
        {
            OrdiVar.Menus.ForEach(menu =>
            {
                RibbonPageGroup pageGroup = new RibbonPageGroup(menu.ShowName);
            });
        }

        /// <summary>
        /// Ribbon菜单切换中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcMain_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e)
        {

        }

        /// <summary>
        /// Ribbon菜单切换后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcMain_SelectedPageChanged(object sender, EventArgs e)
        {
            PageSwitch();
        }

        /// <summary>
        /// Page切换
        /// </summary>
        private void PageSwitch()
        {
            //if (RcMain.SelectedPage == null) return;
            //if (RcMain.SelectedPage.Equals(RbgHome))
            //{
            //    TabMain.SelectedTabPage = tpHome;
            //}
            //else if (RcMain.SelectedPage.Equals(RgMaintain))
            //{
            //    TabMain.SelectedTabPage = tpMaintain;
            //}

            //Text = "Ordi-" + RcMain.SelectedPage.Text ?? RcMain.SelectedPage.Name;
        }

        /// <summary>
        /// 菜单管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarBtnMenuMaintain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var _View = dmMain.View as DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView;

            var _Count = _View.Documents;

            _View.Controller.Activate(_View.Documents[0]);
            //dmMain.View
            //var menu = OrdiVar.Menus.Find(c => c.Id == "E5B7F101-B0DE-481C-ABA6-12DACF8C20DF");
            //if (OrdiVar.OpenedMenus == null) OrdiVar.OpenedMenus = new List<Entities.MenuModel>();
            //OrdiVar.OpenedMenus.Add(menu);

            //FmMenuMaintain fm = new FmMenuMaintain();
            //RibbonPage _RibbonPage = new RibbonPage(fm.Text) { Tag = menu };//创建一个新RibbonPage 

            //FieldInfo[] fi = fm.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            //foreach (FieldInfo pFieldInfo in fi)
            //{
            //    if (pFieldInfo.FieldType.Equals(typeof(RibbonControl)))
            //    {
            //        try
            //        {
            //            RibbonControl ribbon = pFieldInfo.GetValue(fm) as RibbonControl;
            //            ribbon.Toolbar.ShowCustomizeItem = false;
            //            ribbon.ShowToolbarCustomizeItem = false;
            //            _RibbonPage = ribbon.Pages[0];
            //            _RibbonPage.Text = fm.Text;

            //            this.RcMain.Pages.Add(_RibbonPage);
            //        }
            //        catch (Exception ex)
            //        {
            //            throw ex;
            //        }
            //    }
            //}

            //RcMain.SelectedPage = _RibbonPage;

            //XtraTabPage page = new XtraTabPage()
            //{
            //    Text = fm.Text,
            //};

            //Text = "Ordi-" + fm.Text;

            //fm.TopLevel = false;
            //fm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //fm.Dock = System.Windows.Forms.DockStyle.Fill;
            //fm.Parent = page;
            //fm.Show();

            //TabMain.TabPages.Add(page);
            //TabMain.SelectedTabPage = page;

        }

        /// <summary>
        /// 插件管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarBtnPluginMaintain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var _View = dmMain.View as DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView;

            var _Count = _View.Documents;

            _View.Controller.Activate(_View.Documents[1]);
        }

        /// <summary>
        /// 配置管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarBtnCfgMaintain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var _View = dmMain.View as DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView;

            var _Count = _View.Documents;
            
            

            //_View.Controller.Activate(_View.Documents[1]);
            
            //var menu = OrdiVar.Menus.Find(c => c.Id == "41C3D7A9-4274-4C8E-B306-2C6C43133886");
            //if (OrdiVar.OpenedMenus == null) OrdiVar.OpenedMenus = new List<Entities.MenuModel>();
            //OrdiVar.OpenedMenus.Add(menu);

            //FmCfgMaintain fm = new FmCfgMaintain();
            //RibbonPage _RibbonPage = new RibbonPage(fm.Text) { Tag = menu };//创建一个新RibbonPage 

            //FieldInfo[] fi = fm.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            //foreach (FieldInfo pFieldInfo in fi)
            //{
            //    if (pFieldInfo.FieldType.Equals(typeof(RibbonControl)))
            //    {
            //        try
            //        {
            //            RibbonControl ribbon = pFieldInfo.GetValue(fm) as RibbonControl;
            //            ribbon.Toolbar.ShowCustomizeItem = false;
            //            ribbon.ShowToolbarCustomizeItem = false;
            //            _RibbonPage = ribbon.Pages[0];
            //            _RibbonPage.Text = fm.Text;

            //            ribbon.Visible = false;
            //            this.RcMain.Pages.Add(_RibbonPage);
            //        }
            //        catch (Exception ex)
            //        {
            //            throw ex;
            //        }
            //    }
            //}

            //RcMain.SelectedPage = _RibbonPage;

            //XtraTabPage page = new XtraTabPage()
            //{
            //    Text = fm.Text,
            //    BackColor = System.Drawing.Color.Blue
            //};

            //PanelControl panel = new PanelControl { BackColor = System.Drawing.Color.White };
            //page.Controls.Add(panel);

            //Text = "Ordi-" + fm.Text;

            //fm.TopLevel = false;
            //fm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //fm.Parent = panel;
            ////panel.Controls.Add(fm);
            //fm.Show();
            //fm.Dock = System.Windows.Forms.DockStyle.Fill;

            //TabMain.TabPages.Add(page);
            //TabMain.SelectedTabPage = page;

        }

        private void RcMain_Merge(object sender, RibbonMergeEventArgs e)
        {
            RibbonControl parentRRibbon = sender as RibbonControl;
            RibbonControl childRibbon = e.MergedChild;
            parentRRibbon.StatusBar.MergeStatusBar(childRibbon.StatusBar);
        }

        private void RcMain_UnMerge(object sender, RibbonMergeEventArgs e)
        {
            RibbonControl parentRRibbon = sender as RibbonControl;
            parentRRibbon.StatusBar.UnMergeStatusBar();
        }
    }
}
