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
    public partial class WindowTemplate : Form
    {
        public string ApplicationTitle { get { return lblApplicationTitle.Text; }  set { lblApplicationTitle.Text = value;  } }
        public WindowTemplate()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFade_Click(object sender, EventArgs e)
        {

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
        public void hybridModeOn()
        {
            pnlTitleBar.Visible = false;
            pnlDragDown.Visible = false;
            pnlDragLeft.Visible = false;
            pnlDragRight.Visible = false;
            FormBorderStyle = FormBorderStyle.Sizable;
            Height -= 45;
            Width -= 20;
            TopMost = false;
        }
        public void hybridModeOff()
        {
            pnlTitleBar.Visible = true;
            pnlDragDown.Visible = true;
            pnlDragLeft.Visible = true;
            pnlDragRight.Visible = true;
            FormBorderStyle = FormBorderStyle.None;
            Height += 45;
            Width += 20;
            TopMost = true;
        }



    }
}
