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
    public partial class frmlogin_1 : Form
    {
        public frmlogin_1()
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
                DataTable dt = Login.GetData("SELECT* FROM tblemployee WHERE Employee_id ='" + txtid.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    frm_main1 main = new frm_main1(dt.Rows[0].Field<string>("Name"), dt.Rows[0].Field<string>("Position"), dt.Rows[0].Field<string>("Employee_id"));
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            startpage frst = new startpage();
            frst.Show();
            this.Hide();
        }
    }
}
