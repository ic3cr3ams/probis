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
    public partial class lihatPaket : Form
    {
        public lihatPaket()
        {
            InitializeComponent();
        }

        private void btn_detailHarga_Click(object sender, EventArgs e)
        {
            detailHarga d = new detailHarga();
            this.Hide();
            d.ShowDialog();
            this.Show();
        }
    }
}
