using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGear.View
{
    public partial class Account_Control : UserControl
    {
        public Account_Control()
        {
            InitializeComponent();
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            Form_ChangePass f_Pass = new Form_ChangePass();
            this.Hide();
            f_Pass.Show();
        }
    }
}
