using DevExpress.XtraBars.Ribbon;
using System;
using System.Reflection;

namespace Ordi.App
{
    public partial class FmMenu : RibbonForm
    {
        public FmMenu()
        {
            InitializeComponent();
            ribbonControl1.Toolbar.ShowCustomizeItem = false;
        }

        private void TrTimepiece_Tick(object sender, System.EventArgs e)
        {
            barTime.Caption = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void FmMenu_Load(object sender, EventArgs e)
        {
            TopMost = false;

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

                        this.ribbonControl1.Pages.Add(_RibbonPage);
                    }
                    catch (Exception ex)
                    { throw ex; }
                }
            }

            ribbonControl1.SelectedPage = _RibbonPage;
            fm.TopLevel = false;
            fm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fm.Dock = System.Windows.Forms.DockStyle.Fill;
            fm.Parent = panelControl1;
            fm.Show();

            fm.Visible = false;

            NewMethod();
        }

        private void NewMethod()
        {
            FmTest2 fm = new FmTest2();

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

                        this.ribbonControl1.Pages.Add(_RibbonPage);
                    }
                    catch (Exception ex)
                    { throw ex; }
                }
            }

            ribbonControl1.SelectedPage = _RibbonPage;
            fm.TopLevel = false;
            fm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fm.Dock = System.Windows.Forms.DockStyle.Fill;
            fm.Parent = panelControl1;
            fm.Show();
        }
    }
}
