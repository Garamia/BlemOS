using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlemOS.Engine
{
    public partial class MessageDialog : Form
    {
        public MessageDialog()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool down = false;
        int mousex;
        int mousey;

        private void lblApplicationTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (down)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void lblApplicationTitle_MouseDown(object sender, MouseEventArgs e)
        {
            down = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void lblApplicationTitle_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
        }
    }
}
