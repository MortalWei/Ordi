using System;

namespace Ordi.App
{
    public partial class FmMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FmMenu()
        {
            InitializeComponent();
        }

        private void TrTimepiece_Tick(object sender, System.EventArgs e)
        {
            barTime.Caption = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void FmMenu_Load(object sender, EventArgs e)
        {
            TopMost = false;
        }
    }
}
