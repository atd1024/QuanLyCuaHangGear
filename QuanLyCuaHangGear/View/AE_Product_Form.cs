using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGear
{
    public partial class AE_Product_Form : Form
    {
        public AE_Product_Form()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form_Admin f_admin = new Form_Admin();
            this.Close();
            f_admin.Show();
        }
    }
}
