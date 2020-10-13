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
    public partial class lisHotel : Form
    {
        public lisHotel()
        {
            InitializeComponent();

        }
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt = new DataTable();


        private void lisHotel_Load(object sender, EventArgs e)
        {
            conn.Open();
            da = new OracleDataAdapter("Select hotel_id as id,hotel_name as nama,hotel_kota as kota,hotel_negara as negara,hotel_harga as harga from hotel", conn);
            ds = new DataSet();
            da.Fill(ds);
            da.Fill(dt);
            dgv_listHotel.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_baru_Click(object sender, EventArgs e)
        {
            addHotel add = new addHotel();
            add.ShowDialog();
            this.Show();
            lisHotel_Load(sender, e);
        }
    }
}
