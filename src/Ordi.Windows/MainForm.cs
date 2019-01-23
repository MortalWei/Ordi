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
        /// <summary>
        /// 休眠时间 单位秒(s)
        /// </summary>
        protected int DormancyTime { get; set; }

        public MainForm()
        {
            InitializeComponent();
            VisibleChanged += MainForm_VisibleChanged;
            //Activated += MainForm_Activated;
        }

        /// <summary>
        /// 事件:界面显示或隐藏
        /// a.触发&停止休眠时间计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                TrDormancy.Stop();
            }
            else
            {
                DormancyTime = 0;
                TrDormancy.Enabled = true;
            }
        }

        private void TrDormancy_Tick(object sender, EventArgs e)
        {
            DormancyTime++;
        }

        /// <summary>
        /// 重新加载界面
        /// 用于界面跳转时,如果该界面已经打开则调用该方法进行刷新
        /// </summary>
        public virtual void Reload(object[] args)
        {
            TrDormancy.Stop();
        }

        /// <summary>
        /// 重新激活界面
        /// 用于Tab界面切换,再次切换到该界面时默认调用此方法进行刷新操作
        /// </summary>
        public virtual void ReActivation()
        {
            TrDormancy.Stop();
        }
    }
}