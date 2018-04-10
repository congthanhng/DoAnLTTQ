namespace WindowsFormsApp1
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.lbAppName = new System.Windows.Forms.Label();
            this.tbSignUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbSignClose = new System.Windows.Forms.Label();
            this.tbRePassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAppName
            // 
            this.lbAppName.AutoSize = true;
            this.lbAppName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAppName.Location = new System.Drawing.Point(133, 75);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(167, 28);
            this.lbAppName.TabIndex = 1;
            this.lbAppName.Text = "Sign Up Form";
            // 
            // tbSignUserName
            // 
            this.tbSignUserName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.tbSignUserName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.tbSignUserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.tbSignUserName.BorderThickness = 3;
            this.tbSignUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSignUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignUserName.ForeColor = System.Drawing.Color.White;
            this.tbSignUserName.isPassword = false;
            this.tbSignUserName.Location = new System.Drawing.Point(194, 211);
            this.tbSignUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSignUserName.Name = "tbSignUserName";
            this.tbSignUserName.Size = new System.Drawing.Size(608, 73);
            this.tbSignUserName.TabIndex = 0;
            this.tbSignUserName.Text = "User Name";
            this.tbSignUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSignUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSignUserName_KeyDown);
            this.tbSignUserName.Leave += new System.EventHandler(this.tbSignUserName_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.tbPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.tbPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.tbPassword.BorderThickness = 3;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.isPassword = false;
            this.tbPassword.Location = new System.Drawing.Point(194, 292);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(608, 73);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbName
            // 
            this.tbName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.tbName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.tbName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.tbName.BorderThickness = 3;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.isPassword = false;
            this.tbName.Location = new System.Drawing.Point(194, 454);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(608, 73);
            this.tbName.TabIndex = 3;
            this.tbName.Text = "Your Name";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // lbSignClose
            // 
            this.lbSignClose.AutoSize = true;
            this.lbSignClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.lbSignClose.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignClose.ForeColor = System.Drawing.Color.White;
            this.lbSignClose.Location = new System.Drawing.Point(922, 9);
            this.lbSignClose.Name = "lbSignClose";
            this.lbSignClose.Size = new System.Drawing.Size(32, 31);
            this.lbSignClose.TabIndex = 5;
            this.lbSignClose.Text = "X";
            this.lbSignClose.Click += new System.EventHandler(this.lbSignClose_Click);
            // 
            // tbRePassword
            // 
            this.tbRePassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.tbRePassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.tbRePassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.tbRePassword.BorderThickness = 3;
            this.tbRePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRePassword.ForeColor = System.Drawing.Color.White;
            this.tbRePassword.isPassword = false;
            this.tbRePassword.Location = new System.Drawing.Point(194, 373);
            this.tbRePassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.Size = new System.Drawing.Size(608, 73);
            this.tbRePassword.TabIndex = 2;
            this.tbRePassword.Text = "Re-Enter Password";
            this.tbRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbRePassword.Enter += new System.EventHandler(this.tbRePassword_Enter);
            this.tbRePassword.Leave += new System.EventHandler(this.tbRePassword_Leave);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.lbLogin.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(422, 701);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(99, 37);
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Login";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            this.lbLogin.MouseLeave += new System.EventHandler(this.lbLogin_MouseLeave);
            this.lbLogin.MouseHover += new System.EventHandler(this.lbLogin_MouseHover);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ActiveBorderThickness = 1;
            this.btnSubmit.ActiveCornerRadius = 20;
            this.btnSubmit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnSubmit.ActiveForecolor = System.Drawing.Color.White;
            this.btnSubmit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.IdleBorderThickness = 1;
            this.btnSubmit.IdleCornerRadius = 20;
            this.btnSubmit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnSubmit.IdleForecolor = System.Drawing.Color.White;
            this.btnSubmit.IdleLineColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(322, 588);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(296, 78);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.thieves2;
            this.pictureBox1.Location = new System.Drawing.Point(30, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(966, 817);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbSignClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbRePassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbSignUserName);
            this.Controls.Add(this.lbAppName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAppName;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbSignUserName;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSubmit;
        private System.Windows.Forms.Label lbSignClose;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbRePassword;
        private System.Windows.Forms.Label lbLogin;
    }
}