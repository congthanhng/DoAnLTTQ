namespace WindowsFormsApp1
{
    partial class ucMessageHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMessageHeader));
            this.pnlMessageHeader = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbChatHeaderName = new System.Windows.Forms.Label();
            this.pnlMessageHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMessageHeader
            // 
            this.pnlMessageHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMessageHeader.BackgroundImage")));
            this.pnlMessageHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMessageHeader.Controls.Add(this.lbChatHeaderName);
            this.pnlMessageHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessageHeader.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(8)))));
            this.pnlMessageHeader.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(55)))));
            this.pnlMessageHeader.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(8)))));
            this.pnlMessageHeader.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(55)))));
            this.pnlMessageHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlMessageHeader.Name = "pnlMessageHeader";
            this.pnlMessageHeader.Quality = 10;
            this.pnlMessageHeader.Size = new System.Drawing.Size(858, 49);
            this.pnlMessageHeader.TabIndex = 0;
            // 
            // lbChatHeaderName
            // 
            this.lbChatHeaderName.AutoSize = true;
            this.lbChatHeaderName.BackColor = System.Drawing.Color.Transparent;
            this.lbChatHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChatHeaderName.ForeColor = System.Drawing.Color.White;
            this.lbChatHeaderName.Location = new System.Drawing.Point(22, 15);
            this.lbChatHeaderName.Name = "lbChatHeaderName";
            this.lbChatHeaderName.Size = new System.Drawing.Size(196, 25);
            this.lbChatHeaderName.TabIndex = 0;
            this.lbChatHeaderName.Text = "Chat Header Name";
            // 
            // ucMessageHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMessageHeader);
            this.Name = "ucMessageHeader";
            this.Size = new System.Drawing.Size(858, 49);
            this.pnlMessageHeader.ResumeLayout(false);
            this.pnlMessageHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlMessageHeader;
        private System.Windows.Forms.Label lbChatHeaderName;
    }
}
