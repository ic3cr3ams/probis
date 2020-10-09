using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Probis
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }
        OracleConnection conn = form_login.conn;

        private void btnUser_Click(object sender, EventArgs e)
        {
            masterUser masterUser = new masterUser();
            masterUser.Show();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            lbl_user.Text = "Admin";
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
