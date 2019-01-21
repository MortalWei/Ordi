using DevExpress.XtraEditors;
using Ordi.Attributes;
using System.Windows.Forms;

namespace Ordi.App.Test.Utils
{
    [Menu(Id = "D1A2408C-6F72-4066-9943-1978B1885D73", Name = "测试菜单", Description = "第一个测试用菜单")]
    public partial class FmOrdiTest : XtraForm
    {
        public FmOrdiTest()
        {
            InitializeComponent();
        }
    }
}
