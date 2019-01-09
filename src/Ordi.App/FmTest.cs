using DevExpress.XtraEditors;

namespace Ordi.App
{
    public partial class FmTest : XtraForm
    {
        public FmTest()
        {
            InitializeComponent();
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("测试按钮");
        }
    }
}