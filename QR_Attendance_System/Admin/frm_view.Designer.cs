namespace QR_Attendance_System
{
    partial class frm_view
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_view));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnmonthly = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnweekly = new Bunifu.Framework.UI.BunifuTileButton();
            this.btntoday = new Bunifu.Framework.UI.BunifuTileButton();
            this.sidebar = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_loggedtype = new System.Windows.Forms.Label();
            this.lbl_loggedname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.mainDash = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.mainDash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QR_Attendance_System.Properties.Resources.BG2_1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1014, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DarkRed;
            this.sidebar.Controls.Add(this.btnmonthly);
            this.sidebar.Controls.Add(this.btnweekly);
            this.sidebar.Controls.Add(this.btntoday);
            this.sidebar.Controls.Add(this.bunifuPictureBox1);
            this.sidebar.Controls.Add(this.lbl_loggedtype);
            this.sidebar.Controls.Add(this.lbl_loggedname);
            this.sidebar.Location = new System.Drawing.Point(0, 47);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(252, 620);
            this.sidebar.TabIndex = 30;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Athina Heruela";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "DepEd";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Clerk 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuPictureBox2);
            this.panel1.Location = new System.Drawing.Point(223, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 409);
            this.panel1.TabIndex = 0;
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 78;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(82, 24);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(157, 157);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 0;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // mainDash
            // 
            this.mainDash.AutoScroll = true;
            this.mainDash.BackColor = System.Drawing.Color.White;
            this.mainDash.Controls.Add(this.panel1);
            this.mainDash.Location = new System.Drawing.Point(254, 47);
            this.mainDash.Name = "mainDash";
            this.mainDash.Size = new System.Drawing.Size(760, 485);
            this.mainDash.TabIndex = 31;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 531);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.mainDash);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1030, 570);
            this.MinimumSize = new System.Drawing.Size(1030, 570);
            this.Name = "frm_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_view";
            this.Load += new System.EventHandler(this.frm_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.mainDash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton btnmonthly;
        private Bunifu.Framework.UI.BunifuTileButton btnweekly;
        private Bunifu.Framework.UI.BunifuTileButton btntoday;
        private System.Windows.Forms.Panel sidebar;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label lbl_loggedtype;
        private System.Windows.Forms.Label lbl_loggedname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private System.Windows.Forms.Panel mainDash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}