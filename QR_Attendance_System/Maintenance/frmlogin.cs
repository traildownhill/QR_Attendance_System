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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        Class1 Login = new Class1("127.0.0.1", "qronos", "root", " ");

        //validate
        private int errorcount;
        private void validateform()
        {
            errorProvider1.Clear();
            errorcount = 0;

            DataTable dt1 = Login.GetData("SELECT* FROM tblemployee WHERE Employee_ID ='" + txtid.Text + "' AND Status = 'Deactive'");
            if (dt1.Rows.Count > 0)
            {
                MessageBox.Show("Your not the Administrator", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(txtpass.Text))
                {
                    errorProvider1.SetError(txtpass, "Empty");
                    errorcount++;
                }
            }

            if (string.IsNullOrEmpty(txtid.Text))
            {
                errorProvider1.SetError(txtid, "Empty");
                errorcount++;
            }
            
        }

        //go to main dashboard
        private void btnlogin_Click(object sender, EventArgs e)
        {
            validateform();
            if (errorcount == 0)
            {
                DataTable dt = Login.GetData("SELECT* FROM tblemployee WHERE Employee_id ='"+txtid.Text+"' AND Password = '"+txtpass.Text+"'");
                if (dt.Rows.Count > 0)
                {
                    if(dt.Rows[0].Field<string>("Position") == "Administrator")
                    {
                        if(dt.Rows[0].Field<string>("Status") == "Active")
                        {
                            MessageBox.Show(txtid.Text + " Successfully Login !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm_main main = new frm_main(dt.Rows[0].Field<string>("Name"), dt.Rows[0].Field<string>("Position"), dt.Rows[0].Field<string>("Employee_id"));
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Your not Allowed to logeed in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your not the Administrator", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Id and Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            startpage frst = new startpage();
            frst.Show();
            this.Hide();
        }

        //Clear
        private void button1_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtpass.Text = "";
        }

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

        private void frmlogin_Load(object sender, EventArgs e)
        {
           lbltime.Text = DateTime.Now.ToString("MMM-dd-yyyy HH:mm:ss");
        }
    }
}
