namespace WindowsFormsApp1
{
    partial class ucGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGroup));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbHasGroup = new System.Windows.Forms.Label();
            this.btnJoinGroup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbYourGroup = new System.Windows.Forms.Label();
            this.btnCreateGroup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 310);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(241, 418);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbHasGroup
            // 
            this.lbHasGroup.AutoSize = true;
            this.lbHasGroup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHasGroup.ForeColor = System.Drawing.Color.White;
            this.lbHasGroup.Location = new System.Drawing.Point(16, 241);
            this.lbHasGroup.Name = "lbHasGroup";
            this.lbHasGroup.Size = new System.Drawing.Size(237, 18);
            this.lbHasGroup.TabIndex = 1;
            this.lbHasGroup.Text = "Oops, you dont have any group";
            // 
            // btnJoinGroup
            // 
            this.btnJoinGroup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnJoinGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnJoinGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJoinGroup.BorderRadius = 0;
            this.btnJoinGroup.ButtonText = "JOIN";
            this.btnJoinGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoinGroup.DisabledColor = System.Drawing.Color.Gray;
            this.btnJoinGroup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnJoinGroup.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnJoinGroup.Iconimage")));
            this.btnJoinGroup.Iconimage_right = null;
            this.btnJoinGroup.Iconimage_right_Selected = null;
            this.btnJoinGroup.Iconimage_Selected = null;
            this.btnJoinGroup.IconMarginLeft = 0;
            this.btnJoinGroup.IconMarginRight = 0;
            this.btnJoinGroup.IconRightVisible = true;
            this.btnJoinGroup.IconRightZoom = 0D;
            this.btnJoinGroup.IconVisible = true;
            this.btnJoinGroup.IconZoom = 90D;
            this.btnJoinGroup.IsTab = false;
            this.btnJoinGroup.Location = new System.Drawing.Point(18, 41);
            this.btnJoinGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJoinGroup.Name = "btnJoinGroup";
            this.btnJoinGroup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnJoinGroup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnJoinGroup.OnHoverTextColor = System.Drawing.Color.White;
            this.btnJoinGroup.selected = false;
            this.btnJoinGroup.Size = new System.Drawing.Size(226, 59);
            this.btnJoinGroup.TabIndex = 2;
            this.btnJoinGroup.Text = "JOIN";
            this.btnJoinGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJoinGroup.Textcolor = System.Drawing.Color.White;
            this.btnJoinGroup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lbYourGroup
            // 
            this.lbYourGroup.AutoSize = true;
            this.lbYourGroup.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourGroup.ForeColor = System.Drawing.Color.White;
            this.lbYourGroup.Location = new System.Drawing.Point(15, 195);
            this.lbYourGroup.Name = "lbYourGroup";
            this.lbYourGroup.Size = new System.Drawing.Size(116, 22);
            this.lbYourGroup.TabIndex = 3;
            this.lbYourGroup.Text = "Your Group";
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(117)))));
            this.btnCreateGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.btnCreateGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateGroup.BorderRadius = 0;
            this.btnCreateGroup.ButtonText = "CREATE";
            this.btnCreateGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateGroup.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreateGroup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreateGroup.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreateGroup.Iconimage")));
            this.btnCreateGroup.Iconimage_right = null;
            this.btnCreateGroup.Iconimage_right_Selected = null;
            this.btnCreateGroup.Iconimage_Selected = null;
            this.btnCreateGroup.IconMarginLeft = 0;
            this.btnCreateGroup.IconMarginRight = 0;
            this.btnCreateGroup.IconRightVisible = true;
            this.btnCreateGroup.IconRightZoom = 0D;
            this.btnCreateGroup.IconVisible = true;
            this.btnCreateGroup.IconZoom = 90D;
            this.btnCreateGroup.IsTab = false;
            this.btnCreateGroup.Location = new System.Drawing.Point(18, 108);
            this.btnCreateGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.btnCreateGroup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(117)))));
            this.btnCreateGroup.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreateGroup.selected = false;
            this.btnCreateGroup.Size = new System.Drawing.Size(226, 59);
            this.btnCreateGroup.TabIndex = 2;
            this.btnCreateGroup.Text = "CREATE";
            this.btnCreateGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateGroup.Textcolor = System.Drawing.Color.White;
            this.btnCreateGroup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ucGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbYourGroup);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.btnJoinGroup);
            this.Controls.Add(this.lbHasGroup);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ucGroup";
            this.Size = new System.Drawing.Size(260, 759);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbHasGroup;
        private Bunifu.Framework.UI.BunifuFlatButton btnJoinGroup;
        private System.Windows.Forms.Label lbYourGroup;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreateGroup;
    }
}
