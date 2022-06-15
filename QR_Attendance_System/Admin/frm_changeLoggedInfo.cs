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
    public partial class frm_changeLoggedInfo : Form
    {
        String logged_id;
        public frm_changeLoggedInfo(string logged_id)
        {
            InitializeComponent();
            this.logged_id = logged_id;
        }

        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");

        //exit
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void selection_head()
        {
            DataTable dt2 = Employee.GetData("SELECT * FROM tblemployee WHERE Office = '" + select_office + "'");
            dataGridView2.DataSource = dt2;

            for (int num = 0; num <= dt2.Rows.Count - 1; num++)
            {
                //bunifuDropdown1.Items.Add(dt2.Rows[num].Field<string>("Name"));
            }
        }

        //when the selected cell is click
        private int row = -1;
        string select_iD = "", select_office = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //bunifuDropdown1.Items.Clear();
            errorProvider1.Clear();
            select_iD = "";
            try
            {
                row = e.RowIndex;

                //User Status
                select_iD = dataGridView1.Rows[row].Cells[0].Value.ToString();

                DataTable dt1 = Employee.GetData("SELECT * FROM tblemployee WHERE Employee_ID = '" + select_iD + "'");
                if (dt1.Rows.Count > 0)
                {
                    label7.Text = dt1.Rows[0].Field<string>("Lname");
                    label9.Text = dt1.Rows[0].Field<string>("Fname");
                    label10.Text = dt1.Rows[0].Field<string>("Mname");
                    label11.Text = dt1.Rows[0].Field<string>("Suffix");
                    bunifuDropdown2.Text = dt1.Rows[0].Field<string>("Position");
                    select_office = dt1.Rows[0].Field<string>("Office");
                    bunifuDropdown1.Text = dt1.Rows[0].Field<string>("Immediate_Head");
                }
                selection_head();
            }

            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                    Employee.executeSQL("UPDATE tblemployee SET Immediate_Head ='" + bunifuDropdown1.Text + "' WHERE Employee_ID = '" + select_iD + "'");
                    if (Employee.rowAffected > 0)
                    {
                        MessageBox.Show("Updated Succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearing();
                        dataGridView1.Refresh();
                         this.Hide();
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearing()
        {
            label10.Text = "";
            label11.Text = "";
            label9.Text = "";
            label7.Text = "";
            bunifuDropdown1.SelectedIndex = -1;
            bunifuDropdown1.SelectedIndex = -1;
        }

        private void frm_changeLoggedInfo_Load(object sender, EventArgs e)
        {
            DataTable dt = Employee.GetData("SELECT * FROM tblemployee");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            for (int x = 0; x <= 11; x++)
            {
                dataGridView1.Columns[x].Visible = false;
            }
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[11].Visible = true;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearing();
        }
    }
}
