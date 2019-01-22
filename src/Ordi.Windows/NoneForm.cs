using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;

namespace Ordi.Windows
{
    /// <summary>
    /// 自定义边框窗体,用于对话框(Diaglog)形式界面
    /// </summary>
    public partial class NoneForm : DevExpress.XtraEditors.XtraForm
    {
        #region 拖动组件
        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MOVE = 0xF010;
        private const int HTCAPTION = 0x0002;
        #endregion

        #region 属性
        /// <summary>
        /// 窗体标题
        /// </summary>
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                TitleText.Text = value;
            }
        }

        [Browsable(true)]
        public new bool MaximizeBox
        {
            get { return base.MaximizeBox; }
            set
            {
                base.MaximizeBox = value;
                BtnMaximise.Visible = value;
            }
        }

        [Browsable(true)]
        public new bool MinimizeBox
        {
            get { return base.MinimizeBox; }
            set
            {
                base.MinimizeBox = value;
                BtnMinimise.Visible = value;
            }
        }

        [Browsable(false)]
        public new bool ShowIcon
        {
            get { return base.ShowIcon; }
            set { base.ShowIcon = value; }
        }

        [Browsable(true)]
        [Category("Window Style"), Description("应用和设置界面Logo图标.请使用16*16的图标.")]
        public Image LogoImage
        {
            get { return pictureBox1.Image; }
            set
            {
                pictureBox1.Image = value;
            }
        }

        [Browsable(false)]
        public new Icon Icon
        {
            get { return base.Icon; }
            set { base.Icon = value; }
        }

        [Browsable(false)]
        public new FormBorderStyle FormBorderStyle
        {
            get { return base.FormBorderStyle; }
            set { base.FormBorderStyle = value; }
        }

        /// <summary>
        /// 禁用拖动标题栏以拖动窗体
        /// </summary>
        [Browsable(true)]
        [DefaultValue(false), Category("Behavior"), Description("禁用拖动标题栏以拖动窗体")]
        public bool DisableDrag { get; set; }
        #endregion

        #region 构造
        public NoneForm()
        {
            InitializeComponent();
            BtnClose.AllowFocus = false;
            BtnMaximise.AllowFocus = false;
            BtnMinimise.AllowFocus = false;
            TopMost = true;//默认置顶,打开成功后再移除该属性
        }
        #endregion

        #region 常规事件处理
        /// <summary>
        /// 默认加载事件,用于处理一些默认属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoneForm_Load(object sender, EventArgs e)
        {
            TopMost = false;//默认置顶,打开成功后再移除该属性
        }

        /// <summary>
        /// 事件:关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormClose(object sender, MouseEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 事件:最大化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMaximise(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// 事件:最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMinimise(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 拖动窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMoveForm(object sender, MouseEventArgs e)
        {
            if (DisableDrag) return;
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        /// <summary>
        /// 窗体大小改变后重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        /// <summary>
        /// 重绘边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDrawBorder(object sender, PaintEventArgs e)
        {
            Rectangle myRectangle = new Rectangle(0, 0, Width, Height);

            ControlPaint.DrawBorder(e.Graphics, myRectangle,
                Color.FromArgb(198, 198, 198), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(198, 198, 198), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(198, 198, 198), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(198, 198, 198), 1, ButtonBorderStyle.Solid
                );
        }
        #endregion
    }
}