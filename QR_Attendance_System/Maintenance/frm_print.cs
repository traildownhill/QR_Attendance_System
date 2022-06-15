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
    public partial class frm_print : Form
    {
        public frm_print()
        {
            InitializeComponent();
        }

        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");
        //main load
        private void frm_print_Load(object sender, EventArgs e)
        {

        }

        //printing
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(B, 0, 0);
        }
        Bitmap B;
    }
}
