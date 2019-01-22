using DevExpress.XtraEditors;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using Ordi.Attributes;
using System;
using Ordi.Entities;
using Ordi.Windows;

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

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var _List = System.IO.Directory.GetFiles(Application.StartupPath + @"\Apps", "*.Utils.dll");
            var _Asseembly = Assembly.LoadFile(_List[0]);
            var _Types = _Asseembly.GetTypes().Where(c => c.GetCustomAttributes(typeof(MenuAttribute), false).Length > 0);

            foreach (Type item in _Types)
            {
                var _Attribute = item.GetCustomAttributes(typeof(MenuAttribute), false)?[0] as MenuAttribute;
                var _Name = item.Name;

                MenuModel _Menu = new MenuModel
                {
                    Id = string.IsNullOrEmpty(_Attribute.Id) ? item.Namespace + item.Name : _Attribute.Id,
                    Name = string.IsNullOrEmpty(_Attribute.Name) ? item.Name : _Attribute.Name,
                    Description = _Attribute.Description,
                    Species = Enums.MenuSpecies.Winform
                };
            }



            //var _List2 = System.IO.Directory.GetFiles(Application.StartupPath, "Ordi.*.dll");
            //var files = Directory.GetFiles("C:\\path", "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".bmp") || s.EndsWith(".jpg"));
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //NoneForm form = new NoneForm()
            //{
            //    Text = "测试对话框"
            //};
            //form.ShowDialog();
            Form1 fm = new Form1();
            fm.ShowDialog();
        }
    }
}