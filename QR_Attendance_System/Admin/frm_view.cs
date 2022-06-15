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
    public partial class frm_view : Form
    {
        String selected_id, logged_id;
        public frm_view(string selected_id,string logged_id)
        {
            InitializeComponent();
            this.selected_id = selected_id;
            this.logged_id = logged_id;
        }
        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");

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
            openchildform(new frm_today(selected_id));
        }

        private void btnweekly_Click(object sender, EventArgs e)
        {
            openchildform(new frm_weekly(selected_id, logged_id));
        }

        private void btnmonthly_Click(object sender, EventArgs e)
        {
            openchildform(new frm_monthly(selected_id,logged_id));
        }

        //main load
        private void frm_view_Load(object sender, EventArgs e)
        {

            DataTable dt = Employee.GetData("SELECT* FROM tblemployee WHERE Employee_id ='" + selected_id + "'");
            if (dt.Rows.Count > 0)
            {
                lbl_loggedname.Text = dt.Rows[0].Field<string>("Fname");
                lbl_loggedtype.Text = dt.Rows[0].Field<string>("Position");
                label1.Text = dt.Rows[0].Field<string>("Name");
                label4.Text = dt.Rows[0].Field<string>("Position");
                label3.Text = dt.Rows[0].Field<string>("Office");

                string loc = dt.Rows[0].Field<string>("ID_pic");
                bunifuPictureBox1.ImageLocation = @loc;
                bunifuPictureBox2.ImageLocation = @loc;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
