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
        #region Variable & Attribute
        /// <summary>
        /// 休眠计时器
        /// </summary>
        private System.Timers.Timer Timer = new System.Timers.Timer();

        /// <summary>
        /// 休眠时间 单位秒(s)
        /// 当前仅支持在系统内RibbonPage页切换计时
        /// </summary>
        protected int DormancyTime { get; set; }
        #endregion

        #region Structure
        /// <summary>
        /// 默认构造
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            //VisibleChanged += MainForm_VisibleChanged;
            Timer.Interval = 1000;
            Timer.AutoReset = true;
            Timer.Elapsed += Timer_Elapsed;
        }
        #endregion

        #region Event Register
        ///// <summary>
        ///// 事件:界面显示或隐藏
        ///// a.触发&停止休眠时间计时器
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void MainForm_VisibleChanged(object sender, EventArgs e)
        //{
        //    if (Visible)
        //    {
        //        TrDormancy.Stop();
        //    }
        //    else
        //    {
        //        DormancyTime = 0;
        //        TrDormancy.Enabled = true;
        //    }
        //}

        /// <summary>
        /// 事件:休眠计时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DormancyTime++;
        }
        #endregion

        #region Publicity
        /// <summary>
        /// 重新加载界面
        /// 用于界面跳转时,如果该界面已经打开则调用该方法进行刷新
        /// 该方法用于主界面调用
        /// </summary>
        /// <param name="args"></param>
        public void OnReload(object[] args)
        {
            //TrDormancy.Stop();
            Reload(args);
        }

        /// <summary>
        /// 重新加载界面
        /// 用于界面跳转时,如果该界面已经打开则调用该方法进行刷新
        /// 子窗体通过重写该方法实现自身
        /// </summary>
        public virtual void Reload(object[] args)
        {
        }

        /// 重新激活界面
        /// 用于Tab界面切换,再次切换到该界面时默认调用此方法进行刷新操作
        /// 该方法用于主界面调用
        public void OnReActivation()
        {
            //TrDormancy.Stop();
        }

        /// <summary>
        /// 重新激活界面
        /// 用于Tab界面切换,再次切换到该界面时默认调用此方法进行刷新操作
        /// 子窗体通过重写该方法实现自身
        /// </summary>
        public virtual void ReActivation()
        {
            //TrDormancy.Stop();
        }
        #endregion
    }
}