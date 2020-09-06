namespace Probis
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_flight = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_trains = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_hotel = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_travel = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 153);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.MidnightBlue;
            this.bunifuCards1.Controls.Add(this.btn_Logout);
            this.bunifuCards1.Controls.Add(this.btn_travel);
            this.bunifuCards1.Controls.Add(this.btn_hotel);
            this.bunifuCards1.Controls.Add(this.btn_trains);
            this.bunifuCards1.Controls.Add(this.btn_flight);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(2, 2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(473, 575);
            this.bunifuCards1.TabIndex = 1;
            // 
            // btn_flight
            // 
            this.btn_flight.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_flight.color = System.Drawing.Color.SkyBlue;
            this.btn_flight.colorActive = System.Drawing.Color.DodgerBlue;
            this.btn_flight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_flight.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_flight.ForeColor = System.Drawing.Color.White;
            this.btn_flight.Image = ((System.Drawing.Image)(resources.GetObject("btn_flight.Image")));
            this.btn_flight.ImagePosition = 20;
            this.btn_flight.ImageZoom = 50;
            this.btn_flight.LabelPosition = 45;
            this.btn_flight.LabelText = "Flight";
            this.btn_flight.Location = new System.Drawing.Point(62, 233);
            this.btn_flight.Margin = new System.Windows.Forms.Padding(6);
            this.btn_flight.Name = "btn_flight";
            this.btn_flight.Size = new System.Drawing.Size(128, 129);
            this.btn_flight.TabIndex = 1;
            // 
            // btn_trains
            // 
            this.btn_trains.BackColor = System.Drawing.Color.Gold;
            this.btn_trains.color = System.Drawing.Color.Gold;
            this.btn_trains.colorActive = System.Drawing.Color.Khaki;
            this.btn_trains.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_trains.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_trains.ForeColor = System.Drawing.Color.White;
            this.btn_trains.Image = ((System.Drawing.Image)(resources.GetObject("btn_trains.Image")));
            this.btn_trains.ImagePosition = 20;
            this.btn_trains.ImageZoom = 50;
            this.btn_trains.LabelPosition = 45;
            this.btn_trains.LabelText = "Trains";
            this.btn_trains.Location = new System.Drawing.Point(287, 233);
            this.btn_trains.Margin = new System.Windows.Forms.Padding(6);
            this.btn_trains.Name = "btn_trains";
            this.btn_trains.Size = new System.Drawing.Size(128, 129);
            this.btn_trains.TabIndex = 2;
            // 
            // btn_hotel
            // 
            this.btn_hotel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_hotel.color = System.Drawing.Color.DodgerBlue;
            this.btn_hotel.colorActive = System.Drawing.Color.SkyBlue;
            this.btn_hotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hotel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_hotel.ForeColor = System.Drawing.Color.White;
            this.btn_hotel.Image = ((System.Drawing.Image)(resources.GetObject("btn_hotel.Image")));
            this.btn_hotel.ImagePosition = 20;
            this.btn_hotel.ImageZoom = 55;
            this.btn_hotel.LabelPosition = 45;
            this.btn_hotel.LabelText = "Hotel";
            this.btn_hotel.Location = new System.Drawing.Point(62, 390);
            this.btn_hotel.Margin = new System.Windows.Forms.Padding(6);
            this.btn_hotel.Name = "btn_hotel";
            this.btn_hotel.Size = new System.Drawing.Size(128, 129);
            this.btn_hotel.TabIndex = 3;
            // 
            // btn_travel
            // 
            this.btn_travel.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_travel.color = System.Drawing.Color.SeaGreen;
            this.btn_travel.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_travel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_travel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_travel.ForeColor = System.Drawing.Color.White;
            this.btn_travel.Image = ((System.Drawing.Image)(resources.GetObject("btn_travel.Image")));
            this.btn_travel.ImagePosition = 20;
            this.btn_travel.ImageZoom = 55;
            this.btn_travel.LabelPosition = 45;
            this.btn_travel.LabelText = "Tour";
            this.btn_travel.Location = new System.Drawing.Point(287, 390);
            this.btn_travel.Margin = new System.Windows.Forms.Padding(6);
            this.btn_travel.Name = "btn_travel";
            this.btn_travel.Size = new System.Drawing.Size(128, 129);
            this.btn_travel.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.ActiveBorderThickness = 1;
            this.btn_Logout.ActiveCornerRadius = 20;
            this.btn_Logout.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Logout.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Logout.ActiveLineColor = System.Drawing.Color.DarkBlue;
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
            this.btn_Logout.Location = new System.Drawing.Point(12, 10);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(98, 40);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 580);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuTileButton btn_travel;
        private Bunifu.Framework.UI.BunifuTileButton btn_hotel;
        private Bunifu.Framework.UI.BunifuTileButton btn_trains;
        private Bunifu.Framework.UI.BunifuTileButton btn_flight;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Logout;
    }
}