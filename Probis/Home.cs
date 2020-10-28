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
    public partial class Home : Form
    {
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        public Home()
        {
            InitializeComponent();
            lbl_user.Text = form_login.user;
            loaddgv();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void loaddgv()
        {
            conn.Close();
            OracleCommand cmd = new OracleCommand("select tour_id,tour_nama,tour_harga,tour_date_awal from paket_tour where tour_status = 1",conn);
            da= new OracleDataAdapter(cmd);
            ds= new DataSet();
            conn.Close();
            da.Fill(ds);
            da.Fill(ds, "paket");
            dgv_list.DataSource = ds;
            dgv_list.DataMember = "paket";
        }

        private void dgv_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

            }
        }
    }
}
