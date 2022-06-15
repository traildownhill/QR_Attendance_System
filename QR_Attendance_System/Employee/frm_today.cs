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
    public partial class frm_today : Form
    {
        String selected_id;
        public frm_today(string selected_id)
        {
            InitializeComponent();
            this.selected_id = selected_id;
        }

        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frm_today_Load(object sender, EventArgs e)
        {
            lbldays.Text = "Date: " + DateTime.Now.ToString("MM/dd/yyyy");
            DataTable dt2 = Employee.GetData("SELECT* FROM tblemployee WHERE Employee_id ='" + selected_id + "'");
            if (dt2.Rows.Count > 0)
            {
                string loc = dt2.Rows[0].Field<string>("ID_pic");
                bunifuPictureBox2.ImageLocation = @loc;
                label7.Text = dt2.Rows[0].Field<string>("Fname");
                label4.Text = dt2.Rows[0].Field<string>("Position");
                label3.Text = dt2.Rows[0].Field<string>("Office");
            }

            var d1 = DateTime.Now.ToString("MM/dd/yyyy");

            DataTable dt = Employee.GetData("SELECT * FROM tbl_am WHERE Employee_ID = '" + selected_id + "' AND Date like '%" + d1 + "%'");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            DataTable dt1 = Employee.GetData("SELECT * FROM tbl_pm WHERE Employee_ID = '" + selected_id + "' AND Date LIKE  '%" + d1 + "%'");
            dataGridView2.DataSource = dt1;
            dataGridView2.Refresh();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[4].Visible = false;
        }
    }
}
