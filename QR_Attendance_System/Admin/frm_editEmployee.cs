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
    public partial class frm_editEmployee : Form
    {
        String selected_id;
        public frm_editEmployee(string selected_id)
        {
            InitializeComponent();
            this.selected_id = selected_id;
        }

        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");

        private int errorcount;
        public void validateForm()
        {
            errorProvider1.Clear();
            errorcount = 0;

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

        //main load
        private void frm_editEmployee_Load(object sender, EventArgs e)
        {
            DataTable dt = Employee.GetData("SELECT* FROM tblemployee WHERE Employee_id ='" + selected_id + "'");
            if (dt.Rows.Count > 0)
            {
                txt0.Text = selected_id;
                txt2.Text = dt.Rows[0].Field<string>("Fname");
                txt1.Text = dt.Rows[0].Field<string>("Lname");
                txt3.Text = dt.Rows[0].Field<string>("Mname");
                txt4.Text = dt.Rows[0].Field<string>("Suffix");
                cmb1.Text = dt.Rows[0].Field<string>("Position");
                cmb2.Text = dt.Rows[0].Field<string>("Office");
                label10.Text = dt.Rows[0].Field<string>("ID_pic");
            }
        }

        //id pic
        string imageLoc = "";
        private void btn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Images|*.png|JPG Image|*.jpg";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label10.Text = ofd.FileName;
                imageLoc = ofd.FileName;
                imageLoc = imageLoc.Replace("\\","\\\\");
            }
        }
        //save
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                validateForm();
                if (errorcount == 0)
                {
                    string name = txt2.Text + " " + txt3.Text + " " + txt1.Text + " " + txt4.Text;
                    Employee.executeSQL("UPDATE tblemployee SET Lname ='"+txt1.Text+ "', Mname ='" + txt3.Text + "', Position ='" + cmb1.Text + "', Office ='" + cmb2.Text + "', ID_pic ='" + imageLoc + "' WHERE Employee_ID = '"+selected_id+"'");
                    if (Employee.rowAffected > 0)
                    {
                        MessageBox.Show("Updated Succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(imageLoc + "//" + label10.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearing();
                        this.Hide();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //clear
        private void btnclear_Click(object sender, EventArgs e)
        {
            clearing();
        }

        //close
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
