namespace Ordi.Windows
{
    partial class NoneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoneForm));
            this.PnlHeader = new DevExpress.XtraEditors.PanelControl();
            this.TitleText = new DevExpress.XtraEditors.LabelControl();
            this.BtnMinimise = new DevExpress.XtraEditors.SimpleButton();
            this.img16 = new DevExpress.Utils.ImageCollection(this.components);
            this.BtnMaximise = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PnlHeader)).BeginInit();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.PnlHeader.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.PnlHeader.Appearance.Options.UseBackColor = true;
            this.PnlHeader.Appearance.Options.UseBorderColor = true;
            this.PnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PnlHeader.Controls.Add(this.TitleText);
            this.PnlHeader.Controls.Add(this.BtnMinimise);
            this.PnlHeader.Controls.Add(this.BtnMaximise);
            this.PnlHeader.Controls.Add(this.BtnClose);
            this.PnlHeader.Controls.Add(this.pictureBox1);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.PnlHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PnlHeader.MaximumSize = new System.Drawing.Size(0, 30);
            this.PnlHeader.MinimumSize = new System.Drawing.Size(0, 30);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Padding = new System.Windows.Forms.Padding(2);
            this.PnlHeader.Size = new System.Drawing.Size(800, 30);
            this.PnlHeader.TabIndex = 0;
            this.PnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.OnDrawBorder);
            // 
            // TitleText
            // 
            this.TitleText.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.TitleText.Appearance.Options.UseFont = true;
            this.TitleText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.TitleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleText.Location = new System.Drawing.Point(28, 2);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(686, 26);
            this.TitleText.TabIndex = 3;
            this.TitleText.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMaximise);
            this.TitleText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMoveForm);
            // 
            // BtnMinimise
            // 
            this.BtnMinimise.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.BtnMinimise.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnMinimise.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnMinimise.Appearance.Options.UseBackColor = true;
            this.BtnMinimise.Appearance.Options.UseBorderColor = true;
            this.BtnMinimise.Appearance.Options.UseForeColor = true;
            this.BtnMinimise.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.BtnMinimise.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.BtnMinimise.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.BtnMinimise.AppearanceDisabled.Options.UseBackColor = true;
            this.BtnMinimise.AppearanceDisabled.Options.UseBorderColor = true;
            this.BtnMinimise.AppearanceDisabled.Options.UseForeColor = true;
            this.BtnMinimise.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(244)))));
            this.BtnMinimise.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.BtnMinimise.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnMinimise.AppearanceHovered.Options.UseBackColor = true;
            this.BtnMinimise.AppearanceHovered.Options.UseBorderColor = true;
            this.BtnMinimise.AppearanceHovered.Options.UseForeColor = true;
            this.BtnMinimise.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.BtnMinimise.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.BtnMinimise.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnMinimise.AppearancePressed.Options.UseBackColor = true;
            this.BtnMinimise.AppearancePressed.Options.UseBorderColor = true;
            this.BtnMinimise.AppearancePressed.Options.UseForeColor = true;
            this.BtnMinimise.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnMinimise.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimise.ImageIndex = 2;
            this.BtnMinimise.ImageList = this.img16;
            this.BtnMinimise.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnMinimise.Location = new System.Drawing.Point(714, 2);
            this.BtnMinimise.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.BtnMinimise.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnMinimise.Name = "BtnMinimise";
            this.BtnMinimise.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnMinimise.Size = new System.Drawing.Size(28, 26);
            this.BtnMinimise.TabIndex = 5;
            this.BtnMinimise.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMinimise);
            // 
            // img16
            // 
            this.img16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img16.ImageStream")));
            this.img16.Images.SetKeyName(0, "close.png");
            this.img16.Images.SetKeyName(1, "maximize.png");
            this.img16.Images.SetKeyName(2, "minimize.png");
            this.img16.Images.SetKeyName(3, "restore.png");
            this.img16.Images.SetKeyName(4, "logo.png");
            // 
            // BtnMaximise
            // 
            this.BtnMaximise.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.BtnMaximise.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnMaximise.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnMaximise.Appearance.Options.UseBackColor = true;
            this.BtnMaximise.Appearance.Options.UseBorderColor = true;
            this.BtnMaximise.Appearance.Options.UseForeColor = true;
            this.BtnMaximise.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.BtnMaximise.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.BtnMaximise.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.BtnMaximise.AppearanceDisabled.Options.UseBackColor = true;
            this.BtnMaximise.AppearanceDisabled.Options.UseBorderColor = true;
            this.BtnMaximise.AppearanceDisabled.Options.UseForeColor = true;
            this.BtnMaximise.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(244)))));
            this.BtnMaximise.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.BtnMaximise.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnMaximise.AppearanceHovered.Options.UseBackColor = true;
            this.BtnMaximise.AppearanceHovered.Options.UseBorderColor = true;
            this.BtnMaximise.AppearanceHovered.Options.UseForeColor = true;
            this.BtnMaximise.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.BtnMaximise.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.BtnMaximise.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnMaximise.AppearancePressed.Options.UseBackColor = true;
            this.BtnMaximise.AppearancePressed.Options.UseBorderColor = true;
            this.BtnMaximise.AppearancePressed.Options.UseForeColor = true;
            this.BtnMaximise.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnMaximise.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximise.ImageIndex = 1;
            this.BtnMaximise.ImageList = this.img16;
            this.BtnMaximise.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnMaximise.Location = new System.Drawing.Point(742, 2);
            this.BtnMaximise.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.BtnMaximise.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnMaximise.Name = "BtnMaximise";
            this.BtnMaximise.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnMaximise.Size = new System.Drawing.Size(28, 26);
            this.BtnMaximise.TabIndex = 4;
            this.BtnMaximise.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMaximise);
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.BtnClose.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Appearance.Options.UseBackColor = true;
            this.BtnClose.Appearance.Options.UseBorderColor = true;
            this.BtnClose.Appearance.Options.UseForeColor = true;
            this.BtnClose.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.BtnClose.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.BtnClose.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.BtnClose.AppearanceDisabled.Options.UseBackColor = true;
            this.BtnClose.AppearanceDisabled.Options.UseBorderColor = true;
            this.BtnClose.AppearanceDisabled.Options.UseForeColor = true;
            this.BtnClose.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(244)))));
            this.BtnClose.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.BtnClose.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnClose.AppearanceHovered.Options.UseBackColor = true;
            this.BtnClose.AppearanceHovered.Options.UseBorderColor = true;
            this.BtnClose.AppearanceHovered.Options.UseForeColor = true;
            this.BtnClose.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.BtnClose.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.BtnClose.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.BtnClose.AppearancePressed.Options.UseBackColor = true;
            this.BtnClose.AppearancePressed.Options.UseBorderColor = true;
            this.BtnClose.AppearancePressed.Options.UseForeColor = true;
            this.BtnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.ImageIndex = 0;
            this.BtnClose.ImageList = this.img16;
            this.BtnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnClose.Location = new System.Drawing.Point(770, 2);
            this.BtnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.BtnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnClose.Size = new System.Drawing.Size(28, 26);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnFormClose);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMaximise);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMoveForm);
            // 
            // NoneForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoneForm";
            this.Load += new System.EventHandler(this.NoneForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnDrawBorder);
            this.Resize += new System.EventHandler(this.Form_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PnlHeader)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PnlHeader;
        private DevExpress.Utils.ImageCollection img16;
        private DevExpress.XtraEditors.LabelControl TitleText;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnMinimise;
        private DevExpress.XtraEditors.SimpleButton BtnMaximise;
        private System.Windows.Forms.PictureBox pictureBox1;
        //private Browser.OrdiBrowser ordiBrowser1;
    }
}