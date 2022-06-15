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
    public partial class startpage : Form
    {
        public startpage()
        {
            InitializeComponent();
        }

        //admin redirect
        private void btnadmin_Click(object sender, EventArgs e)
        {
            frmlogin admin = new frmlogin();
            admin.Show();
            this.Hide();
        }

        //emplyee redirect
        private void btnemployee_Click(object sender, EventArgs e)
        {
            frmlogin_1 employee = new frmlogin_1();
            employee.Show();
            this.Hide();
        }

        private void startpage_Load(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("MMM-dd-yyyy HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_QrScanner scanQr = new frm_QrScanner();
            scanQr.Show();
        }
    }
}
