using DevExpress.XtraBars.Ribbon;
using Ordi.Utils.Data;
using Ordi.Utils.Funcs;
using System;
using System.Reflection;

namespace Ordi.App
{
    public partial class FmMain : RibbonForm
    {
        public FmMain()
        {
            InitializeComponent();
            rbcMain.Toolbar.ShowCustomizeItem = false;
        }

        private void TrTimepiece_Tick(object sender, System.EventArgs e)
        {
            barTime.Caption = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void FmMenu_Load(object sender, EventArgs e)
        {
            TopMost = false;

            OrdiMsg.SetHandle(this);

            InitializeMenus();

            //FmTest fm2 = new FmTest();
            //fm2.MdiParent = this;
            //fm2.Show();

            //FmTest2 fm3 = new FmTest2();
            //fm3.MdiParent = this;
            //fm3.Show();
            //xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[fm3];

            FmTest fm = new FmTest();

            RibbonPage _RibbonPage = new RibbonPage(fm.Text);//创建一个新RibbonPage 

            FieldInfo[] fi = fm.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo pFieldInfo in fi)
            {
                if (pFieldInfo.FieldType.Equals(typeof(RibbonControl)))
                {
                    try
                    {
                        RibbonControl ribbon = pFieldInfo.GetValue(fm) as RibbonControl;
                        ribbon.Toolbar.ShowCustomizeItem = false;
                        ribbon.ShowToolbarCustomizeItem = false;
                        _RibbonPage = ribbon.Pages[0];
                        _RibbonPage.Text = fm.Text;

                        this.rbcMain.Pages.Add(_RibbonPage);
                    }
                    catch (Exception ex)
                    { throw ex; }
                }
            }

            rbcMain.SelectedPage = _RibbonPage;
            fm.TopLevel = false;
            fm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fm.Dock = System.Windows.Forms.DockStyle.Fill;
            fm.Parent = this;
            fm.Show();
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

        private void RibbonControl1_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e)
        {

        }

        private void RibbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {

        }
    }
}
