namespace Probis
{
    partial class HomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_flight = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_hotel = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_train = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_tour = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_laporan = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.MidnightBlue;
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.bunifuTileButton1);
            this.bunifuCards1.Controls.Add(this.btn_laporan);
            this.bunifuCards1.Controls.Add(this.btn_tour);
            this.bunifuCards1.Controls.Add(this.btn_train);
            this.bunifuCards1.Controls.Add(this.btn_hotel);
            this.bunifuCards1.Controls.Add(this.btn_flight);
            this.bunifuCards1.Controls.Add(this.btn_Logout);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-2, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(547, 696);
            this.bunifuCards1.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.ActiveBorderThickness = 1;
            this.btn_Logout.ActiveCornerRadius = 20;
            this.btn_Logout.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Logout.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Logout.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Logout.BackgroundImage")));
            this.btn_Logout.ButtonText = "LogOut";
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.IdleBorderThickness = 1;
            this.btn_Logout.IdleCornerRadius = 20;
            this.btn_Logout.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_Logout.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Logout.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(16, 12);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(98, 40);
            this.btn_Logout.TabIndex = 15;
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 153);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_flight
            // 
            this.btn_flight.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_flight.color = System.Drawing.Color.LightSkyBlue;
            this.btn_flight.colorActive = System.Drawing.Color.SkyBlue;
            this.btn_flight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_flight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flight.ForeColor = System.Drawing.Color.White;
            this.btn_flight.Image = ((System.Drawing.Image)(resources.GetObject("btn_flight.Image")));
            this.btn_flight.ImagePosition = 15;
            this.btn_flight.ImageZoom = 50;
            this.btn_flight.LabelPosition = 32;
            this.btn_flight.LabelText = "List Flight";
            this.btn_flight.Location = new System.Drawing.Point(77, 404);
            this.btn_flight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_flight.Name = "btn_flight";
            this.btn_flight.Size = new System.Drawing.Size(126, 110);
            this.btn_flight.TabIndex = 16;
            // 
            // btn_hotel
            // 
            this.btn_hotel.BackColor = System.Drawing.Color.LightGreen;
            this.btn_hotel.color = System.Drawing.Color.LightGreen;
            this.btn_hotel.colorActive = System.Drawing.Color.DarkSeaGreen;
            this.btn_hotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hotel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hotel.ForeColor = System.Drawing.Color.White;
            this.btn_hotel.Image = ((System.Drawing.Image)(resources.GetObject("btn_hotel.Image")));
            this.btn_hotel.ImagePosition = 15;
            this.btn_hotel.ImageZoom = 50;
            this.btn_hotel.LabelPosition = 32;
            this.btn_hotel.LabelText = "List Hotel";
            this.btn_hotel.Location = new System.Drawing.Point(322, 241);
            this.btn_hotel.Margin = new System.Windows.Forms.Padding(6);
            this.btn_hotel.Name = "btn_hotel";
            this.btn_hotel.Size = new System.Drawing.Size(126, 110);
            this.btn_hotel.TabIndex = 17;
            // 
            // btn_train
            // 
            this.btn_train.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_train.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_train.colorActive = System.Drawing.Color.Yellow;
            this.btn_train.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_train.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_train.ForeColor = System.Drawing.Color.White;
            this.btn_train.Image = ((System.Drawing.Image)(resources.GetObject("btn_train.Image")));
            this.btn_train.ImagePosition = 15;
            this.btn_train.ImageZoom = 50;
            this.btn_train.LabelPosition = 32;
            this.btn_train.LabelText = "List Train";
            this.btn_train.Location = new System.Drawing.Point(320, 401);
            this.btn_train.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_train.Name = "btn_train";
            this.btn_train.Size = new System.Drawing.Size(126, 113);
            this.btn_train.TabIndex = 18;
            // 
            // btn_tour
            // 
            this.btn_tour.BackColor = System.Drawing.Color.LightCoral;
            this.btn_tour.color = System.Drawing.Color.LightCoral;
            this.btn_tour.colorActive = System.Drawing.Color.Pink;
            this.btn_tour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tour.ForeColor = System.Drawing.Color.White;
            this.btn_tour.Image = ((System.Drawing.Image)(resources.GetObject("btn_tour.Image")));
            this.btn_tour.ImagePosition = 15;
            this.btn_tour.ImageZoom = 50;
            this.btn_tour.LabelPosition = 32;
            this.btn_tour.LabelText = "List Tour";
            this.btn_tour.Location = new System.Drawing.Point(77, 563);
            this.btn_tour.Margin = new System.Windows.Forms.Padding(5);
            this.btn_tour.Name = "btn_tour";
            this.btn_tour.Size = new System.Drawing.Size(126, 113);
            this.btn_tour.TabIndex = 19;
            // 
            // btn_laporan
            // 
            this.btn_laporan.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_laporan.color = System.Drawing.Color.SandyBrown;
            this.btn_laporan.colorActive = System.Drawing.Color.Orange;
            this.btn_laporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_laporan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laporan.ForeColor = System.Drawing.Color.White;
            this.btn_laporan.Image = ((System.Drawing.Image)(resources.GetObject("btn_laporan.Image")));
            this.btn_laporan.ImagePosition = 12;
            this.btn_laporan.ImageZoom = 50;
            this.btn_laporan.LabelPosition = 32;
            this.btn_laporan.LabelText = "Laporan";
            this.btn_laporan.Location = new System.Drawing.Point(322, 563);
            this.btn_laporan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Size = new System.Drawing.Size(124, 113);
            this.btn_laporan.TabIndex = 20;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 15;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 32;
            this.bunifuTileButton1.LabelText = "User";
            this.bunifuTileButton1.Location = new System.Drawing.Point(77, 241);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(126, 110);
            this.bunifuTileButton1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "ini yang laporan dimunculin klo pas yang login  manager aja";
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 690);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "HomeAdmin";
            this.Text = "HomeAdmin";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuTileButton btn_laporan;
        private Bunifu.Framework.UI.BunifuTileButton btn_tour;
        private Bunifu.Framework.UI.BunifuTileButton btn_train;
        private Bunifu.Framework.UI.BunifuTileButton btn_hotel;
        private Bunifu.Framework.UI.BunifuTileButton btn_flight;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.Label label1;
    }
}