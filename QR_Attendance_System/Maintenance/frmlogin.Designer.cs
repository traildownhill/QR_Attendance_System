namespace QR_Attendance_System
{
    partial class frmlogin
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
            this.lblback = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtlbl1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbox = new System.Windows.Forms.CheckBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtlbl2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblback
            // 
            this.lblback.AutoSize = true;
            this.lblback.BackColor = System.Drawing.Color.White;
            this.lblback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblback.Location = new System.Drawing.Point(12, 59);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(85, 20);
            this.lblback.TabIndex = 24;
            this.lblback.Text = "Start Page";
            this.lblback.Click += new System.EventHandler(this.lblback_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(699, 15);
            this.lbltime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(118, 19);
            this.lbltime.TabIndex = 23;
            this.lbltime.Text = "Date and Time";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(512, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(362, 467);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(110, 35);
            this.btnlogin.TabIndex = 22;
            this.btnlogin.Text = "PROCEED";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(356, 328);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(266, 30);
            this.txtid.TabIndex = 20;
            // 
            // txtlbl1
            // 
            this.txtlbl1.AutoSize = true;
            this.txtlbl1.BackColor = System.Drawing.Color.White;
            this.txtlbl1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl1.Location = new System.Drawing.Point(358, 299);
            this.txtlbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtlbl1.Name = "txtlbl1";
            this.txtlbl1.Size = new System.Drawing.Size(131, 26);
            this.txtlbl1.TabIndex = 19;
            this.txtlbl1.Text = "ID Number:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QR_Attendance_System.Properties.Resources.BG2A;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(970, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pcbox
            // 
            this.pcbox.AutoSize = true;
            this.pcbox.BackColor = System.Drawing.Color.White;
            this.pcbox.FlatAppearance.BorderSize = 0;
            this.pcbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pcbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcbox.Location = new System.Drawing.Point(356, 428);
            this.pcbox.Margin = new System.Windows.Forms.Padding(2);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(139, 24);
            this.pcbox.TabIndex = 27;
            this.pcbox.Text = "Show Passcode";
            this.pcbox.UseVisualStyleBackColor = false;
            this.pcbox.CheckedChanged += new System.EventHandler(this.pcbox_CheckedChanged);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(356, 394);
            this.txtpass.Margin = new System.Windows.Forms.Padding(2);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(266, 30);
            this.txtpass.TabIndex = 26;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtlbl2
            // 
            this.txtlbl2.AutoSize = true;
            this.txtlbl2.BackColor = System.Drawing.Color.White;
            this.txtlbl2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl2.Location = new System.Drawing.Point(357, 366);
            this.txtlbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtlbl2.Name = "txtlbl2";
            this.txtlbl2.Size = new System.Drawing.Size(122, 26);
            this.txtlbl2.TabIndex = 25;
            this.txtlbl2.Text = "Passcode:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 587);
            this.Controls.Add(this.pcbox);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtlbl2);
            this.Controls.Add(this.lblback);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtlbl1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(986, 626);
            this.MinimumSize = new System.Drawing.Size(986, 626);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login as Admin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblback;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label txtlbl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox pcbox;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label txtlbl2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}