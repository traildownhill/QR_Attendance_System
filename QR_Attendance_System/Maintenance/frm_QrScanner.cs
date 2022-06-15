using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.Threading;

namespace QR_Attendance_System
{
    public partial class frm_QrScanner : Form
    {
        public frm_QrScanner()
        {
            InitializeComponent();
        }
        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");

        string remark, data1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void frm_QrScanner_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = DateTime.Now.ToString("tt");
            label5.Text = DateTime.Now.ToString("HHmm");
            bunifuTextBox1.Select();
        }

        //int txtLength = 0;
        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

            if (bunifuTextBox1.TextLength == 12) // nu number lng a 12 tatajan munchi.
            {

                if (string.IsNullOrEmpty(bunifuTextBox1.Text))
                {
                    errorProvider1.SetError(bunifuTextBox1, "Scan your QR");
                }
                else
                {
                    DataTable dt = Employee.GetData("SELECT* FROM tblemployee WHERE Employee_id ='" + bunifuTextBox1.Text + "'");
                    if (dt.Rows.Count > 0)
                    {
                        SavingScannedQR();
                    }
                    else
                    {
                        MessageBox.Show("No ID in the Database List!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    bunifuTextBox1.Clear();
                }
            }
        }

        int attenDays;
        private EventArgs e;

        private void SavingScannedQR()
        {
            //string emp_id = textBox1.Text();
            string emp_id = bunifuTextBox1.Text;
            var id1 = DateTime.Now.ToString("MMddHHmmss");
            //string timeStamp = GetTimestamp(DateTime.Now);

            DataTable dt = Employee.GetData("SELECT* FROM tblemployee_attendance WHERE Employee_id ='" + emp_id + "'");
            if (dt.Rows.Count > 0)
            {
                data1 = dt.Rows[0].Field<string>("Num_Days_Present");
                attenDays = Int32.Parse(data1);
            }

            //MORNING ATTENDANCE
            if (DateTime.Now.ToString("tt") == "AM")
            {
                int d1 = Int32.Parse(DateTime.Now.ToString("HHmm"));

                DataTable dt2 = Employee.GetData("SELECT* FROM tbl_am WHERE Employee_id ='" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'");
                if (dt2.Rows.Count > 0)
                {
                    //Time out
                    if (d1 >= 1200 && d1 <= 1205)
                    {
                        //Afternoon
                        Employee.executeSQL("UPDATE tbl_am SET Time_OUT = '" + DateTime.Now.ToString("HH:mm:ss") + "', Under_Over = '' WHERE Employee_ID = '" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "')");
                        if (Employee.rowAffected > 0)
                        {
                            MessageBox.Show("Time Out Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Hide();
                        }
                    }
                    else if(d1 < 1200 && d1 > 1100)
                    {
                        Employee.executeSQL("UPDATE tbl_am SET Time_OUT = '" + DateTime.Now.ToString("HH:mm:ss") + "', Under_Over = 'Under Time' WHERE Employee_ID = '" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "')");
                        if (Employee.rowAffected > 0)
                        {
                            MessageBox.Show("Time Out Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Hide();
                        }
                    }
                    else if (d1 >= 0800 && d1 <= 0830)
                    {
                        MessageBox.Show("Attendance Already Recorded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (dt2.Rows.Count <= 0)
                {
                    //Time in
                    if (d1 >= 0800 && d1 <= 0830)
                    {
                        if (d1 <= 0800)
                        {
                            remark = "On-Time";
                        }
                        else if (d1 >= 0805)
                        {
                            remark = "Late";
                        }

                        
                        //Morning
                        Employee.executeSQL("INSERT INTO tbl_am (`id`,`Employee_ID`, `Time_IN`, `Date`, `Remark`,`Under_Over`) VALUES ('" + id1 + "','" + emp_id + "', '" + DateTime.Now.ToString("HH:mm:ss") + "', '" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + remark + "','' )");
                        if (Employee.rowAffected > 0)
                        {
                            MessageBox.Show("Time In Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Hide();
                        }

                        attenDays = attenDays + 1;

                        //Setting the number of present
                        Employee.executeSQL("UPDATE tblemployee_attendance SET Num_Days_Present = '" + attenDays.ToString() + "' WHERE Employee_ID = '" + emp_id + "'");
                        if (Employee.rowAffected > 0)
                        {
                            //MessageBox.Show("Updated Days Present!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Hide();
                        }
                    }
                }
            }


            //AFTERNOON ATTENDANCE
            else if (DateTime.Now.ToString("tt") == "PM")
            {
                int d1 = Int32.Parse(DateTime.Now.ToString("HHmm"));

                DataTable dt3 = Employee.GetData("SELECT* FROM tbl_pm WHERE Employee_id ='" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'");
                if (dt3.Rows.Count > 0)
                {
                    label5.Text = "May Laman";
                    //time out
                    if (d1 >= 1650 && d1 <= 1710)
                    {
                        //Afternoon
                        Employee.executeSQL("UPDATE tbl_pm SET Time_OUT = '" + DateTime.Now.ToString("HH:mm:ss") + "' WHERE Employee_ID = '" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'");
                        if (Employee.rowAffected > 0)
                        {
                            MessageBox.Show("Time Out Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Hide();
                        }
                    }
                    else if (d1 < 1650 && d1 > 1310)
                    {
                        Employee.executeSQL("UPDATE tbl_pm SET Time_OUT = '" + DateTime.Now.ToString("HH:mm:ss") + "', Under_Over = 'Under Time' WHERE Employee_ID = '" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'");
                        if (Employee.rowAffected > 0)
                        {
                            MessageBox.Show("Time Out Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (d1 > 1650)
                    {
                        Employee.executeSQL("UPDATE tbl_pm SET Time_OUT = '" + DateTime.Now.ToString("HH:mm:ss") + "', Under_Over = 'Over Time' WHERE Employee_ID = '" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'");
                        if (Employee.rowAffected > 0)
                        {
                            MessageBox.Show("Time Out Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (d1 >= 1250 && d1 <= 1310)
                    {
                        MessageBox.Show("Attendance Already Recorded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                //
                else if (dt3.Rows.Count <= 0)
                {
                    label5.Text = "Abus Laman";
                    if (d1 <= 1300)
                    {
                        remark = "On-Time";
                    }
                    else if (d1 > 1300)
                    {
                        remark = "Late";
                    }
                    //detect if time in or time out
                    //time in
                    if (d1 >= 1250 && d1 <= 1710)
                    {
                        //Afternoon
                        Employee.executeSQL("INSERT INTO tbl_pm (`id`, `Employee_ID`, `Time_IN`, `Date`, `Remark`,`Under_Over`) VALUES ('" + id1 + "','" + emp_id + "', '" + DateTime.Now.ToString("HH:mm:ss") + "', '" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + remark + "', '' )");
                        if (Employee.rowAffected > 0)
                        {
                            MessageBox.Show("Time In Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            //this.Hide();
                        }

                        attenDays = attenDays + 1;

                        //Setting the number of present
                        Employee.executeSQL("UPDATE tblemployee_attendance SET Num_Days_Present = '" + attenDays.ToString() + "' WHERE Employee_ID = '" + emp_id + "'");
                        if (Employee.rowAffected > 0)
                        {
                            //MessageBox.Show("Updated Days Present!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Hide();
                        }
                    }
                    //else if (d1 > 1310)
                    //{
                    //    MessageBox.Show("Already not Office Hours", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                }
            }
        }
    }
}
