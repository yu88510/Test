
namespace CAW
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCaw = new System.Windows.Forms.Button();
            this.lblCaw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCaw
            // 
            this.btnCaw.BackColor = System.Drawing.Color.Transparent;
            this.btnCaw.FlatAppearance.BorderSize = 0;
            this.btnCaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaw.Location = new System.Drawing.Point(1333, 44);
            this.btnCaw.Name = "btnCaw";
            this.btnCaw.Size = new System.Drawing.Size(55, 27);
            this.btnCaw.TabIndex = 1;
            this.btnCaw.UseVisualStyleBackColor = false;
            this.btnCaw.Click += new System.EventHandler(this.btnCaw_Click);
            // 
            // lblCaw
            // 
            this.lblCaw.BackColor = System.Drawing.Color.Transparent;
            this.lblCaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCaw.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCaw.ForeColor = System.Drawing.Color.Black;
            this.lblCaw.Location = new System.Drawing.Point(1562, 315);
            this.lblCaw.Name = "lblCaw";
            this.lblCaw.Size = new System.Drawing.Size(54, 27);
            this.lblCaw.TabIndex = 488;
            this.lblCaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaw.Click += new System.EventHandler(this.lblCaw_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1914, 669);
            this.Controls.Add(this.lblCaw);
            this.Controls.Add(this.btnCaw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAWSNS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCaw;
        internal System.Windows.Forms.Label lblCaw;
    }
}

