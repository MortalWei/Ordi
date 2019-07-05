using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Ordi.App
{
    public partial class FmMaintain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FmMaintain()
        {
            InitializeComponent();
        }

        private void FmMaintain_Load(object sender, EventArgs e)
        {
            TopMost = false;
        }
    }
}