namespace WindowsFormsApp1
{
    partial class MainMessenger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMessenger));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlMainHeader = new System.Windows.Forms.Panel();
            this.MainName = new System.Windows.Forms.Label();
            this.MainClose = new System.Windows.Forms.Label();
            pnlMainLeft = new System.Windows.Forms.Panel();
            pnlMainLeftContent = new System.Windows.Forms.Panel();
            pnlSearch = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            pnlMainRight = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSetting = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGroup = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHistory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMusic = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnContact = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.MainLogo = new System.Windows.Forms.PictureBox();
            pnlMainTop = new System.Windows.Forms.Panel();
            pnlMainMiddle = new System.Windows.Forms.Panel();
            this.pnlMainHeader.SuspendLayout();
            pnlMainLeft.SuspendLayout();
            pnlSearch.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlMainHeader
            // 
            this.pnlMainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.pnlMainHeader.Controls.Add(this.MainName);
            this.pnlMainHeader.Controls.Add(this.MainLogo);
            this.pnlMainHeader.Controls.Add(this.MainClose);
            this.pnlMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlMainHeader.Name = "pnlMainHeader";
            this.pnlMainHeader.Size = new System.Drawing.Size(1443, 37);
            this.pnlMainHeader.TabIndex = 0;
            // 
            // MainName
            // 
            this.MainName.AutoSize = true;
            this.MainName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainName.ForeColor = System.Drawing.Color.White;
            this.MainName.Location = new System.Drawing.Point(50, 7);
            this.MainName.Name = "MainName";
            this.MainName.Size = new System.Drawing.Size(119, 25);
            this.MainName.TabIndex = 2;
            this.MainName.Text = "Messenger";
            // 
            // MainClose
            // 
            this.MainClose.AutoSize = true;
            this.MainClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.MainClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainClose.ForeColor = System.Drawing.Color.White;
            this.MainClose.Location = new System.Drawing.Point(1406, 8);
            this.MainClose.Name = "MainClose";
            this.MainClose.Size = new System.Drawing.Size(24, 23);
            this.MainClose.TabIndex = 6;
            this.MainClose.Text = "X";
            this.MainClose.Click += new System.EventHandler(this.MainClose_Click);
            this.MainClose.MouseLeave += new System.EventHandler(this.MainClose_MouseLeave);
            this.MainClose.MouseHover += new System.EventHandler(this.MainClose_MouseHover);
            // 
            // pnlMainLeft
            // 
           pnlMainLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
           pnlMainLeft.Controls.Add(pnlMainLeftContent);
           pnlMainLeft.Controls.Add(pnlSearch);
           pnlMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
           pnlMainLeft.Location = new System.Drawing.Point(65, 37);
           pnlMainLeft.Name = "pnlMainLeft";
           pnlMainLeft.Size = new System.Drawing.Size(260, 808);
           pnlMainLeft.TabIndex = 3;
            // 
            // pnlMainLeftContent
            // 
            pnlMainLeftContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMainLeftContent.Location = new System.Drawing.Point(0, 49);
            pnlMainLeftContent.Name = "pnlMainLeftContent";
            pnlMainLeftContent.Size = new System.Drawing.Size(260, 759);
            pnlMainLeftContent.TabIndex = 1;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(this.bunifuMaterialTextbox1);
            pnlSearch.Controls.Add(this.bunifuImageButton1);
            pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSearch.Location = new System.Drawing.Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new System.Drawing.Size(260, 49);
            pnlSearch.TabIndex = 0;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.HintText = "Search...";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(5, 9);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(185, 37);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnGroup);
            this.pnlMenu.Controls.Add(this.btnHistory);
            this.pnlMenu.Controls.Add(this.btnMusic);
            this.pnlMenu.Controls.Add(this.btnContact);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 37);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(65, 808);
            this.pnlMenu.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlMainHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlMainRight
            // 
            pnlMainRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            pnlMainRight.Dock = System.Windows.Forms.DockStyle.Right;
            pnlMainRight.Location = new System.Drawing.Point(1183, 37);
            pnlMainRight.Name = "pnlMainRight";
            pnlMainRight.Size = new System.Drawing.Size(260, 808);
            pnlMainRight.TabIndex = 4;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.bunifuImageButton1.ImageActive = global::WindowsFormsApp1.Properties.Resources.search_active;
            this.bunifuImageButton1.Location = new System.Drawing.Point(199, 16);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.btnSetting.Image = global::WindowsFormsApp1.Properties.Resources.setting;
            this.btnSetting.ImageActive = global::WindowsFormsApp1.Properties.Resources.setting_active;
            this.btnSetting.Location = new System.Drawing.Point(0, 393);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(65, 46);
            this.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSetting.TabIndex = 3;
            this.btnSetting.TabStop = false;
            this.btnSetting.Zoom = 10;
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.btnGroup.Image = global::WindowsFormsApp1.Properties.Resources.group;
            this.btnGroup.ImageActive = global::WindowsFormsApp1.Properties.Resources.group_active;
            this.btnGroup.Location = new System.Drawing.Point(0, 257);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(65, 46);
            this.btnGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGroup.TabIndex = 3;
            this.btnGroup.TabStop = false;
            this.btnGroup.Zoom = 10;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.btnHistory.Image = global::WindowsFormsApp1.Properties.Resources.sms;
            this.btnHistory.ImageActive = global::WindowsFormsApp1.Properties.Resources.sms_active;
            this.btnHistory.Location = new System.Drawing.Point(0, 123);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(65, 46);
            this.btnHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHistory.TabIndex = 3;
            this.btnHistory.TabStop = false;
            this.btnHistory.Zoom = 10;
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.btnMusic.Image = global::WindowsFormsApp1.Properties.Resources.music;
            this.btnMusic.ImageActive = global::WindowsFormsApp1.Properties.Resources.music_active;
            this.btnMusic.Location = new System.Drawing.Point(0, 325);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(65, 46);
            this.btnMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMusic.TabIndex = 3;
            this.btnMusic.TabStop = false;
            this.btnMusic.Zoom = 10;
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.btnContact.Image = global::WindowsFormsApp1.Properties.Resources.contact;
            this.btnContact.ImageActive = global::WindowsFormsApp1.Properties.Resources.contact_active;
            this.btnContact.Location = new System.Drawing.Point(0, 190);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(65, 46);
            this.btnContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnContact.TabIndex = 3;
            this.btnContact.TabStop = false;
            this.btnContact.Zoom = 10;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.btnHome.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.btnHome.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnHome.ImageActive")));
            this.btnHome.Location = new System.Drawing.Point(0, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(65, 46);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.btnHome.Zoom = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // MainLogo
            // 
            this.MainLogo.Image = global::WindowsFormsApp1.Properties.Resources.thieves;
            this.MainLogo.Location = new System.Drawing.Point(7, 5);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.Size = new System.Drawing.Size(47, 28);
            this.MainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainLogo.TabIndex = 1;
            this.MainLogo.TabStop = false;
            // 
            // pnlMainTop
            // 
           pnlMainTop.Dock = System.Windows.Forms.DockStyle.Top;
           pnlMainTop.Location = new System.Drawing.Point(325, 37);
           pnlMainTop.Name = "pnlMainTop";
           pnlMainTop.Size = new System.Drawing.Size(858, 49);
           pnlMainTop.TabIndex = 5;
            // 
            // pnlMainMiddle
            // 
            pnlMainMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMainMiddle.Location = new System.Drawing.Point(325, 86);
            pnlMainMiddle.Name = "pnlMainMiddle";
            pnlMainMiddle.Size = new System.Drawing.Size(858, 759);
            pnlMainMiddle.TabIndex = 6;
            // 
            // MainMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1443, 845);
            this.Controls.Add(pnlMainMiddle);
            this.Controls.Add(pnlMainTop);
            this.Controls.Add(pnlMainRight);
            this.Controls.Add(pnlMainLeft);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlMainHeader);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMessenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMessenger";
            this.pnlMainHeader.ResumeLayout(false);
            this.pnlMainHeader.PerformLayout();
            pnlMainLeft.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMainHeader;
        private System.Windows.Forms.Label MainClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label MainName;
        private System.Windows.Forms.PictureBox MainLogo;
        
        public static System.Windows.Forms.Panel pnlSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public static System.Windows.Forms.Panel pnlMainMiddle;
        public static System.Windows.Forms.Panel pnlMainTop;
        public Bunifu.Framework.UI.BunifuImageButton btnHistory;
        public Bunifu.Framework.UI.BunifuImageButton btnGroup;
        public Bunifu.Framework.UI.BunifuImageButton btnContact;
        public Bunifu.Framework.UI.BunifuImageButton btnSetting;
        public Bunifu.Framework.UI.BunifuImageButton btnMusic;
        public Bunifu.Framework.UI.BunifuImageButton btnHome;
        public static System.Windows.Forms.Panel pnlMainRight;
        public static System.Windows.Forms.Panel pnlMainLeftContent;
        public static System.Windows.Forms.Panel pnlMainLeft;
    }
}