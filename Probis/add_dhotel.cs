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
    public partial class add_dhotel : Form
    {
        public add_dhotel()
        {
            InitializeComponent();
        }
        public string idhotel;
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds;
        string kapasitas = "";

        private void txtharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) 
            {
                if (comboBox1.SelectedIndex == 0) { txtkapasitas.Text = "1 Orang";kapasitas = "1"; }
                else { txtkapasitas.Text = "2 Orang"; kapasitas = "2"; }
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            bool cekinput = true;
            if (comboBox1.SelectedIndex == -1) 
            {
                cekinput = false;
                MessageBox.Show("Harap Pilih Jenis Kamar terlebih dahulu");
            }
            if (txtharga.Text == "") {
                cekinput = false;
                MessageBox.Show("Harap Isi Field Harga Terlebih dahulu");
            }
            if (cekinput) 
            {
                conn.Close();
                conn.Open();
                OracleCommand cmd;
                if (rbyes.Checked) {
                     cmd = new OracleCommand("INSERT INTO DHOTEL VALUES('" + idhotel + "'," + kapasitas + ",'" + comboBox1.SelectedItem.ToString() + "',"+ txtharga.Text+",1,'"+txtketerangan.Text+"')",conn);
                        }
                else {
                     cmd = new OracleCommand("INSERT INTO DHOTEL VALUES('" + idhotel + "'," + kapasitas + ",'" + comboBox1.SelectedItem.ToString() + "',"+ txtharga.Text+",0,'" + txtketerangan.Text + "')", conn);
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Detail Hotel !");
                this.Close();
                conn.Close();
                
                
            }

        }

        private void add_dhotel_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            da = new OracleDataAdapter("Select HOTEL_NAME,HOTEL_ID from hotel",conn);
            ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows) {
                if (row["HOTEL_ID"].ToString() == idhotel) txtnamahotel.Text = row["HOTEL_NAME"].ToString();
            }
            conn.Close();
        }
    }
}
