namespace MTPL_CPanel
{
    partial class Frm_LoadingScreen
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
            this.PBox_Loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBox_Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // PBox_Loading
            // 
            this.PBox_Loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBox_Loading.Image = global::MTPL_CPanel.Properties.Resources.preloader;
            this.PBox_Loading.Location = new System.Drawing.Point(0, 0);
            this.PBox_Loading.Name = "PBox_Loading";
            this.PBox_Loading.Size = new System.Drawing.Size(355, 181);
            this.PBox_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBox_Loading.TabIndex = 0;
            this.PBox_Loading.TabStop = false;
            // 
            // Frm_LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 181);
            this.Controls.Add(this.PBox_Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LoadingScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_LoadingScreen";
            this.TopMost = true;
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.PBox_Loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBox_Loading;
    }
}