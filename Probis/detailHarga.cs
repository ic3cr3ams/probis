using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probis
{
    public partial class detailHarga : Form
    {
        public detailHarga()
        {
            InitializeComponent();
        }

        private void detailHarga_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesan_Click(object sender, EventArgs e)
        {
            Booking_Flight b = new Booking_Flight();
            this.Hide();
            b.ShowDialog();
            this.Show();
        }
    }
}
