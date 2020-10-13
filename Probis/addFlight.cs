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
    public partial class addFlight : Form
    {
        public addFlight()
        {
            InitializeComponent();
        }
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void addFlight_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            dtJam.CustomFormat = "HH:mm";
            da = new OracleDataAdapter("Select * from maskapai", conn);
            da.Fill(ds);
            cbmaskapai.DataSource = ds.Tables[0];
            cbmaskapai.ValueMember = "MASKAPAI_ID";
            cbmaskapai.DisplayMember = "MASKAPAI_NAMA";
            conn.Close();


        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {

            if (cbmaskapai.SelectedIndex == -1 || txt_dari.Text == "" || txt_tujuan.Text == "" || txt_harga.Text == "") { MessageBox.Show("Data Tidak Lengkap!"); }
            else {

                conn.Close();                
                conn.Open();
                da = new OracleDataAdapter("Select Flight_id as id from flight", conn);
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
                string idinput = "FL";
                if (idangka < 10) idinput += "000" + idangka;
                else if (idangka >= 10 && idangka < 100) idinput += "00" + idangka;
                else if (idangka >= 100 && idangka < 1000) idinput += "0" + idangka;
                else if (idangka >= 1000 && idangka < 10000) idinput += idangka;
                string id_maskapai = cbmaskapai.SelectedValue.ToString() ;
                string dari = txt_dari.Text;
                string tujuan = txt_tujuan.Text;
                int harga = Convert.ToInt32(txt_harga.Text);
                string tanggal = dtTanggal.Value.ToString("dd-MM-yyyy");
                string jam = dtJam.Value.ToString("HH:mm");
                OracleCommand cmd = new OracleCommand("INSERT INTO FLIGHT VALUES(upper('"+idinput+"'),upper('"+id_maskapai+"'),upper('" + dari + "'),upper('" + tujuan + "'),TO_DATE('"+tanggal+" "+jam+"','DD-MM-YYYY HH24:MI'),"+harga+")", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sukes Input Data Flight");
                txt_dari.Text = "";
                txt_tujuan.Text = "";
                cbmaskapai.SelectedIndex = 0;
                txt_harga.Text = "";
                conn.Close();
            }
        }

        private void txt_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
