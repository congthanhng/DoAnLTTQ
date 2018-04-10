namespace WindowsFormsApp1
{
    partial class ucMenuHeader
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
           lbHeaderName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHeaderName
            // 
            lbHeaderName.AutoSize = true;
            lbHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbHeaderName.ForeColor = System.Drawing.Color.White;
            lbHeaderName.Location = new System.Drawing.Point(13, 13);
            lbHeaderName.Name = "lbHeaderName";
            lbHeaderName.Size = new System.Drawing.Size(144, 25);
            lbHeaderName.TabIndex = 0;
            
            // 
            // ucMenuHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(lbHeaderName);
            this.Name = "ucMenuHeader";
            this.Size = new System.Drawing.Size(858, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public static System.Windows.Forms.Label lbHeaderName;
    }
}
