using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlemOS.Engine
{
    public class WindowManger
    {
        public void initWindow(UserControl content, string title)
        {
            WindowTemplate window = new WindowTemplate
            {
                Height = content.Height + 45,
                Width = content.Width + 20,
                TopMost = true,
                Text = title,
                ApplicationTitle = title
            };

            Control windowContent = content;
            windowContent.Dock = DockStyle.Fill;

            window.pnlContent.Controls.Add(windowContent);
            window.Show();
        }

        public void ShowMessage(string text, string title)
        {
            MessageDialog dialog = new MessageDialog();

            dialog.lblMessageText.Text = text;
            dialog.lblTitle.Text = title;
            dialog.ShowDialog();
        }
    }
}
