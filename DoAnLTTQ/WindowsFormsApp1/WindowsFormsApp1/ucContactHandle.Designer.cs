namespace WindowsFormsApp1
{
    partial class ucContactHandle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucContactHandle));
            this.lbContactHandleScript1 = new System.Windows.Forms.Label();
            this.lbContactHandleScript2 = new System.Windows.Forms.Label();
            this.pnlContactFriendHandle = new System.Windows.Forms.Panel();
            this.btnSendRequest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtContact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContactHandleContent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbContactHandleTitle = new System.Windows.Forms.Label();
            this.btnAddFriend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeleteFriend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlContactFriendHandle.SuspendLayout();
            this.pnlContactHandleContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbContactHandleScript1
            // 
            this.lbContactHandleScript1.AutoSize = true;
            this.lbContactHandleScript1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactHandleScript1.ForeColor = System.Drawing.Color.White;
            this.lbContactHandleScript1.Location = new System.Drawing.Point(19, 32);
            this.lbContactHandleScript1.Name = "lbContactHandleScript1";
            this.lbContactHandleScript1.Size = new System.Drawing.Size(151, 28);
            this.lbContactHandleScript1.TabIndex = 2;
            this.lbContactHandleScript1.Text = "ADD FRIEND";
            // 
            // lbContactHandleScript2
            // 
            this.lbContactHandleScript2.AutoSize = true;
            this.lbContactHandleScript2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactHandleScript2.ForeColor = System.Drawing.Color.White;
            this.lbContactHandleScript2.Location = new System.Drawing.Point(20, 74);
            this.lbContactHandleScript2.Name = "lbContactHandleScript2";
            this.lbContactHandleScript2.Size = new System.Drawing.Size(339, 23);
            this.lbContactHandleScript2.TabIndex = 3;
            this.lbContactHandleScript2.Text = "You can add a friend with their Id";
            // 
            // pnlContactFriendHandle
            // 
            this.pnlContactFriendHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.pnlContactFriendHandle.Controls.Add(this.btnSendRequest);
            this.pnlContactFriendHandle.Controls.Add(this.txtContact);
            this.pnlContactFriendHandle.Location = new System.Drawing.Point(24, 137);
            this.pnlContactFriendHandle.Name = "pnlContactFriendHandle";
            this.pnlContactFriendHandle.Size = new System.Drawing.Size(776, 74);
            this.pnlContactFriendHandle.TabIndex = 4;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.ActiveBorderThickness = 1;
            this.btnSendRequest.ActiveCornerRadius = 20;
            this.btnSendRequest.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnSendRequest.ActiveForecolor = System.Drawing.Color.White;
            this.btnSendRequest.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnSendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnSendRequest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendRequest.BackgroundImage")));
            this.btnSendRequest.ButtonText = "Send your request";
            this.btnSendRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendRequest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSendRequest.IdleBorderThickness = 1;
            this.btnSendRequest.IdleCornerRadius = 20;
            this.btnSendRequest.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnSendRequest.IdleForecolor = System.Drawing.Color.White;
            this.btnSendRequest.IdleLineColor = System.Drawing.Color.White;
            this.btnSendRequest.Location = new System.Drawing.Point(505, 11);
            this.btnSendRequest.Margin = new System.Windows.Forms.Padding(5);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(251, 58);
            this.btnSendRequest.TabIndex = 3;
            this.btnSendRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContact
            // 
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtContact.HintForeColor = System.Drawing.Color.Empty;
            this.txtContact.HintText = "";
            this.txtContact.isPassword = false;
            this.txtContact.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtContact.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtContact.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtContact.LineThickness = 4;
            this.txtContact.Location = new System.Drawing.Point(15, 4);
            this.txtContact.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(446, 57);
            this.txtContact.TabIndex = 2;
            this.txtContact.Text = "Enter your friend\'s name";
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContact.Enter += new System.EventHandler(this.txtContact_Enter);
            this.txtContact.Leave += new System.EventHandler(this.txtContact_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 10);
            this.panel1.TabIndex = 5;
            // 
            // pnlContactHandleContent
            // 
            this.pnlContactHandleContent.Controls.Add(this.lbContactHandleScript1);
            this.pnlContactHandleContent.Controls.Add(this.lbContactHandleScript2);
            this.pnlContactHandleContent.Controls.Add(this.pnlContactFriendHandle);
            this.pnlContactHandleContent.Location = new System.Drawing.Point(0, 150);
            this.pnlContactHandleContent.Name = "pnlContactHandleContent";
            this.pnlContactHandleContent.Size = new System.Drawing.Size(855, 261);
            this.pnlContactHandleContent.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteFriend);
            this.panel2.Controls.Add(this.btnAddFriend);
            this.panel2.Controls.Add(this.lbContactHandleTitle);
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 128);
            this.panel2.TabIndex = 7;
            // 
            // lbContactHandleTitle
            // 
            this.lbContactHandleTitle.AutoSize = true;
            this.lbContactHandleTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactHandleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.lbContactHandleTitle.Location = new System.Drawing.Point(17, 18);
            this.lbContactHandleTitle.Name = "lbContactHandleTitle";
            this.lbContactHandleTitle.Size = new System.Drawing.Size(73, 23);
            this.lbContactHandleTitle.TabIndex = 1;
            this.lbContactHandleTitle.Text = "Friend:";
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.ActiveBorderThickness = 1;
            this.btnAddFriend.ActiveCornerRadius = 20;
            this.btnAddFriend.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddFriend.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddFriend.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddFriend.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFriend.BackgroundImage")));
            this.btnAddFriend.ButtonText = "ADD";
            this.btnAddFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFriend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.ForeColor = System.Drawing.Color.White;
            this.btnAddFriend.IdleBorderThickness = 1;
            this.btnAddFriend.IdleCornerRadius = 20;
            this.btnAddFriend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnAddFriend.IdleForecolor = System.Drawing.Color.White;
            this.btnAddFriend.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnAddFriend.Location = new System.Drawing.Point(21, 56);
            this.btnAddFriend.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(93, 55);
            this.btnAddFriend.TabIndex = 2;
            this.btnAddFriend.Tag = "";
            this.btnAddFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // btnDeleteFriend
            // 
            this.btnDeleteFriend.ActiveBorderThickness = 1;
            this.btnDeleteFriend.ActiveCornerRadius = 20;
            this.btnDeleteFriend.ActiveFillColor = System.Drawing.Color.Red;
            this.btnDeleteFriend.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteFriend.ActiveLineColor = System.Drawing.Color.Red;
            this.btnDeleteFriend.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteFriend.BackgroundImage")));
            this.btnDeleteFriend.ButtonText = "DELETE";
            this.btnDeleteFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFriend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFriend.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFriend.IdleBorderThickness = 1;
            this.btnDeleteFriend.IdleCornerRadius = 20;
            this.btnDeleteFriend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnDeleteFriend.IdleForecolor = System.Drawing.Color.White;
            this.btnDeleteFriend.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnDeleteFriend.Location = new System.Drawing.Point(124, 56);
            this.btnDeleteFriend.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteFriend.Name = "btnDeleteFriend";
            this.btnDeleteFriend.Size = new System.Drawing.Size(93, 55);
            this.btnDeleteFriend.TabIndex = 2;
            this.btnDeleteFriend.Tag = "";
            this.btnDeleteFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteFriend.Click += new System.EventHandler(this.btnDeleteFriend_Click);
            // 
            // ucContactHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContactHandleContent);
            this.Controls.Add(this.panel1);
            this.Name = "ucContactHandle";
            this.Size = new System.Drawing.Size(858, 759);
            this.pnlContactFriendHandle.ResumeLayout(false);
            this.pnlContactHandleContent.ResumeLayout(false);
            this.pnlContactHandleContent.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbContactHandleScript1;
        private System.Windows.Forms.Label lbContactHandleScript2;
        private System.Windows.Forms.Panel pnlContactFriendHandle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContact;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSendRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContactHandleContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbContactHandleTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddFriend;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteFriend;
    }
}
