using System;
using BlemOS.Engine;
using System.Collections.Generic;
using System.Windows.Forms;
using BlemOS.Registry;

namespace BlemOS.Apps
{
    public partial class HybridModeAppMain : UserControl
    {
        public HybridModeAppMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();
            foreach(Form f in Application.OpenForms)
            {
                forms.Add(f);
            }
            foreach(Form f in forms)
            {
                if (f is WindowTemplate w)
                {
                    w.hybridModeOn();
                }
                else
                {
                    f.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();
            foreach (Form f in Application.OpenForms)
            {
                forms.Add(f);
            }
            foreach (Form f in forms)
            {
                if (f is WindowTemplate w)
                {
                    w.hybridModeOff();
                }
                else 
                {
                    f.Show();
                }
            }
        }
        
    }
}
