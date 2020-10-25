using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace Probis
{
    public partial class Masterdetail : Form
    {
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        public static bool master=false;
        int total = 0, ctr = 1;
        public Masterdetail()
        {
            InitializeComponent();
        }
       
        private void gb_detail_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_pilih.Visible = true;
        }

        private void btn_pilihHotel_Click(object sender, EventArgs e)
        {
            lisHotel lisHotel= new lisHotel();
            master = true;
            this.Hide();
            lisHotel.ShowDialog();
            this.Show();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            ctr++;
            if (ctr == total) { gb_detail.Visible = false;nud_lama.Enabled = false;txt_nPaket.Enabled = false; }
            conn.Close();
            conn.Open();
            da = new OracleDataAdapter("Select tour_id as id from paket_tour", conn);
            string lastid = "";
            int lastidangka=0;
            da.Fill(ds);
            if (ds.Tables.Count != 0)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        lastid = row["id"].ToString();
                        lastidangka = int.Parse(lastid.Substring(2, 4));
                    }
                }
            }
            int idangka = lastidangka + 1;
            string idinput = "PT";
            if (idangka < 10) idinput += "000" + idangka;
            else if (idangka >= 10 && idangka < 100) idinput += "00" + idangka;
            else if (idangka >= 100 && idangka < 1000) idinput += "0" + idangka;
            else if (idangka >= 1000 && idangka < 10000) idinput += idangka;
            MessageBox.Show(idinput);
            string nama;
            string tanggal ;
            string dari;
            string tujuan;
            string jenis;
            string hotel;
            string deskripsi;
            /*ma.Text;
            string kota = txt_kota.Text;
            string negara = txt_negara.Text;
            OracleCommand cmd = new OracleCommand("INSERT INTO HOTEL VALUES('" + idinput + "','" + nama + "',upper('" + kota + "'),upper('" + negara + "'))", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sukes Input Data Hotel");
            txt_nama.Text = "";
            txt_kota.Text = "";
            txt_negara.Text = "";
            conn.Close();*/
        
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            txt_nPaket.Enabled = false;
            nud_lama.Enabled = false;
            total = Convert.ToInt32(nud_lama.Value);
            if(txt_nPaket.Text=="" && total < 1) { MessageBox.Show("Data Tidak Tepat / Kosong"); }
            else gb_detail.Visible = true;
            lbl_hari.Text = ctr.ToString();

        }
    }
}
