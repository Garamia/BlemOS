using BlemOS.Apps;
using BlemOS.Engine;
using BlemOS.Registry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlemOS.Main
{
    public partial class Desktop : Form
    {

        List<string> apps;

        public Desktop()
        {
            InitializeComponent();
            
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            AppRegistry.loadApp("Settings");
        }

        private void btnHybrid_Click(object sender, EventArgs e)
        {
            AppRegistry.loadApp("Hybrid Mode");
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") txtSearch.Text = "Search Here";
        }

        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Here") txtSearch.Text = "";
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            RegisterApps.registerapps();
            apps = AppRegistry.listApps();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersistentSettings.load();
        }

        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                pnlResults.Visible = false;
                return;
            }
            foreach(string app in apps)
            {
                if (app.ToLower().StartsWith(txtSearch.Text.ToLower()))
                {
                    pnlResults.Visible = true;
                    Control c = ControlFactory.CloneCtrl(btnResult);
                    c.Text = app;
                    
                }
            }
            pnlResults.Visible = false;
        }

        private void btnResult1_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "") return;
            AppRegistry.loadApp(btnResult.Text);
            txtSearch.Clear();
            btnResult.Text = "";
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (btnResult.Text == "") return;
                AppRegistry.loadApp(btnResult.Text);
                txtSearch.Text = "Search Here";
                btnResult.Text = "";
                e.Handled = true;
            }
        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(60, 0, 0, 0);
        }

        private void btnHybrid_MouseHover(object sender, EventArgs e)
        {
            btnHybrid.BackColor = Color.FromArgb(60, 0, 0, 0);
        }
    }
}
