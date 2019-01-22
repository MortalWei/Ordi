using Ordi.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ordi.App
{
    public partial class Form2 : MainForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            simpleButton1.ImageList = Image16;
            simpleButton1.ImageIndex = 0;
        }
    }
}
