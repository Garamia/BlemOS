namespace BlemOS.Engine
{
    partial class WindowTemplate
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.btnFade = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDragLeft = new System.Windows.Forms.Panel();
            this.pnlDragRight = new System.Windows.Forms.Panel();
            this.pnlDragDown = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.DimGray;
            this.pnlTitleBar.Controls.Add(this.lblApplicationTitle);
            this.pnlTitleBar.Controls.Add(this.btnFade);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(390, 35);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTitle.Location = new System.Drawing.Point(3, 0);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(315, 34);
            this.lblApplicationTitle.TabIndex = 2;
            this.lblApplicationTitle.Text = "Application Name";
            this.lblApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApplicationTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblApplicationTitle_MouseDown);
            this.lblApplicationTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblApplicationTitle_MouseMove);
            this.lblApplicationTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblApplicationTitle_MouseUp);
            // 
            // btnFade
            // 
            this.btnFade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFade.BackColor = System.Drawing.Color.DimGray;
            this.btnFade.FlatAppearance.BorderSize = 0;
            this.btnFade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFade.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFade.Location = new System.Drawing.Point(322, 0);
            this.btnFade.Name = "btnFade";
            this.btnFade.Size = new System.Drawing.Size(35, 35);
            this.btnFade.TabIndex = 1;
            this.btnFade.Text = "F";
            this.btnFade.UseVisualStyleBackColor = false;
            this.btnFade.Click += new System.EventHandler(this.btnFade_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(356, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "C";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlDragLeft
            // 
            this.pnlDragLeft.BackColor = System.Drawing.Color.DimGray;
            this.pnlDragLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDragLeft.Location = new System.Drawing.Point(0, 35);
            this.pnlDragLeft.Name = "pnlDragLeft";
            this.pnlDragLeft.Size = new System.Drawing.Size(10, 296);
            this.pnlDragLeft.TabIndex = 1;
            // 
            // pnlDragRight
            // 
            this.pnlDragRight.BackColor = System.Drawing.Color.DimGray;
            this.pnlDragRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDragRight.Location = new System.Drawing.Point(380, 35);
            this.pnlDragRight.Name = "pnlDragRight";
            this.pnlDragRight.Size = new System.Drawing.Size(10, 296);
            this.pnlDragRight.TabIndex = 2;
            // 
            // pnlDragDown
            // 
            this.pnlDragDown.BackColor = System.Drawing.Color.DimGray;
            this.pnlDragDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDragDown.Location = new System.Drawing.Point(10, 321);
            this.pnlDragDown.Name = "pnlDragDown";
            this.pnlDragDown.Size = new System.Drawing.Size(370, 10);
            this.pnlDragDown.TabIndex = 3;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(10, 35);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(370, 286);
            this.pnlContent.TabIndex = 4;
            // 
            // WindowTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 331);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlDragDown);
            this.Controls.Add(this.pnlDragRight);
            this.Controls.Add(this.pnlDragLeft);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "WindowTemplate";
            this.Text = "WindowTemplate";
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlDragLeft;
        private System.Windows.Forms.Panel pnlDragRight;
        private System.Windows.Forms.Panel pnlDragDown;
        public System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnFade;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblApplicationTitle;
    }
}