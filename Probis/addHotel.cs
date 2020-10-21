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
    public partial class addHotel : Form
    {
        public addHotel()
        {
            InitializeComponent();
        }
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();


        private void addHotel_Load(object sender, EventArgs e)
        {

        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (txt_nama.Text == "" || txt_kota.Text == "" || txt_negara.Text == "") { MessageBox.Show("Data Tidak Lengkap ! "); }
            else {
                conn.Close();
                conn.Open();
                da = new OracleDataAdapter("Select hotel_id as id from hotel", conn);
                string lastid = "";
                da.Fill(ds);
                if (ds.Tables.Count != 0)
                {
                    foreach (DataTable dt in ds.Tables)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            lastid = row["id"].ToString();
                        }
                    }
                }
                int lastidangka = int.Parse(lastid.Substring(2, 4));
                int idangka = lastidangka + 1;
                string idinput = "HT";
                if (idangka < 10) idinput += "000" + idangka;
                else if (idangka >= 10 && idangka < 100) idinput += "00" + idangka;
                else if (idangka >= 100 && idangka < 1000) idinput += "0" + idangka;
                else if (idangka >= 1000 && idangka < 10000) idinput += idangka;

                string nama = txt_nama.Text;
                string kota = txt_kota.Text;
                string negara = txt_negara.Text;           
                OracleCommand cmd = new OracleCommand("INSERT INTO HOTEL VALUES('"+idinput+"','"+nama+"',upper('"+kota+"'),upper('"+negara+"'))", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sukes Input Data Hotel");
                txt_nama.Text = "";
                txt_kota.Text = "";
                txt_negara.Text = "";
                conn.Close();
                this.Close();
            }
        }

        private void txt_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
