using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace Ordi.Windows
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        [ToolboxItem(true)]
        public ImageCollection Image16
        {
            get { return img16; }
        }

        [ToolboxItem(true)]
        public ImageCollection Image32
        {
            get { return img32; }
        }
    }
}