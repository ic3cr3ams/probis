namespace Probis
{
    partial class masterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masterUser));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgv_listUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_baru = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_hapus = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 55);
            this.label1.TabIndex = 61;
            this.label1.Text = "User";
            // 
            // btn_Back
            // 
            this.btn_Back.ActiveBorderThickness = 1;
            this.btn_Back.ActiveCornerRadius = 20;
            this.btn_Back.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Back.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Back.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.ButtonText = "Back";
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.IdleBorderThickness = 1;
            this.btn_Back.IdleCornerRadius = 20;
            this.btn_Back.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_Back.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Back.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Back.Location = new System.Drawing.Point(563, 12);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(98, 40);
            this.btn_Back.TabIndex = 62;
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_listUser
            // 
            this.dgv_listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_listUser.Location = new System.Drawing.Point(12, 106);
            this.dgv_listUser.Name = "dgv_listUser";
            this.dgv_listUser.RowTemplate.Height = 28;
            this.dgv_listUser.Size = new System.Drawing.Size(649, 427);
            this.dgv_listUser.TabIndex = 63;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nama";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jabatan";
            this.Column3.Name = "Column3";
            // 
            // btn_baru
            // 
            this.btn_baru.ActiveBorderThickness = 1;
            this.btn_baru.ActiveCornerRadius = 20;
            this.btn_baru.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btn_baru.ActiveForecolor = System.Drawing.Color.White;
            this.btn_baru.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_baru.BackColor = System.Drawing.SystemColors.Control;
            this.btn_baru.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_baru.BackgroundImage")));
            this.btn_baru.ButtonText = "Tambah Baru";
            this.btn_baru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_baru.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baru.ForeColor = System.Drawing.Color.Black;
            this.btn_baru.IdleBorderThickness = 1;
            this.btn_baru.IdleCornerRadius = 20;
            this.btn_baru.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_baru.IdleForecolor = System.Drawing.Color.DarkBlue;
            this.btn_baru.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_baru.Location = new System.Drawing.Point(15, 561);
            this.btn_baru.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_baru.Name = "btn_baru";
            this.btn_baru.Size = new System.Drawing.Size(184, 51);
            this.btn_baru.TabIndex = 71;
            this.btn_baru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_hapus
            // 
            this.btn_hapus.ActiveBorderThickness = 1;
            this.btn_hapus.ActiveCornerRadius = 20;
            this.btn_hapus.ActiveFillColor = System.Drawing.Color.LightCoral;
            this.btn_hapus.ActiveForecolor = System.Drawing.Color.White;
            this.btn_hapus.ActiveLineColor = System.Drawing.Color.Pink;
            this.btn_hapus.BackColor = System.Drawing.SystemColors.Control;
            this.btn_hapus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hapus.BackgroundImage")));
            this.btn_hapus.ButtonText = "Hapus";
            this.btn_hapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hapus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.Color.Black;
            this.btn_hapus.IdleBorderThickness = 1;
            this.btn_hapus.IdleCornerRadius = 20;
            this.btn_hapus.IdleFillColor = System.Drawing.Color.LightPink;
            this.btn_hapus.IdleForecolor = System.Drawing.Color.Crimson;
            this.btn_hapus.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_hapus.Location = new System.Drawing.Point(539, 561);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(122, 51);
            this.btn_hapus.TabIndex = 72;
            this.btn_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // masterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 634);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_baru);
            this.Controls.Add(this.dgv_listUser);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Name = "masterUser";
            this.Text = "masterUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Back;
        private System.Windows.Forms.DataGridView dgv_listUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_baru;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_hapus;
    }
}