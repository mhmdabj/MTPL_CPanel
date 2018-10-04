namespace MTPL_CPanel
{
    partial class Brands
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
            this.label1 = new System.Windows.Forms.Label();
            this.brand_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Btn_InsertPhone = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cb_hidden = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Brand Name";
            // 
            // brand_name
            // 
            this.brand_name.BackColor = System.Drawing.Color.White;
            this.brand_name.Depth = 0;
            this.brand_name.Hint = "";
            this.brand_name.Location = new System.Drawing.Point(27, 114);
            this.brand_name.MaxLength = 32767;
            this.brand_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.brand_name.Name = "brand_name";
            this.brand_name.PasswordChar = '\0';
            this.brand_name.SelectedText = "";
            this.brand_name.SelectionLength = 0;
            this.brand_name.SelectionStart = 0;
            this.brand_name.Size = new System.Drawing.Size(129, 23);
            this.brand_name.TabIndex = 28;
            this.brand_name.TabStop = false;
            this.brand_name.UseSystemPasswordChar = false;
            // 
            // Btn_InsertPhone
            // 
            this.Btn_InsertPhone.AutoSize = true;
            this.Btn_InsertPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_InsertPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_InsertPhone.Depth = 0;
            this.Btn_InsertPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_InsertPhone.Icon = null;
            this.Btn_InsertPhone.Location = new System.Drawing.Point(222, 101);
            this.Btn_InsertPhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_InsertPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_InsertPhone.Name = "Btn_InsertPhone";
            this.Btn_InsertPhone.Primary = true;
            this.Btn_InsertPhone.Size = new System.Drawing.Size(51, 36);
            this.Btn_InsertPhone.TabIndex = 29;
            this.Btn_InsertPhone.Text = "new";
            this.Btn_InsertPhone.UseVisualStyleBackColor = true;
            this.Btn_InsertPhone.Click += new System.EventHandler(this.Btn_InsertPhone_Click);
            // 
            // cb_hidden
            // 
            this.cb_hidden.AutoSize = true;
            this.cb_hidden.Depth = 0;
            this.cb_hidden.Font = new System.Drawing.Font("Roboto", 10F);
            this.cb_hidden.Location = new System.Drawing.Point(27, 152);
            this.cb_hidden.Margin = new System.Windows.Forms.Padding(0);
            this.cb_hidden.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cb_hidden.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_hidden.Name = "cb_hidden";
            this.cb_hidden.Ripple = true;
            this.cb_hidden.Size = new System.Drawing.Size(74, 30);
            this.cb_hidden.TabIndex = 30;
            this.cb_hidden.Text = "Hidden";
            this.cb_hidden.UseVisualStyleBackColor = true;
            // 
            // Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 200);
            this.Controls.Add(this.cb_hidden);
            this.Controls.Add(this.Btn_InsertPhone);
            this.Controls.Add(this.brand_name);
            this.Controls.Add(this.label1);
            this.Name = "Brands";
            this.Text = "Brands";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public MaterialSkin.Controls.MaterialSingleLineTextField brand_name;
        private MaterialSkin.Controls.MaterialRaisedButton Btn_InsertPhone;
        public MaterialSkin.Controls.MaterialCheckBox cb_hidden;
    }
}