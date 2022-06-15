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
    public partial class frm_newEmployee : Form
    {
        public frm_newEmployee()
        {
            InitializeComponent();
        }

        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");

        private int errorcount;
        public void validateForm()
        {
            errorProvider1.Clear();
            errorcount = 0;

            DataTable dt = Employee.GetData("select * from tblemployee where Employee_ID='" + txt0.Text + "'");

            if (dt.Rows.Count > 0)
            {
                errorProvider1.SetError(txt0, "ID is already existing");
                errorcount++;
            }

            if (string.IsNullOrEmpty(txt0.Text))
            {
                errorProvider1.SetError(txt0, "Empty ID");
                errorcount++;
            }
            if (string.IsNullOrEmpty(txt1.Text))
            {
                errorProvider1.SetError(txt1, "Empty First Name");
                errorcount++;
            }
            if (string.IsNullOrEmpty(txt2.Text))
            {
                errorProvider1.SetError(txt2, "Empty Last Name");
                errorcount++;
            }

            if (cmb1.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmb1, "Select Position");
                errorcount++;
            }
            if (cmb2.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmb1, "Select Office");
                errorcount++;
            }
        }
        public void clearing()
        {
            txt0.Clear();
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            cmb1.SelectedIndex = -1;
            cmb2.SelectedIndex = -1;
            label10.Text = "C:";
        }

        //close
        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        //insert image
        string imageLoc = "";
        private void btn1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Images|*.png|JPG Image|*.jpg";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label10.Text = ofd.FileName;
                imageLoc = ofd.FileName;
                imageLoc = imageLoc.Replace("\\", "\\\\");
            }
        }

        //save
        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                validateForm();
                if (errorcount == 0)
                {
                    string name = txt2.Text + " " + txt3.Text + " " + txt1.Text + " " + txt4.Text;
                    Employee.executeSQL("INSERT INTO tblemployee VALUES ('" + txt0.Text + "','','Deactive','" + name + "','" + txt2.Text + "','" + txt1.Text + "','" + txt3.Text + "','" + txt4.Text + "','" + cmb1.Text + "','" + cmb2.Text + "','" + imageLoc + "','','')");
                    Employee.executeSQL("INSERT INTO tblemployee_attendance VALUES ('" + txt0.Text+"','"+ name +"', '0','"+ DateTime.Now.ToString("MMMM d, yyyy") + "')");
                    if (Employee.rowAffected > 0)
                    {
                        MessageBox.Show("New Employee Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearing();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //accept only number
        private void txt0_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt0.Text, "  ^ [0-9]"))
            {
                txt0.Text = "";
            }
        }

        //keypress
        private void txt0_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            clearing();
        }
    }
}
