namespace Probis
{
    partial class ListTour
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
            this.cb_paket = new System.Windows.Forms.ComboBox();
            this.dgv_listPaket = new System.Windows.Forms.DataGridView();
            this.btn_tambahPaket = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listPaket)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_paket
            // 
            this.cb_paket.FormattingEnabled = true;
            this.cb_paket.Location = new System.Drawing.Point(13, 13);
            this.cb_paket.Name = "cb_paket";
            this.cb_paket.Size = new System.Drawing.Size(273, 21);
            this.cb_paket.TabIndex = 0;
            this.cb_paket.SelectedIndexChanged += new System.EventHandler(this.cb_paket_SelectedIndexChanged);
            // 
            // dgv_listPaket
            // 
            this.dgv_listPaket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listPaket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listPaket.Location = new System.Drawing.Point(13, 41);
            this.dgv_listPaket.Name = "dgv_listPaket";
            this.dgv_listPaket.Size = new System.Drawing.Size(775, 397);
            this.dgv_listPaket.TabIndex = 1;
            // 
            // btn_tambahPaket
            // 
            this.btn_tambahPaket.Location = new System.Drawing.Point(713, 11);
            this.btn_tambahPaket.Name = "btn_tambahPaket";
            this.btn_tambahPaket.Size = new System.Drawing.Size(75, 23);
            this.btn_tambahPaket.TabIndex = 2;
            this.btn_tambahPaket.Text = "Tambah Paket";
            this.btn_tambahPaket.UseVisualStyleBackColor = true;
            this.btn_tambahPaket.Click += new System.EventHandler(this.btn_tambahPaket_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(304, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            // 
            // ListTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_tambahPaket);
            this.Controls.Add(this.dgv_listPaket);
            this.Controls.Add(this.cb_paket);
            this.Name = "ListTour";
            this.Text = "ListTour";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listPaket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_paket;
        private System.Windows.Forms.DataGridView dgv_listPaket;
        private System.Windows.Forms.Button btn_tambahPaket;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}