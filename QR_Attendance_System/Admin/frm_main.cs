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
    public partial class frm_main : Form
    {
        String logged_name, logged_position, logged_id;
        public frm_main(string logged_name, string logged_position, string logged_id)
        {
            InitializeComponent();

            //initialize the concantination
            this.logged_name = logged_name;
            this.logged_position = logged_position;
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

        //custom design
        private void customdesign()
        {
            settings.Visible = false;

            //assigning academic year
        }

        //hide submenu
        private void hidesubmenu()
        {
            if (settings.Visible == true)
                settings.Visible = false;
        }

        //show submenu
        private void showsubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidesubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //atttendance
        private void btnattendance_Click(object sender, EventArgs e)
        {
            openchildform(new frm_attendance());
            settings.Visible = false;
        }

        //settings
        private void btnsettings_Click(object sender, EventArgs e)
        {
            showsubmenu(settings);
        }

        //Dashboard
        private void btnhome_Click(object sender, EventArgs e)
        {
            openchildform(new frm_accountList(logged_id));
            settings.Visible = false;
        }

        //change logged account 
        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            openchildform(new frm_changeAdmin(logged_id));
        }

        //change imidiete head
        private void bunifuTileButton3_Click_1(object sender, EventArgs e)
        {
            openchildform(new frm_changeLoggedInfo(logged_id));
        }

        //new employee
        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            openchildform(new frm_newEmployee());
        }

        private void mainDash_Paint(object sender, PaintEventArgs e)
        {

        }

        //main load form
        private void frm_main_Load(object sender, EventArgs e)
        {
            lbl_loggedname.Text = logged_name;
            lbl_loggedtype.Text = logged_position;

            lbltime.Text = DateTime.Now.ToString("MMM-dd-yyyy HH:mm:ss");
            DataTable dt = Employee.GetData("SELECT* FROM tblemployee WHERE Employee_id ='" + logged_id + "'");
            if (dt.Rows.Count > 0)
            {
                string loc = dt.Rows[0].Field<string>("ID_pic");
                bunifuPictureBox1.ImageLocation = @loc;

            }
        }

        //logout
        private void btnlogout_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Hide();
        }
    }
}
