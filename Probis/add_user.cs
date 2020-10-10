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
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }
        OracleConnection conn = form_login.conn;
        OracleDataAdapter adapter;
        DataSet ds=new DataSet();
        private void add_user_Load(object sender, EventArgs e)
        {
            cbjabatan.SelectedIndex = 0;
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (txtnama.Text != "" && txtusername.Text != "" && txtpass.Text != "" && txtconpass.Text!="" && txtalamat.Text != "" && txtemail.Text != "" && txtnohp.Text != "" && cbjabatan.SelectedIndex != -1) {
                if (txtpass.Text != txtconpass.Text) 
                {
                    MessageBox.Show("Password dan Confirm Password tidak sama ! ");
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    adapter = new OracleDataAdapter("Select Pegawai_ID as id,Pegawai_username as username from pegawai", conn);
                    adapter.Fill(ds);
                    string lastid = "";
                    bool cekuser = true;
                    if (ds.Tables.Count != 0) {
                        foreach (DataTable dt in ds.Tables)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                lastid = row["id"].ToString();
                                if (row["username"].ToString() == txtusername.Text)cekuser=false ;
                            }
                        }
                    }
                    else { lastid = "KA0000"; }
                    if (cekuser) {
                        int lastidangka = int.Parse(lastid.Substring(2, 4));
                        int idangka = lastidangka + 1;
                        string idinput = "KA";
                        if (idangka < 10) idinput += "000" + idangka;
                        else if (idangka >= 10 && idangka < 100) idinput += "00" + idangka;
                        else if (idangka >= 100 && idangka < 1000) idinput += "0" + idangka;
                        else if (idangka >= 1000 && idangka < 10000) idinput += idangka;
                        string nama = txtnama.Text;
                        string pass = txtpass.Text;
                        string username = txtusername.Text;
                        string email = txtemail.Text;
                        string nohp = txtnohp.Text;
                        string jabatan = cbjabatan.SelectedItem.ToString();
                        string alamat = txtalamat.Text;
                        OracleCommand cmd = new OracleCommand("INSERT INTO PEGAWAI VALUES('" + idinput + "','" + nama + "','" + username + "','" + pass + "','" + email + "','" + alamat + "','1','" + jabatan + "','" + nohp + "') ", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sukses Tambah Pegawai !");
                        txtnama.ResetText();
                        txtusername.ResetText();
                        txtpass.ResetText();
                        txtconpass.ResetText();
                        txtemail.ResetText();
                        txtnohp.ResetText();
                        cbjabatan.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Username Sudah Digunakan");
                    }
                    conn.Close();
                }
                
            }
            else MessageBox.Show("Semua Field Harus Diisi !");
        }

        private void txtnohp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
