namespace MTPL_CPanel
{
    partial class Frm_ImageManagement
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
            this.picbox_old = new System.Windows.Forms.PictureBox();
            this.pic_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.picbox_new = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_old)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_new)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_old
            // 
            this.picbox_old.Location = new System.Drawing.Point(12, 149);
            this.picbox_old.Name = "picbox_old";
            this.picbox_old.Size = new System.Drawing.Size(227, 171);
            this.picbox_old.TabIndex = 3;
            this.picbox_old.TabStop = false;
            // 
            // pic_name
            // 
            this.pic_name.BackColor = System.Drawing.Color.White;
            this.pic_name.Depth = 0;
            this.pic_name.Enabled = false;
            this.pic_name.Hint = "";
            this.pic_name.Location = new System.Drawing.Point(12, 85);
            this.pic_name.MaxLength = 32767;
            this.pic_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.pic_name.Name = "pic_name";
            this.pic_name.PasswordChar = '\0';
            this.pic_name.SelectedText = "";
            this.pic_name.SelectionLength = 0;
            this.pic_name.SelectionStart = 0;
            this.pic_name.Size = new System.Drawing.Size(377, 23);
            this.pic_name.TabIndex = 5;
            this.pic_name.TabStop = false;
            this.pic_name.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(402, 85);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "Browse";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // picbox_new
            // 
            this.picbox_new.Location = new System.Drawing.Point(245, 149);
            this.picbox_new.Name = "picbox_new";
            this.picbox_new.Size = new System.Drawing.Size(227, 171);
            this.picbox_new.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_new.TabIndex = 7;
            this.picbox_new.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 127);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Old Image:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(241, 127);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "New Image:";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(358, 334);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(114, 36);
            this.materialRaisedButton1.TabIndex = 10;
            this.materialRaisedButton1.Text = "Upload & Set";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-2, 327);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(495, 1);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // Frm_ImageManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 377);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.picbox_new);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.pic_name);
            this.Controls.Add(this.picbox_old);
            this.Name = "Frm_ImageManagement";
            this.Text = "Image Management";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_old)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_new)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picbox_old;
        private MaterialSkin.Controls.MaterialSingleLineTextField pic_name;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.PictureBox picbox_new;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}