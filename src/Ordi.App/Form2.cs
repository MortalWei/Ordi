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
        private int TimerCount = 0;

        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void Form2_GotFocus(object sender, EventArgs e)
        {
            timer1.Stop();
            txtContent.Text = TimerCount.ToString();
        }

        private void Form2_LostFocus(object sender, EventArgs e)
        {
            TimerCount = 0;
            timer1.Enabled = true;
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            if (IsActive)
            {
                timer1.Stop();
                txtContent.Text = TimerCount.ToString();
            }
            else
            {
                TimerCount = 0;
                timer1.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        public override void ReActivation()
        {
            base.ReActivation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //TimerCount++;
            txtContent.Text = (TimerCount++).ToString();
        }
    }
}
