using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ordi.Messaging;

namespace Ordi.App
{
    public partial class FmTest2 : DevExpress.XtraEditors.XtraForm
    {
        public FmTest2()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("测试窗体2");
            Form fm = new Form();
            fm.ShowDialog();
            FuncMsg.SetHandle(this);
        }
    }
}