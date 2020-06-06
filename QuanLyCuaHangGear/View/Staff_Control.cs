using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGear
{
    public partial class Staff_Control : UserControl
    {
        public Staff_Control()
        {
            InitializeComponent();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AE_Staff_Form ae_f = new AE_Staff_Form();
            ae_f.ShowDialog();
        }

        private void btn_View_Click_1(object sender, EventArgs e)
        {

        }
    }
}
