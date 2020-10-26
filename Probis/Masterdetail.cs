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
        string dari = "-";
        string tujuan = "-";
        string jenis = "-";
        string idinput = "";
        string deskripsi = "-";
        public static bool master=false;
        int total = 0, ctr = 1, harga = 0, totalharga;
        public static string namahotel, idhotel;
        public static int hargahotel=0;
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

        private void txt_dari_Leave(object sender, EventArgs e)
        {
            dari = txt_dari.Text;
        }

        private void txt_tujuan_Leave(object sender, EventArgs e)
        {
            tujuan = txt_tujuan.Text;
        }

        private void txt_catat_Leave(object sender, EventArgs e)
        {
            deskripsi = txt_catat.Text;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (txt_dari.Text != "" && txt_tujuan.Text != "")
            {
                if (jenis == "Bis")
                {
                    totalharga += 500000;
                }
                else if (jenis == "Pesawat")
                {
                    totalharga += 1000000;
                }
                if (hargahotel != 0)
                {
                    totalharga += hargahotel;
                }
                hargahotel = 0;
                if (ctr == total)
                {
                    gb_detail.Visible = false; nud_lama.Enabled = false; txt_nPaket.Enabled = false;
                    conn.Close();
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("INSERT INTO dpaket VALUES('" + idinput + "','" + dari + "','" + tujuan + "','" + jenis + "','" + namahotel + "','" + deskripsi + "')", conn);
                    cmd.ExecuteNonQuery();
                     cmd = new OracleCommand("update paket_tour set tour_harga = '" + totalharga + "' where tour_id = '" + idinput + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    if (ctr == 1)
                    {
                        conn.Close();
                        conn.Open();
                        da = new OracleDataAdapter("Select tour_id as id from paket_tour", conn);
                        string lastid = "";
                        int lastidangka = 0;
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
                        idinput = "PT";
                        if (idangka < 10) idinput += "000" + idangka;
                        else if (idangka >= 10 && idangka < 100) idinput += "00" + idangka;
                        else if (idangka >= 100 && idangka < 1000) idinput += "0" + idangka;
                        else if (idangka >= 1000 && idangka < 10000) idinput += idangka;
                        OracleCommand cmd = new OracleCommand("INSERT INTO paket_tour VALUES('" + idinput + "','"+txt_nPaket.Text+"','" + 1 + "','" + 0 + "',to_date('" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','YYYY-MM-DD'))", conn);
                        cmd.ExecuteNonQuery();



                        cmd = new OracleCommand("INSERT INTO dpaket VALUES('" + idinput + "','" + dari + "','" + tujuan + "','" + jenis + "','" + namahotel + "','" + deskripsi + "')", conn);
                        cmd.ExecuteNonQuery();
                        ctr++;
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("INSERT INTO dpaket VALUES('" + idinput + "','" + dari+ "','" + tujuan+ "','" + jenis + "','" + namahotel + "','" + deskripsi+ "')", conn);
                        cmd.ExecuteNonQuery();

                        ctr++;

                    }

                }
            }
            else MessageBox.Show("Asal Dan Tujuan Harus terisi");
            dari = "-";
            tujuan = "-";
            jenis = "-";
            namahotel = "-";
            deskripsi = "-";
            loadDgv();
            txt_dari.Text = "";
            txt_tujuan.Text = "";
            cmb_jenis.SelectedIndex = -1;
            txt_catat.Text = "";
        }

        void loadDgv()
        {
            OracleCommand query = new OracleCommand("SELECT ddari as Dari,ddtujuan as Tujuan,dkendaraan as Kendaraan,dhotel_nama as Hotel,tour_deskripsi as Deskripsi" +
                "                                   FROM dpaket " +
                "                                   where tour_id= '" + idinput + "' ", conn);
            da= new OracleDataAdapter(query);
            ds= new DataSet();
            conn.Close();
            da.Fill(ds, "dpaket");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "dpaket";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nud_lama.Value)>0 && txt_nPaket.Text!="")
            {
                txt_nPaket.Enabled = false;
                nud_lama.Enabled = false;
                total = Convert.ToInt32(nud_lama.Value);
                if (txt_nPaket.Text == "" && total < 1) { MessageBox.Show("Data Tidak Tepat / Kosong"); }
                else gb_detail.Visible = true;
                lbl_hari.Text = ctr.ToString();
            }else MessageBox.Show("Harus Lebih Dari 1 Lama Tour dan Nama Tidak Boleh Kosong");

        }
    }
}
