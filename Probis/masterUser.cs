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
            dgv_listUser.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_baru_Click(object sender, EventArgs e)
        {
            add_user add = new add_user();
            add.ShowDialog();
            Loaddata();
            this.Show();
        }
        void Loaddata() 
        {
            conn.Open();
            da = new OracleDataAdapter("Select * from pegawai", conn);
            ds = new DataSet();
            da.Fill(ds);
            dgv_listUser.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
