﻿namespace Probis
{
    partial class addHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addHotel));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_kota = new System.Windows.Forms.TextBox();
            this.txt_negara = new System.Windows.Forms.TextBox();
            this.btn_tambah = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_batal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Hotel\r\n";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(155, 70);
            this.txt_nama.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(151, 20);
            this.txt_nama.TabIndex = 42;
            // 
            // txt_kota
            // 
            this.txt_kota.Location = new System.Drawing.Point(155, 103);
            this.txt_kota.Margin = new System.Windows.Forms.Padding(2);
            this.txt_kota.Name = "txt_kota";
            this.txt_kota.Size = new System.Drawing.Size(151, 20);
            this.txt_kota.TabIndex = 44;
            // 
            // txt_negara
            // 
            this.txt_negara.Location = new System.Drawing.Point(155, 131);
            this.txt_negara.Margin = new System.Windows.Forms.Padding(2);
            this.txt_negara.Name = "txt_negara";
            this.txt_negara.Size = new System.Drawing.Size(151, 20);
            this.txt_negara.TabIndex = 46;
            // 
            // btn_tambah
            // 
            this.btn_tambah.ActiveBorderThickness = 1;
            this.btn_tambah.ActiveCornerRadius = 20;
            this.btn_tambah.ActiveFillColor = System.Drawing.Color.ForestGreen;
            this.btn_tambah.ActiveForecolor = System.Drawing.Color.White;
            this.btn_tambah.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_tambah.BackColor = System.Drawing.SystemColors.Control;
            this.btn_tambah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tambah.BackgroundImage")));
            this.btn_tambah.ButtonText = "Tambah";
            this.btn_tambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.ForeColor = System.Drawing.Color.Black;
            this.btn_tambah.IdleBorderThickness = 1;
            this.btn_tambah.IdleCornerRadius = 20;
            this.btn_tambah.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.btn_tambah.IdleForecolor = System.Drawing.Color.White;
            this.btn_tambah.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_tambah.Location = new System.Drawing.Point(284, 176);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(86, 44);
            this.btn_tambah.TabIndex = 53;
            this.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.ActiveBorderThickness = 1;
            this.btn_batal.ActiveCornerRadius = 20;
            this.btn_batal.ActiveFillColor = System.Drawing.Color.ForestGreen;
            this.btn_batal.ActiveForecolor = System.Drawing.Color.White;
            this.btn_batal.ActiveLineColor = System.Drawing.Color.Pink;
            this.btn_batal.BackColor = System.Drawing.SystemColors.Control;
            this.btn_batal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_batal.BackgroundImage")));
            this.btn_batal.ButtonText = "Batal";
            this.btn_batal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_batal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batal.ForeColor = System.Drawing.Color.Black;
            this.btn_batal.IdleBorderThickness = 1;
            this.btn_batal.IdleCornerRadius = 20;
            this.btn_batal.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_batal.IdleForecolor = System.Drawing.Color.White;
            this.btn_batal.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_batal.Location = new System.Drawing.Point(27, 176);
            this.btn_batal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(82, 44);
            this.btn_batal.TabIndex = 54;
            this.btn_batal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 70);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(123, 20);
            this.bunifuCustomLabel1.TabIndex = 60;
            this.bunifuCustomLabel1.Text = "Nama Hotel  : ";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(76, 101);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(66, 20);
            this.bunifuCustomLabel5.TabIndex = 61;
            this.bunifuCustomLabel5.Text = "Kota  : ";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(55, 129);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 20);
            this.bunifuCustomLabel3.TabIndex = 62;
            this.bunifuCustomLabel3.Text = "Negara  : ";
            // 
            // addHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 232);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.txt_negara);
            this.Controls.Add(this.txt_kota);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addHotel";
            this.Text = "addHotel";
            this.Load += new System.EventHandler(this.addHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_kota;
        private System.Windows.Forms.TextBox txt_negara;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_tambah;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_batal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}