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
    public partial class Frm_ImageManagement : MaterialSkin.Controls.MaterialForm
    {
        public Frm_ImageManagement()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image (*.jpg)|*.jpg";
            ofd.Title = "Select a Image";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picbox_new.Image= new Bitmap(ofd.FileName);
            }
            pic_name.Text = ofd.FileName;
            ofd.Dispose();
        }
    }
}
