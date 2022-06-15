namespace QR_Attendance_System
{
    partial class frm_main1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main1));
            this.mainDash = new System.Windows.Forms.Panel();
            this.lbl_loggedtype = new System.Windows.Forms.Label();
            this.lbl_loggedname = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnlogout = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnmonthly = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnweekly = new Bunifu.Framework.UI.BunifuTileButton();
            this.btntoday = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainDash.SuspendLayout();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDash
            // 
            this.mainDash.BackColor = System.Drawing.Color.White;
            this.mainDash.Controls.Add(this.label2);
            this.mainDash.Controls.Add(this.label1);
            this.mainDash.Location = new System.Drawing.Point(254, 61);
            this.mainDash.Name = "mainDash";
            this.mainDash.Size = new System.Drawing.Size(810, 620);
            this.mainDash.TabIndex = 27;
            // 
            // lbl_loggedtype
            // 
            this.lbl_loggedtype.AutoSize = true;
            this.lbl_loggedtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loggedtype.ForeColor = System.Drawing.Color.White;
            this.lbl_loggedtype.Location = new System.Drawing.Point(109, 64);
            this.lbl_loggedtype.Name = "lbl_loggedtype";
            this.lbl_loggedtype.Size = new System.Drawing.Size(79, 20);
            this.lbl_loggedtype.TabIndex = 1;
            this.lbl_loggedtype.Text = "Employee";
            // 
            // lbl_loggedname
            // 
            this.lbl_loggedname.AutoSize = true;
            this.lbl_loggedname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loggedname.ForeColor = System.Drawing.Color.White;
            this.lbl_loggedname.Location = new System.Drawing.Point(109, 28);
            this.lbl_loggedname.Name = "lbl_loggedname";
            this.lbl_loggedname.Size = new System.Drawing.Size(73, 20);
            this.lbl_loggedname.TabIndex = 1;
            this.lbl_loggedname.Text = "Hyun Bin";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(742, 21);
            this.lbltime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(118, 19);
            this.lbltime.TabIndex = 28;
            this.lbltime.Text = "Date and Time";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DarkRed;
            this.sidebar.Controls.Add(this.btnlogout);
            this.sidebar.Controls.Add(this.btnmonthly);
            this.sidebar.Controls.Add(this.btnweekly);
            this.sidebar.Controls.Add(this.btntoday);
            this.sidebar.Controls.Add(this.bunifuPictureBox1);
            this.sidebar.Controls.Add(this.lbl_loggedtype);
            this.sidebar.Controls.Add(this.lbl_loggedname);
            this.sidebar.Location = new System.Drawing.Point(0, 61);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(252, 620);
            this.sidebar.TabIndex = 26;
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
            // btnmonthly
            // 
            this.btnmonthly.BackColor = System.Drawing.Color.DarkRed;
            this.btnmonthly.color = System.Drawing.Color.DarkRed;
            this.btnmonthly.colorActive = System.Drawing.Color.Red;
            this.btnmonthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmonthly.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnmonthly.ForeColor = System.Drawing.Color.White;
            this.btnmonthly.Image = global::QR_Attendance_System.Properties.Resources.attndnc_1_;
            this.btnmonthly.ImagePosition = 1;
            this.btnmonthly.ImageZoom = 15;
            this.btnmonthly.LabelPosition = 30;
            this.btnmonthly.LabelText = "Monthly";
            this.btnmonthly.Location = new System.Drawing.Point(0, 295);
            this.btnmonthly.Margin = new System.Windows.Forms.Padding(6);
            this.btnmonthly.Name = "btnmonthly";
            this.btnmonthly.Size = new System.Drawing.Size(252, 71);
            this.btnmonthly.TabIndex = 3;
            this.btnmonthly.Click += new System.EventHandler(this.btnmonthly_Click);
            // 
            // btnweekly
            // 
            this.btnweekly.BackColor = System.Drawing.Color.DarkRed;
            this.btnweekly.color = System.Drawing.Color.DarkRed;
            this.btnweekly.colorActive = System.Drawing.Color.Red;
            this.btnweekly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnweekly.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnweekly.ForeColor = System.Drawing.Color.White;
            this.btnweekly.Image = global::QR_Attendance_System.Properties.Resources.attndnc_1_;
            this.btnweekly.ImagePosition = 1;
            this.btnweekly.ImageZoom = 15;
            this.btnweekly.LabelPosition = 30;
            this.btnweekly.LabelText = "Weekly";
            this.btnweekly.Location = new System.Drawing.Point(0, 207);
            this.btnweekly.Margin = new System.Windows.Forms.Padding(6);
            this.btnweekly.Name = "btnweekly";
            this.btnweekly.Size = new System.Drawing.Size(252, 75);
            this.btnweekly.TabIndex = 3;
            this.btnweekly.Click += new System.EventHandler(this.btnweekly_Click);
            // 
            // btntoday
            // 
            this.btntoday.BackColor = System.Drawing.Color.DarkRed;
            this.btntoday.color = System.Drawing.Color.DarkRed;
            this.btntoday.colorActive = System.Drawing.Color.Red;
            this.btntoday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntoday.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btntoday.ForeColor = System.Drawing.Color.White;
            this.btntoday.Image = global::QR_Attendance_System.Properties.Resources.attndnc_1_;
            this.btntoday.ImagePosition = 1;
            this.btntoday.ImageZoom = 15;
            this.btntoday.LabelPosition = 30;
            this.btntoday.LabelText = "Today";
            this.btntoday.Location = new System.Drawing.Point(-1, 120);
            this.btntoday.Margin = new System.Windows.Forms.Padding(6);
            this.btntoday.Name = "btntoday";
            this.btntoday.Size = new System.Drawing.Size(252, 75);
            this.btntoday.TabIndex = 3;
            this.btntoday.Click += new System.EventHandler(this.btntoday_Click);
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
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QR_Attendance_System.Properties.Resources.BG2_1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "QR-Based Operational Network \r\nDatabase of Attendance \r\nRecord Sytem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "QRONOS";
            // 
            // frm_main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.mainDash);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_main1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main1";
            this.Load += new System.EventHandler(this.frm_main1_Load);
            this.mainDash.ResumeLayout(false);
            this.mainDash.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainDash;
        private Bunifu.Framework.UI.BunifuTileButton btnlogout;
        private Bunifu.Framework.UI.BunifuTileButton btnmonthly;
        private Bunifu.Framework.UI.BunifuTileButton btnweekly;
        private Bunifu.Framework.UI.BunifuTileButton btntoday;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label lbl_loggedtype;
        private System.Windows.Forms.Label lbl_loggedname;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}