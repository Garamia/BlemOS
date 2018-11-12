using System;
using System.Windows.Forms;
using BlemOS.Apps.SettingsApp;
using BlemOS.Registry;

namespace BlemOS.Apps
{
    public partial class SettingsAppMain : UserControl
    {
        public SettingsAppMain()
        {
            InitializeComponent();
        }

        private void lblWallpaper_Click(object sender, EventArgs e)
        {
            SettingsAppWallpaperPanel panel = new SettingsAppWallpaperPanel();
            panel.Dock = DockStyle.Fill;
            pnlPanel.Controls.Add(panel);

        }
    }
}
