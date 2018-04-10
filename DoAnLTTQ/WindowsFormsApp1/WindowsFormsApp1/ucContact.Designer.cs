namespace WindowsFormsApp1
{
    partial class ucContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucContact));
            this.pnlContactList = new System.Windows.Forms.FlowLayoutPanel();
            this.lbYourFriend = new System.Windows.Forms.Label();
            this.btnFriend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbHasFriend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlContactList
            // 
            this.pnlContactList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContactList.AutoScroll = true;
            this.pnlContactList.AutoScrollMinSize = new System.Drawing.Size(80, 0);
            this.pnlContactList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContactList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlContactList.Location = new System.Drawing.Point(18, 275);
            this.pnlContactList.Name = "pnlContactList";
            this.pnlContactList.Size = new System.Drawing.Size(226, 432);
            this.pnlContactList.TabIndex = 0;
            this.pnlContactList.WrapContents = false;
            // 
            // lbYourFriend
            // 
            this.lbYourFriend.AutoSize = true;
            this.lbYourFriend.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourFriend.ForeColor = System.Drawing.Color.White;
            this.lbYourFriend.Location = new System.Drawing.Point(15, 195);
            this.lbYourFriend.Name = "lbYourFriend";
            this.lbYourFriend.Size = new System.Drawing.Size(123, 22);
            this.lbYourFriend.TabIndex = 2;
            this.lbYourFriend.Text = "Your Friends:";
            // 
            // btnFriend
            // 
            this.btnFriend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnFriend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFriend.BorderRadius = 0;
            this.btnFriend.ButtonText = "Friends";
            this.btnFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFriend.DisabledColor = System.Drawing.Color.Gray;
            this.btnFriend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFriend.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFriend.Iconimage")));
            this.btnFriend.Iconimage_right = null;
            this.btnFriend.Iconimage_right_Selected = null;
            this.btnFriend.Iconimage_Selected = null;
            this.btnFriend.IconMarginLeft = 0;
            this.btnFriend.IconMarginRight = 0;
            this.btnFriend.IconRightVisible = true;
            this.btnFriend.IconRightZoom = 0D;
            this.btnFriend.IconVisible = true;
            this.btnFriend.IconZoom = 90D;
            this.btnFriend.IsTab = false;
            this.btnFriend.Location = new System.Drawing.Point(18, 41);
            this.btnFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnFriend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnFriend.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFriend.selected = false;
            this.btnFriend.Size = new System.Drawing.Size(226, 59);
            this.btnFriend.TabIndex = 1;
            this.btnFriend.Text = "Friends";
            this.btnFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFriend.Textcolor = System.Drawing.Color.White;
            this.btnFriend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriend.Click += new System.EventHandler(this.btnFriend_Click);
            // 
            // lbHasFriend
            // 
            this.lbHasFriend.AutoSize = true;
            this.lbHasFriend.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHasFriend.ForeColor = System.Drawing.Color.White;
            this.lbHasFriend.Location = new System.Drawing.Point(16, 241);
            this.lbHasFriend.Name = "lbHasFriend";
            this.lbHasFriend.Size = new System.Drawing.Size(238, 18);
            this.lbHasFriend.TabIndex = 3;
            this.lbHasFriend.Text = "Oops, you dont have any friend";
            // 
            // ucContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbHasFriend);
            this.Controls.Add(this.lbYourFriend);
            this.Controls.Add(this.btnFriend);
            this.Controls.Add(this.pnlContactList);
            this.Name = "ucContact";
            this.Size = new System.Drawing.Size(260, 759);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlContactList;
        private Bunifu.Framework.UI.BunifuFlatButton btnFriend;
        private System.Windows.Forms.Label lbYourFriend;
        private System.Windows.Forms.Label lbHasFriend;
    }
}
