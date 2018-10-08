namespace MTPL_CPanel
{
    partial class Frm_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.phoneid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_InsertPhone = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cb_hidden = new MaterialSkin.Controls.MaterialCheckBox();
            this.Btn_UpdatePhone = new MaterialSkin.Controls.MaterialFlatButton();
            this.Btn_DeletePhone = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbox_brand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_price = new System.Windows.Forms.NumericUpDown();
            this.txt_desc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_ResetNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.edit_image = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneid,
            this.phonename,
            this.phoneprice,
            this.description});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.Location = new System.Drawing.Point(12, 239);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(693, 241);
            this.dgv.TabIndex = 5;
            // 
            // phoneid
            // 
            this.phoneid.HeaderText = "ID";
            this.phoneid.Name = "phoneid";
            this.phoneid.ReadOnly = true;
            // 
            // phonename
            // 
            this.phonename.HeaderText = "Name";
            this.phonename.Name = "phonename";
            this.phonename.ReadOnly = true;
            // 
            // phoneprice
            // 
            this.phoneprice.HeaderText = "Price";
            this.phoneprice.Name = "phoneprice";
            this.phoneprice.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // Btn_InsertPhone
            // 
            this.Btn_InsertPhone.AutoSize = true;
            this.Btn_InsertPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_InsertPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_InsertPhone.Depth = 0;
            this.Btn_InsertPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_InsertPhone.Icon = null;
            this.Btn_InsertPhone.Location = new System.Drawing.Point(631, 139);
            this.Btn_InsertPhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_InsertPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_InsertPhone.Name = "Btn_InsertPhone";
            this.Btn_InsertPhone.Primary = true;
            this.Btn_InsertPhone.Size = new System.Drawing.Size(51, 36);
            this.Btn_InsertPhone.TabIndex = 14;
            this.Btn_InsertPhone.Text = "new";
            this.Btn_InsertPhone.UseVisualStyleBackColor = true;
            this.Btn_InsertPhone.Click += new System.EventHandler(this.Btn_InsertPhone_Click);
            // 
            // cb_hidden
            // 
            this.cb_hidden.AutoSize = true;
            this.cb_hidden.Depth = 0;
            this.cb_hidden.Font = new System.Drawing.Font("Roboto", 10F);
            this.cb_hidden.Location = new System.Drawing.Point(16, 143);
            this.cb_hidden.Margin = new System.Windows.Forms.Padding(0);
            this.cb_hidden.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cb_hidden.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_hidden.Name = "cb_hidden";
            this.cb_hidden.Ripple = true;
            this.cb_hidden.Size = new System.Drawing.Size(74, 30);
            this.cb_hidden.TabIndex = 17;
            this.cb_hidden.Text = "Hidden";
            this.cb_hidden.UseVisualStyleBackColor = true;
            // 
            // Btn_UpdatePhone
            // 
            this.Btn_UpdatePhone.AutoSize = true;
            this.Btn_UpdatePhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_UpdatePhone.Depth = 0;
            this.Btn_UpdatePhone.Icon = null;
            this.Btn_UpdatePhone.Location = new System.Drawing.Point(550, 139);
            this.Btn_UpdatePhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_UpdatePhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_UpdatePhone.Name = "Btn_UpdatePhone";
            this.Btn_UpdatePhone.Primary = true;
            this.Btn_UpdatePhone.Size = new System.Drawing.Size(73, 36);
            this.Btn_UpdatePhone.TabIndex = 16;
            this.Btn_UpdatePhone.Text = "Update";
            this.Btn_UpdatePhone.UseVisualStyleBackColor = true;
            this.Btn_UpdatePhone.Click += new System.EventHandler(this.Btn_UpdatePhone_Click);
            // 
            // Btn_DeletePhone
            // 
            this.Btn_DeletePhone.AutoSize = true;
            this.Btn_DeletePhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_DeletePhone.Depth = 0;
            this.Btn_DeletePhone.Icon = null;
            this.Btn_DeletePhone.Location = new System.Drawing.Point(473, 139);
            this.Btn_DeletePhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_DeletePhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_DeletePhone.Name = "Btn_DeletePhone";
            this.Btn_DeletePhone.Primary = false;
            this.Btn_DeletePhone.Size = new System.Drawing.Size(69, 36);
            this.Btn_DeletePhone.TabIndex = 17;
            this.Btn_DeletePhone.Text = "Delete";
            this.Btn_DeletePhone.UseVisualStyleBackColor = true;
            this.Btn_DeletePhone.Click += new System.EventHandler(this.Btn_DeletePhone_Click);
            // 
            // cbox_brand
            // 
            this.cbox_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbox_brand.ForeColor = System.Drawing.Color.Black;
            this.cbox_brand.FormattingEnabled = true;
            this.cbox_brand.Location = new System.Drawing.Point(151, 103);
            this.cbox_brand.Name = "cbox_brand";
            this.cbox_brand.Size = new System.Drawing.Size(121, 26);
            this.cbox_brand.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Phone Name";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.Depth = 0;
            this.txt_name.Hint = "";
            this.txt_name.Location = new System.Drawing.Point(16, 107);
            this.txt_name.MaxLength = 32767;
            this.txt_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.Size = new System.Drawing.Size(129, 23);
            this.txt_name.TabIndex = 21;
            this.txt_name.TabStop = false;
            this.txt_name.UseSystemPasswordChar = false;
            // 
            // txt_price
            // 
            this.txt_price.DecimalPlaces = 2;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_price.Location = new System.Drawing.Point(278, 105);
            this.txt_price.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(83, 24);
            this.txt_price.TabIndex = 25;
            // 
            // txt_desc
            // 
            this.txt_desc.Depth = 0;
            this.txt_desc.Hint = "";
            this.txt_desc.Location = new System.Drawing.Point(367, 107);
            this.txt_desc.MaxLength = 32767;
            this.txt_desc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.PasswordChar = '\0';
            this.txt_desc.SelectedText = "";
            this.txt_desc.SelectionLength = 0;
            this.txt_desc.SelectionStart = 0;
            this.txt_desc.Size = new System.Drawing.Size(337, 23);
            this.txt_desc.TabIndex = 23;
            this.txt_desc.TabStop = false;
            this.txt_desc.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(147, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(274, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(363, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Description";
            // 
            // Btn_ResetNew
            // 
            this.Btn_ResetNew.AutoSize = true;
            this.Btn_ResetNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ResetNew.Depth = 0;
            this.Btn_ResetNew.Icon = null;
            this.Btn_ResetNew.Location = new System.Drawing.Point(593, 139);
            this.Btn_ResetNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_ResetNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_ResetNew.Name = "Btn_ResetNew";
            this.Btn_ResetNew.Primary = true;
            this.Btn_ResetNew.Size = new System.Drawing.Size(30, 36);
            this.Btn_ResetNew.TabIndex = 32;
            this.Btn_ResetNew.Text = "X";
            this.Btn_ResetNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ResetNew.UseVisualStyleBackColor = true;
            this.Btn_ResetNew.Visible = false;
            this.Btn_ResetNew.Click += new System.EventHandler(this.Btn_ResetNew_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(607, 187);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(97, 36);
            this.materialFlatButton1.TabIndex = 33;
            this.materialFlatButton1.Text = "Add Brand";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(473, 187);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(117, 36);
            this.materialFlatButton2.TabIndex = 34;
            this.materialFlatButton2.Text = "Delete Brand";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // edit_image
            // 
            this.edit_image.AutoSize = true;
            this.edit_image.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edit_image.Depth = 0;
            this.edit_image.Icon = null;
            this.edit_image.Location = new System.Drawing.Point(338, 172);
            this.edit_image.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit_image.Name = "edit_image";
            this.edit_image.Primary = true;
            this.edit_image.Size = new System.Drawing.Size(95, 36);
            this.edit_image.TabIndex = 35;
            this.edit_image.Text = "Edit Image";
            this.edit_image.UseVisualStyleBackColor = true;
            this.edit_image.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 492);
            this.Controls.Add(this.edit_image);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbox_brand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.Btn_DeletePhone);
            this.Controls.Add(this.cb_hidden);
            this.Controls.Add(this.Btn_InsertPhone);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Btn_UpdatePhone);
            this.Controls.Add(this.Btn_ResetNew);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Frm_Main";
            this.Text = "Price List Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialRaisedButton Btn_InsertPhone;
        private MaterialSkin.Controls.MaterialFlatButton Btn_UpdatePhone;
        public MaterialSkin.Controls.MaterialCheckBox cb_hidden;
        private MaterialSkin.Controls.MaterialFlatButton Btn_DeletePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneid;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonename;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        public System.Windows.Forms.ComboBox cbox_brand;
        private System.Windows.Forms.Label label1;
        public MaterialSkin.Controls.MaterialSingleLineTextField txt_name;
        public System.Windows.Forms.NumericUpDown txt_price;
        public MaterialSkin.Controls.MaterialSingleLineTextField txt_desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialFlatButton Btn_ResetNew;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialRaisedButton edit_image;
    }
}

