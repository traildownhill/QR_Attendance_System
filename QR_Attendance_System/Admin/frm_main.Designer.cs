namespace QR_Attendance_System
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.sidebar = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Panel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnlogout = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnsettings = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnattendance = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnhome = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_loggedtype = new System.Windows.Forms.Label();
            this.lbl_loggedname = new System.Windows.Forms.Label();
            this.mainDash = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.mainDash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DarkRed;
            this.sidebar.Controls.Add(this.settings);
            this.sidebar.Controls.Add(this.btnlogout);
            this.sidebar.Controls.Add(this.btnsettings);
            this.sidebar.Controls.Add(this.btnattendance);
            this.sidebar.Controls.Add(this.btnhome);
            this.sidebar.Controls.Add(this.bunifuPictureBox1);
            this.sidebar.Controls.Add(this.lbl_loggedtype);
            this.sidebar.Controls.Add(this.lbl_loggedname);
            this.sidebar.Location = new System.Drawing.Point(0, 61);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(252, 620);
            this.sidebar.TabIndex = 1;
            // 
            // settings
            // 
            this.settings.Controls.Add(this.bunifuTileButton1);
            this.settings.Controls.Add(this.bunifuTileButton3);
            this.settings.Controls.Add(this.bunifuTileButton2);
            this.settings.Location = new System.Drawing.Point(0, 366);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(252, 124);
            this.settings.TabIndex = 4;
            this.settings.Visible = false;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Red;
            this.bunifuTileButton1.color = System.Drawing.Color.Red;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Red;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = null;
            this.bunifuTileButton1.ImagePosition = 1;
            this.bunifuTileButton1.ImageZoom = 15;
            this.bunifuTileButton1.LabelPosition = 30;
            this.bunifuTileButton1.LabelText = "Add Employee";
            this.bunifuTileButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(252, 36);
            this.bunifuTileButton1.TabIndex = 6;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click_1);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.Red;
            this.bunifuTileButton3.color = System.Drawing.Color.Red;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.Red;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = null;
            this.bunifuTileButton3.ImagePosition = 1;
            this.bunifuTileButton3.ImageZoom = 15;
            this.bunifuTileButton3.LabelPosition = 30;
            this.bunifuTileButton3.LabelText = "Change Head";
            this.bunifuTileButton3.Location = new System.Drawing.Point(0, 83);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(252, 36);
            this.bunifuTileButton3.TabIndex = 5;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click_1);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Red;
            this.bunifuTileButton2.color = System.Drawing.Color.Red;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.Red;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = null;
            this.bunifuTileButton2.ImagePosition = 1;
            this.bunifuTileButton2.ImageZoom = 15;
            this.bunifuTileButton2.LabelPosition = 30;
            this.bunifuTileButton2.LabelText = "Change Admin";
            this.bunifuTileButton2.Location = new System.Drawing.Point(0, 43);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(252, 36);
            this.bunifuTileButton2.TabIndex = 4;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnlogout.color = System.Drawing.Color.DarkRed;
            this.btnlogout.colorActive = System.Drawing.Color.Red;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Image = global::QR_Attendance_System.Properties.Resources.logout;
            this.btnlogout.ImagePosition = 1;
            this.btnlogout.ImageZoom = 15;
            this.btnlogout.LabelPosition = 30;
            this.btnlogout.LabelText = "SignOut";
            this.btnlogout.Location = new System.Drawing.Point(0, 551);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(6);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(252, 69);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.DarkRed;
            this.btnsettings.color = System.Drawing.Color.DarkRed;
            this.btnsettings.colorActive = System.Drawing.Color.Red;
            this.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsettings.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnsettings.ForeColor = System.Drawing.Color.White;
            this.btnsettings.Image = global::QR_Attendance_System.Properties.Resources.sttngs;
            this.btnsettings.ImagePosition = 1;
            this.btnsettings.ImageZoom = 15;
            this.btnsettings.LabelPosition = 30;
            this.btnsettings.LabelText = "Settings";
            this.btnsettings.Location = new System.Drawing.Point(0, 295);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(6);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(252, 62);
            this.btnsettings.TabIndex = 3;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnattendance
            // 
            this.btnattendance.BackColor = System.Drawing.Color.DarkRed;
            this.btnattendance.color = System.Drawing.Color.DarkRed;
            this.btnattendance.colorActive = System.Drawing.Color.Red;
            this.btnattendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnattendance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnattendance.ForeColor = System.Drawing.Color.White;
            this.btnattendance.Image = global::QR_Attendance_System.Properties.Resources.attndnc_1_;
            this.btnattendance.ImagePosition = 1;
            this.btnattendance.ImageZoom = 15;
            this.btnattendance.LabelPosition = 30;
            this.btnattendance.LabelText = "Attendance";
            this.btnattendance.Location = new System.Drawing.Point(0, 207);
            this.btnattendance.Margin = new System.Windows.Forms.Padding(6);
            this.btnattendance.Name = "btnattendance";
            this.btnattendance.Size = new System.Drawing.Size(252, 75);
            this.btnattendance.TabIndex = 3;
            this.btnattendance.Click += new System.EventHandler(this.btnattendance_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.DarkRed;
            this.btnhome.color = System.Drawing.Color.DarkRed;
            this.btnhome.colorActive = System.Drawing.Color.Red;
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Image = global::QR_Attendance_System.Properties.Resources.dshbrd;
            this.btnhome.ImagePosition = 1;
            this.btnhome.ImageZoom = 15;
            this.btnhome.LabelPosition = 30;
            this.btnhome.LabelText = "Dashboard";
            this.btnhome.Location = new System.Drawing.Point(-1, 120);
            this.btnhome.Margin = new System.Windows.Forms.Padding(6);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(252, 75);
            this.btnhome.TabIndex = 3;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lbl_loggedtype
            // 
            this.lbl_loggedtype.AutoSize = true;
            this.lbl_loggedtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loggedtype.ForeColor = System.Drawing.Color.White;
            this.lbl_loggedtype.Location = new System.Drawing.Point(102, 60);
            this.lbl_loggedtype.Name = "lbl_loggedtype";
            this.lbl_loggedtype.Size = new System.Drawing.Size(103, 20);
            this.lbl_loggedtype.TabIndex = 1;
            this.lbl_loggedtype.Text = "Administrator";
            // 
            // lbl_loggedname
            // 
            this.lbl_loggedname.AutoSize = true;
            this.lbl_loggedname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loggedname.ForeColor = System.Drawing.Color.White;
            this.lbl_loggedname.Location = new System.Drawing.Point(104, 18);
            this.lbl_loggedname.Name = "lbl_loggedname";
            this.lbl_loggedname.Size = new System.Drawing.Size(98, 20);
            this.lbl_loggedname.TabIndex = 1;
            this.lbl_loggedname.Text = "Maria Elador";
            // 
            // mainDash
            // 
            this.mainDash.BackColor = System.Drawing.Color.White;
            this.mainDash.Controls.Add(this.label2);
            this.mainDash.Controls.Add(this.label1);
            this.mainDash.Location = new System.Drawing.Point(254, 61);
            this.mainDash.Name = "mainDash";
            this.mainDash.Size = new System.Drawing.Size(1010, 620);
            this.mainDash.TabIndex = 2;
            this.mainDash.Paint += new System.Windows.Forms.PaintEventHandler(this.mainDash_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "QR-Based Operational Network \r\nDatabase of Attendance \r\nRecord Sytem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "QRONOS";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(863, 19);
            this.lbltime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(118, 19);
            this.lbltime.TabIndex = 24;
            this.lbltime.Text = "Date and Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QR_Attendance_System.Properties.Resources.BG2_1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1164, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.mainDash);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 720);
            this.MinimumSize = new System.Drawing.Size(1180, 720);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.mainDash.ResumeLayout(false);
            this.mainDash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label lbl_loggedtype;
        private System.Windows.Forms.Label lbl_loggedname;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton btnhome;
        private Bunifu.Framework.UI.BunifuTileButton btnattendance;
        private Bunifu.Framework.UI.BunifuTileButton btnsettings;
        private Bunifu.Framework.UI.BunifuTileButton btnlogout;
        private System.Windows.Forms.Panel mainDash;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel settings;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}