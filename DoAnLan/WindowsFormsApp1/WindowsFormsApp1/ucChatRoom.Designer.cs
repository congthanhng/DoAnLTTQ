namespace WindowsFormsApp1
{
    partial class ucChatRoom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChatRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRoomAdmin = new System.Windows.Forms.Panel();
            this.lbRoomAdminName = new System.Windows.Forms.Label();
            this.picRoomAdmin = new System.Windows.Forms.PictureBox();
            this.lbRoomAdmin = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlRoomAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomAdmin)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlRoomAdmin);
            this.panel1.Controls.Add(this.lbRoomAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 173);
            this.panel1.TabIndex = 0;
            // 
            // pnlRoomAdmin
            // 
            this.pnlRoomAdmin.Controls.Add(this.lbRoomAdminName);
            this.pnlRoomAdmin.Controls.Add(this.picRoomAdmin);
            this.pnlRoomAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRoomAdmin.Location = new System.Drawing.Point(0, 50);
            this.pnlRoomAdmin.Name = "pnlRoomAdmin";
            this.pnlRoomAdmin.Size = new System.Drawing.Size(260, 123);
            this.pnlRoomAdmin.TabIndex = 1;
            // 
            // lbRoomAdminName
            // 
            this.lbRoomAdminName.AutoSize = true;
            this.lbRoomAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomAdminName.Location = new System.Drawing.Point(96, 46);
            this.lbRoomAdminName.Name = "lbRoomAdminName";
            this.lbRoomAdminName.Size = new System.Drawing.Size(125, 25);
            this.lbRoomAdminName.TabIndex = 1;
            this.lbRoomAdminName.Text = "Admin Name";
            // 
            // picRoomAdmin
            // 
            this.picRoomAdmin.BackColor = System.Drawing.Color.Transparent;
            this.picRoomAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picRoomAdmin.Image")));
            this.picRoomAdmin.Location = new System.Drawing.Point(3, 13);
            this.picRoomAdmin.Name = "picRoomAdmin";
            this.picRoomAdmin.Size = new System.Drawing.Size(87, 81);
            this.picRoomAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRoomAdmin.TabIndex = 0;
            this.picRoomAdmin.TabStop = false;
            // 
            // lbRoomAdmin
            // 
            this.lbRoomAdmin.AutoSize = true;
            this.lbRoomAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.lbRoomAdmin.Location = new System.Drawing.Point(75, 13);
            this.lbRoomAdmin.Name = "lbRoomAdmin";
            this.lbRoomAdmin.Size = new System.Drawing.Size(73, 23);
            this.lbRoomAdmin.TabIndex = 0;
            this.lbRoomAdmin.Text = "Admin";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 100;
            this.bunifuElipse1.TargetControl = this.picRoomAdmin;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 661);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 147);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 488);
            this.panel3.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 65);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(207, 385);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Online";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(79, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invite ";
            // 
            // ucChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucChatRoom";
            this.Size = new System.Drawing.Size(260, 808);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRoomAdmin.ResumeLayout(false);
            this.pnlRoomAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomAdmin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRoomAdmin;
        private System.Windows.Forms.Panel pnlRoomAdmin;
        private System.Windows.Forms.Label lbRoomAdminName;
        private System.Windows.Forms.PictureBox picRoomAdmin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
    }
}
