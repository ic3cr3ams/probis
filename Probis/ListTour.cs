using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Probis
{
    public partial class ListTour : Form
    {
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        public ListTour()
        {
            InitializeComponent();
            loadCbox();
        }

        void loadCbox()
        {
            cb_paket.Items.Clear();
            conn.Open();
            OracleCommand query = new OracleCommand("SELECT tour_nama,tour_id,tour_harga FROM paket_tour", conn);
            da = new OracleDataAdapter(query);
            ds = new DataSet();
            conn.Close();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cb_paket.Items.Add(ds.Tables[0].Rows[i][0].ToString()+" - "+ ds.Tables[0].Rows[i][2].ToString());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                comboBox1.Items.Add(ds.Tables[0].Rows[i][1].ToString());
        }

        private void btn_tambahPaket_Click(object sender, EventArgs e)
        {
            Masterdetail m = new Masterdetail();
            this.Hide();
            m.ShowDialog();
            this.Show();
            
        }

        private void cb_paket_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand query = new OracleCommand("SELECT ddari as Dari,ddtujuan as Tujuan,dkendaraan as Kendaraan,dhotel_nama as Hotel,tour_deskripsi as Deskripsi" +
                "                                   FROM dpaket " +
                "                                   where tour_id= '" + comboBox1.Items[cb_paket.SelectedIndex].ToString() + "' ", conn);
            da = new OracleDataAdapter(query);
            ds = new DataSet();
            conn.Close();
            da.Fill(ds, "dpaket");
            dgv_listPaket.DataSource = ds;
            dgv_listPaket.DataMember = "dpaket";
        }
    }
}
