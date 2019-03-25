using DevExpress.XtraEditors;
using Ordi.Attributes;
using Ordi.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ordi.App.Menus
{
    [Menu(Id = "E5B7F101-B0DE-481C-ABA6-12DACF8C20DF", Name = "菜单管理", Description = "配置系统可用菜单", Category = "维护")]
    public partial class FmMenuMaintain : MainForm
    {
        public FmMenuMaintain()
        {
            InitializeComponent();
        }
    }
}
