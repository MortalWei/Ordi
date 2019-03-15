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
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1 fm = new Form1();
            fm.ShowDialog();
        }

        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strEncrypt = MD5Encrypt32("2D2FFA26-106D-4DA0-8D2F-CCA3324EEAF6" + "1");
            Form fm = new Form();
            RichTextBox rx = new RichTextBox() { Text = strEncrypt };
            fm.Controls.Add(rx);
            rx.Dock = DockStyle.Fill;
            fm.ShowDialog();
        }

        /// <summary>
        /// 32位MD5加密
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        private static string MD5Encrypt32(string strText)
        {
            string cl = strText;
            string pwd = "";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create(); //实例化一个md5对像
                                                                                              // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                pwd = pwd + s[i].ToString("X");
            }
            return pwd;
        }
    }
}