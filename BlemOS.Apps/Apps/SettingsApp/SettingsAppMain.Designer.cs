namespace BlemOS.Apps
{
    partial class SettingsAppMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWallpaper = new System.Windows.Forms.Label();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblWallpaper
            // 
            this.lblWallpaper.AutoSize = true;
            this.lblWallpaper.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallpaper.Location = new System.Drawing.Point(43, 33);
            this.lblWallpaper.Name = "lblWallpaper";
            this.lblWallpaper.Size = new System.Drawing.Size(107, 23);
            this.lblWallpaper.TabIndex = 0;
            this.lblWallpaper.Text = "Wallpaper";
            this.lblWallpaper.Click += new System.EventHandler(this.lblWallpaper_Click);
            // 
            // pnlPanel
            // 
            this.pnlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPanel.Location = new System.Drawing.Point(196, 0);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(499, 466);
            this.pnlPanel.TabIndex = 1;
            // 
            // SettingsAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPanel);
            this.Controls.Add(this.lblWallpaper);
            this.Name = "SettingsAppMain";
            this.Size = new System.Drawing.Size(695, 466);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWallpaper;
        private System.Windows.Forms.Panel pnlPanel;
    }
}
