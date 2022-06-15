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
    public partial class frm_attendance : Form
    {
        public frm_attendance()
        {
            InitializeComponent();
        }
        Class1 Attendance = new Class1("127.0.0.1", "qronos", "root", "");

        //close form
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //refresh the form
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            cmb_filter.SelectedIndex = -1;
            txt_filterID.Visible = false;
            txt_filterName.Visible = false;
        }

        //main load
        private void frm_attendance_Shown(object sender, EventArgs e)
        {
            DataTable dt = Attendance.GetData("SELECT * FROM tblemployee_attendance");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            dataGridView1.Columns[0].Visible = false;
        }

        //filter
        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_filter.SelectedIndex == 0)
            {
                txt_filterID.Visible = true;
                txt_filterName.Visible = false;
            }
            else if (cmb_filter.SelectedIndex == 1)
            {
                txt_filterID.Visible = false;
                txt_filterName.Visible = true;
            }
            else
            {
                txt_filterID.Visible = false;
                txt_filterName.Visible = false;
            }
        }

        //filter name
        private void txt_filterName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Attendance.GetData("SELECT * FROM tblemployee_attendance WHERE Name like '%" + txt_filterName.Text + "%'");
                dataGridView1.DataSource = dt;
            }

            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //filter id
        private void txt_filterID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Attendance.GetData("SELECT * FROM tblemployee_attendance WHERE Employee_ID like '%" + txt_filterID.Text + "%' AND Date = '%"+ DateTime.Now.ToString("MMMM") + "%'");
                dataGridView1.DataSource = dt;
            }

            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //cell click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //print page
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(B, 0, 0);
        }
        Bitmap B;
        
        //Printing
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //btnexit.Visible = false;
            //btnprint.Visible = false;
            Panel p = new Panel();
            this.Controls.Add(p);

            Graphics gr = p.CreateGraphics();
            Size sz = this.ClientSize;
            B = new Bitmap(sz.Width, sz.Height, gr);
            gr = Graphics.FromImage(B);

            Point pt = PointToScreen(p.Location);
            gr.CopyFromScreen(pt.X, pt.Y, 0, 0, sz);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            this.Hide();
        }
    }
}
