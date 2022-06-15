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
    public partial class frm_weekly : Form
    {
        String selected_id, logged_id;
        public frm_weekly(string selected_id,string logged_id)
        {
            InitializeComponent();
        this.selected_id = selected_id;
        this.logged_id = logged_id;
        }

        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        //main load
        string status;
        private void frm_weekly_Load(object sender, EventArgs e)
        {
            //lbldays.Text = "Date: " + DateTime.Now.ToString("MMM-dd-yyyy");
            DataTable dt2 = Employee.GetData("SELECT* FROM tblemployee WHERE Employee_id ='" + selected_id + "'");
            if (dt2.Rows.Count > 0)
            {
                string loc = dt2.Rows[0].Field<string>("ID_pic");
                bunifuPictureBox2.ImageLocation = @loc;
                label7.Text = dt2.Rows[0].Field<string>("Fname");
                label4.Text = dt2.Rows[0].Field<string>("Position");
                label3.Text = dt2.Rows[0].Field<string>("Office");
                
            }
            DataTable dt3 = Employee.GetData("SELECT* FROM tblemployee WHERE Employee_id ='" + logged_id + "'");
            if (dt3.Rows.Count > 0)
            {
                status = dt3.Rows[0].Field<string>("Status");
            }

            if (status == "Deactive")
            {
                panel2.Visible = false;
            }
            else if(status == "Active")
            {
                panel2.Visible = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dTime = dateTimePicker1.Value.Date;

            label2.Text = "Start: " + dTime.ToString("MM/dd/yyyy");
            label5.Text = "End: " + dTime.AddDays(7).ToString("MM/dd/yyyy");
            bunifuButton1.Enabled = true;

            DataTable dt = Employee.GetData("SELECT * FROM `tbl_am` WHERE Employee_ID = '"+selected_id+"' AND Date BETWEEN '"+ dTime.ToString("MM/dd/yyyy") + "' AND '"+ dTime.AddDays(7).ToString("MM/dd/yyyy") + "'");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            DataTable dt1 = Employee.GetData("SELECT * FROM `tbl_pm` WHERE Employee_ID = '" + selected_id + "' AND Date BETWEEN '" + dTime.ToString("MM/dd/yyyy") + "' AND '" + dTime.AddDays(7).ToString("MM/dd/yyyy") + "'");
            dataGridView2.DataSource = dt1;
            dataGridView2.Refresh();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[4].Visible = false;
        }

        //Printing
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //frm_print printing = new frm_print();
            //printing.Show();
            MessageBox.Show("We are still working on it.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
