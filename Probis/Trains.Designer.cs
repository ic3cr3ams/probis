namespace Probis
{
    partial class Trains
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trains));
            this.btn_register = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_tanggal = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_ke = new Bunifu.Framework.UI.BunifuDropdown();
            this.dd_dari = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.ActiveBorderThickness = 1;
            this.btn_register.ActiveCornerRadius = 20;
            this.btn_register.ActiveFillColor = System.Drawing.Color.ForestGreen;
            this.btn_register.ActiveForecolor = System.Drawing.Color.White;
            this.btn_register.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_register.BackColor = System.Drawing.SystemColors.Control;
            this.btn_register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_register.BackgroundImage")));
            this.btn_register.ButtonText = "Search";
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.Black;
            this.btn_register.IdleBorderThickness = 1;
            this.btn_register.IdleCornerRadius = 20;
            this.btn_register.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.btn_register.IdleForecolor = System.Drawing.Color.Green;
            this.btn_register.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_register.Location = new System.Drawing.Point(720, 75);
            this.btn_register.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(122, 51);
            this.btn_register.TabIndex = 22;
            this.btn_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 55);
            this.label1.TabIndex = 21;
            this.label1.Text = "List Trains\r\n";
            // 
            // dtp_tanggal
            // 
            this.dtp_tanggal.BackColor = System.Drawing.Color.SteelBlue;
            this.dtp_tanggal.BorderRadius = 0;
            this.dtp_tanggal.ForeColor = System.Drawing.Color.White;
            this.dtp_tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_tanggal.FormatCustom = null;
            this.dtp_tanggal.Location = new System.Drawing.Point(526, 77);
            this.dtp_tanggal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_tanggal.Name = "dtp_tanggal";
            this.dtp_tanggal.Size = new System.Drawing.Size(184, 31);
            this.dtp_tanggal.TabIndex = 20;
            this.dtp_tanggal.Value = new System.DateTime(2020, 9, 4, 18, 49, 49, 637);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Square721 Cn BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(438, 76);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(81, 29);
            this.bunifuCustomLabel3.TabIndex = 19;
            this.bunifuCustomLabel3.Text = "Date  : ";
            // 
            // dd_ke
            // 
            this.dd_ke.BackColor = System.Drawing.Color.Transparent;
            this.dd_ke.BorderRadius = 3;
            this.dd_ke.ForeColor = System.Drawing.Color.White;
            this.dd_ke.Items = new string[0];
            this.dd_ke.Location = new System.Drawing.Point(294, 77);
            this.dd_ke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dd_ke.Name = "dd_ke";
            this.dd_ke.NomalColor = System.Drawing.Color.SteelBlue;
            this.dd_ke.onHoverColor = System.Drawing.Color.PaleTurquoise;
            this.dd_ke.selectedIndex = -1;
            this.dd_ke.Size = new System.Drawing.Size(131, 28);
            this.dd_ke.TabIndex = 18;
            // 
            // dd_dari
            // 
            this.dd_dari.BackColor = System.Drawing.Color.Transparent;
            this.dd_dari.BorderRadius = 3;
            this.dd_dari.ForeColor = System.Drawing.Color.White;
            this.dd_dari.Items = new string[0];
            this.dd_dari.Location = new System.Drawing.Point(94, 77);
            this.dd_dari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dd_dari.Name = "dd_dari";
            this.dd_dari.NomalColor = System.Drawing.Color.SteelBlue;
            this.dd_dari.onHoverColor = System.Drawing.Color.PaleTurquoise;
            this.dd_dari.selectedIndex = -1;
            this.dd_dari.Size = new System.Drawing.Size(131, 28);
            this.dd_dari.TabIndex = 17;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Square721 Cn BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(244, 76);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(59, 29);
            this.bunifuCustomLabel2.TabIndex = 16;
            this.bunifuCustomLabel2.Text = "To  : ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Square721 Cn BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 75);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(84, 29);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "From  : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Harga,
            this.Order});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(19, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(811, 542);
            this.dataGridView1.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode Kereta";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kereta";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jam ";
            this.Column3.Name = "Column3";
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.Name = "Order";
            // 
            // Trains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 699);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_tanggal);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.dd_ke);
            this.Controls.Add(this.dd_dari);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Trains";
            this.Text = "Trains";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_register;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker dtp_tanggal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown dd_ke;
        private Bunifu.Framework.UI.BunifuDropdown dd_dari;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewButtonColumn Order;
    }
}