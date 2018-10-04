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
    public partial class Brands : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public Brands()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Red200, TextShade.WHITE);
        }
        int hidden;
        private void Btn_InsertPhone_Click(object sender, EventArgs e)
        {
            ConnectionThread ct = new ConnectionThread(this);
            if (cb_hidden.Checked)
            {
                hidden = 1;
            }
            else
                hidden = 0;

            ct.Execute("6", brand_name.Text,hidden.ToString());
            Hide();
           
        }

    }
}
