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
    public partial class masterUser : Form
    {
        public masterUser()
        {
            InitializeComponent();
        }
        OracleConnection conn = form_login.conn;
        OracleCommand cmd;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private void masterUser_Load(object sender, EventArgs e)
        {
            conn.Open();
            da = new OracleDataAdapter("Select * from pegawai", conn);
            da.Fill(ds);
            da.Fill(dt);
            dgv_listUser.DataSource = dt;
            conn.Close();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
