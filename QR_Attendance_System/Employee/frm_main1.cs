using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Attendance_System
{
    public partial class frm_main1 : Form
    {
        String logged_name, logged_position, logged_id;
        public frm_main1(string logged_name, string logged_position, string logged_id)
        {
            InitializeComponent();
            this.logged_name = logged_name;
            this.logged_position = logged_position;
            this.logged_id = logged_id;
        }

        Class1 Login = new Class1("127.0.0.1", "qronos", "root", " ");

        //opening a child form
        private Form activeForm = null;
        private void openchildform(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            mainDash.Controls.Add(childForm);
            mainDash.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btntoday_Click(object sender, EventArgs e)
        {
            openchildform(new frm_today(logged_id));
        }

        private void btnweekly_Click(object sender, EventArgs e)
        {
            openchildform(new frm_weekly(logged_id,""));
        }

        private void btnmonthly_Click(object sender, EventArgs e)
        {
            openchildform(new frm_monthly(logged_id,""));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            frmlogin_1 login = new frmlogin_1();
            login.Show();
            this.Hide();
        }

        private void frm_main1_Load(object sender, EventArgs e)
        {
            lbl_loggedname.Text = logged_name;
            lbl_loggedtype.Text = logged_position;

            lbltime.Text = DateTime.Now.ToString("MMM-dd-yyyy HH:mm:ss");
            DataTable dt = Login.GetData("SELECT* FROM tblemployee WHERE Employee_id ='" + logged_id + "'");
            if (dt.Rows.Count > 0)
            {
                string loc = dt.Rows[0].Field<string>("ID_pic");
                bunifuPictureBox1.ImageLocation = @loc;

            }
        }
    }
}
