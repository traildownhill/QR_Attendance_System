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
    public partial class frm_changeAdmin : Form
    {
        String logged_id;
        public frm_changeAdmin(string logged_id)
        {
            InitializeComponent();
            this.logged_id = logged_id;
        }
        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");

        private int errorcount;
        public void validateForm()
        {
            errorProvider1.Clear();
            errorcount = 0;

            if(txtpass.Text != curr_pass )
            {
                MessageBox.Show("Password in current Admin not match with the logged in password, Try Again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorcount++;
            }if(select_iD == "")
            {
                MessageBox.Show("Select New Admin, Try Again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorcount++;
            }
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                errorProvider1.SetError(txtpass, "Empty Password");
                errorcount++;
            }
            if (string.IsNullOrEmpty(txtpass_new.Text))
            {
                errorProvider1.SetError(txtpass_new, "Empty New Pasasword");
                errorcount++;
            }
        } 
        public void clearing()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtpass.Text = "";
            txtid_new.Text = "";
            txtname_new.Text = "";
            txtpass_new.Text = "";
        }
        //exit
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //save and assign
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                validateForm();
                if (errorcount == 0)
                {   
                    Employee.executeSQL("UPDATE tblemployee SET Password = '"+ txtpass_new.Text+"', Status = 'Active', Position = 'Administrator'  WHERE Employee_ID = '"+txtid_new.Text+"'");
                    Employee.executeSQL("UPDATE tblemployee SET Status = 'Deactive', Password = '', Position = 'Employee' WHERE Employee_ID = '"+logged_id+"'");
                    if (Employee.rowAffected > 0)
                    {
                        MessageBox.Show("New Admin is Assigned", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clearing();
                        frm_changeAdmin_Shown(this, e);
                        this.Hide();
                        MessageBox.Show("Please Logged to Your Account.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //main load
        int x = 0;
        string curr_pass = "";
        private void frm_changeAdmin_Shown(object sender, EventArgs e)
        {
            DataTable dt = Employee.GetData("SELECT * FROM tblemployee");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

           for(x = 0; x<=11; x++)
            {
                dataGridView1.Columns[x].Visible = false;
            }
            dataGridView1.Columns[3].Visible = true;

            //
            DataTable dt1 = Employee.GetData("SELECT* FROM tblemployee WHERE Employee_id ='" + logged_id + "'");
            if (dt1.Rows.Count > 0)
            {
                txtid.Text = logged_id;
                txtname.Text = dt1.Rows[0].Field<string>("Name");
                //txtpass.Text = dt.Rows[0].Field<string>("Password");
                curr_pass = dt1.Rows[0].Field<string>("Password");
            }
        }


        //when the selected cell is click
        private int row = -1;
        string select_iD = "";

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.Clear();
            select_iD = "";
            try
            {
                row = e.RowIndex;

                //User Status
                select_iD = dataGridView1.Rows[row].Cells[0].Value.ToString();

                if (select_iD == logged_id)
                {
                    MessageBox.Show("Cannot Select Current Admin!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtid_new.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                    txtname_new.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
                    //txtpass_new.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                }

               
            }

            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //check box
        private void pcbox_CheckedChanged(object sender, EventArgs e)
        {
            if (pcbox.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void pcbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pcbox1.Checked)
            {
                txtpass_new.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass_new.UseSystemPasswordChar = true;
            }
        }

        private void frm_changeAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
