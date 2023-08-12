
namespace CAW {
    partial class frmCAW {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCAW));
            this.lblCaw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCaw
            // 
            this.lblCaw.BackColor = System.Drawing.Color.Transparent;
            this.lblCaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCaw.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCaw.ForeColor = System.Drawing.Color.Black;
            this.lblCaw.Location = new System.Drawing.Point(261, 276);
            this.lblCaw.Name = "lblCaw";
            this.lblCaw.Size = new System.Drawing.Size(54, 27);
            this.lblCaw.TabIndex = 489;
            this.lblCaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaw.Click += new System.EventHandler(this.lblCaw_Click);
            // 
            // frmCAW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1155, 653);
            this.Controls.Add(this.lblCaw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCAW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RYOSHI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblCaw;
    }
}