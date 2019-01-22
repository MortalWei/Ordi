namespace Ordi.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.img16 = new DevExpress.Utils.ImageCollection();
            this.img32 = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.img16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img32)).BeginInit();
            this.SuspendLayout();
            // 
            // img16
            // 
            this.img16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img16.ImageStream")));
            this.img16.Images.SetKeyName(0, "logo.png");
            this.img16.Images.SetKeyName(1, "maximize.png");
            this.img16.Images.SetKeyName(2, "minimize.png");
            this.img16.Images.SetKeyName(3, "restore.png");
            // 
            // img32
            // 
            this.img32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img32.ImageStream")));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.img16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img32)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection img32;
        private DevExpress.Utils.ImageCollection img16;
    }
}