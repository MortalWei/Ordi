using Ordi.Attributes;
using Ordi.Windows;
using System.Windows.Forms;

namespace Ordi.App.Test.Utils
{
    [Menu(Id = "1D10CF44-A934-483C-82AD-A8AB485B9EF4", Name = "患者列表", Description = "医生站患者列表")]
    public partial class FMPatient : MainForm
    {
        public FMPatient()
        {
            InitializeComponent();
        }
    }
}
