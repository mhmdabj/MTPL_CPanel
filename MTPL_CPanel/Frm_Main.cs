using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTPL_CPanel
{
    public partial class Frm_Main : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public Frm_Main()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Red200, TextShade.WHITE);
            Refreshphones();
            Refreshbrands();
            
            this.dgv.Click += new EventHandler(Dgv_CellContentClick);
        }
        public void Refreshbrands()
        {
            cbox_brand.Items.Clear();
            ConnectionThread ct2 = new ConnectionThread(this);
            ct2.Execute("3");

        }
        public void Refreshphones()
        {
            dgv.Rows.Clear();
            dgv.Refresh();
            ConnectionThread ct = new ConnectionThread(this);
            ct.Execute("1");


        }
        int hidden;
        private void Btn_InsertPhone_Click(object sender, EventArgs e)
        {
            if (Btn_InsertPhone.Text.Equals("new"))
            {
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.LightBlue200, TextShade.WHITE);
                Btn_InsertPhone.Text = "submit";
                Btn_ResetNew.Visible = true;
                Btn_DeletePhone.Visible = false;
                Btn_UpdatePhone.Visible = false;
                txt_desc.Text = "";
                txt_name.Text = "";
                txt_price.Value = 0;
                cb_hidden.Checked = false; 
            }
            else
            {
                ConnectionThread ct = new ConnectionThread(this);
                if (cb_hidden.Checked)
                {
                    hidden = 1;
                }
                else
                    hidden = 0;
                ComboBox_ItemRow the_item = (ComboBox_ItemRow)cbox_brand.SelectedItem;
                ct.Execute("2", txt_name.Text, txt_desc.Text, txt_price.Value.ToString(), hidden.ToString(), the_item.getId());
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Red200, TextShade.WHITE);
                Btn_InsertPhone.Text = "new";
                Btn_ResetNew.Visible = false;
                Btn_DeletePhone.Visible = true;
                Btn_UpdatePhone.Visible = true;
            }
            
            
        }

        private void Btn_DeletePhone_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ConnectionThread ct = new ConnectionThread(this);
                ct.Execute("4", dgv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Btn_UpdatePhone_Click(object sender, EventArgs e)
        {
            ConnectionThread ct = new ConnectionThread(this);
            ComboBox_ItemRow the_item = (ComboBox_ItemRow)cbox_brand.SelectedItem;
            ct.Execute("5", dgv.SelectedRows[0].Cells[0].Value.ToString(),txt_name.Text,txt_desc.Text,txt_price.Value.ToString(), hidden.ToString(), the_item.getId());
        }

        private void Dgv_CellContentClick(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                txt_name.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                txt_price.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                txt_desc.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
            }
            
        }

        private void Btn_ResetNew_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Red200, TextShade.WHITE);
            Btn_InsertPhone.Text = "new";
            Btn_ResetNew.Visible = false;
            Btn_DeletePhone.Visible = true;
            Btn_UpdatePhone.Visible = true;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.ShowDialog();
            Refreshbrands();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            ConnectionThread ct = new ConnectionThread(this);
            ComboBox_ItemRow the_item = (ComboBox_ItemRow)cbox_brand.SelectedItem;
            ct.Execute("7",the_item.getId());
            Refreshbrands();
            Refreshphones();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Frm_ImageManagement imageManagement = new Frm_ImageManagement();
            imageManagement.ShowDialog();
        }

        
    }
}

