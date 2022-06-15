using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace QR_Attendance_System
{
    public partial class frm_qrCode : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public frm_qrCode()
        {
            InitializeComponent();
        }

        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");
        
        private void btndecode_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ofd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    txt2.Text = decoder.Decode(new MessagingToolkit.QRCode.Codec.Data.QRCodeBitmapImage(pictureBox1.Image as Bitmap));


                    SavingScannedQR();
                }
            }
        }

        string dateNow, dateAMPM,primaryID;
        private void frm_qrCode_Load(object sender, EventArgs e)
        {
            CaptureQR();

            dateNow = DateTime.Now.ToString("MMM-dd-yyyy HH:mm:ss");
            primaryID = DateTime.Now.ToString("dMyyyyHHmmss");
            dateAMPM = DateTime.Now.ToString("tt");

            label1.Text = dateAMPM;
            textBox1.Select();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            otherStart();
        }

        private void frm_qrCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop(); 
            }
        }

        int attenDays;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(picbox1.Image != null)
            {
                MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                textBox1.Text = decoder.Decode(new MessagingToolkit.QRCode.Codec.Data.QRCodeBitmapImage(picbox1.Image as Bitmap));
                //BarcodeReader barcodeReader = new BarcodeReader();
                //Result result = barcodeReader.Decode((Bitmap)picbox1.Image);
                //try
                //{
                //    string decoded = result.ToString().Trim();
                //    if (result != null)
                //    {
                //        textBox1.Text = result.ToString();
                //    }
                //}
                //catch(Exception ex)
                //{
                //}
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            //SavingScannedQR();
        }
        
        //barcode encode
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox2.Image = barcode.Draw(textBox3.Text, 100);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            SavingScannedQR();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startpage st = new startpage();
            st.Show();
            this.Hide();
        }
        //other method
        private void CaptureQR()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                comboBox1.Items.Add(Device.Name);

            comboBox1.SelectedIndex = -1;
            FinalFrame = new VideoCaptureDevice();
        }
        private void otherStart()
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picbox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //Scan Camera QR.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string remark, data1, existing1, existing2;
        private void SavingScannedQR()
        {
            //string emp_id = textBox1.Text();
            string emp_id = textBox2.Text;
            var id1 = DateTime.Now.ToString("MMddHHmmss");
            //string timeStamp = GetTimestamp(DateTime.Now);

            DataTable dt = Employee.GetData("SELECT* FROM tblemployee_attendance WHERE Employee_id ='" + emp_id + "'");
            if (dt.Rows.Count > 0)
            {
                data1 = dt.Rows[0].Field<string>("Num_Days_Present");
                attenDays = Int32.Parse(data1);
            }
            //avoid double
            DataTable dt2 = Employee.GetData("SELECT* FROM tbl_am WHERE Employee_id ='" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'");
            if (dt2.Rows.Count > 0)
            {
                existing1 = "True";
            }
            else if (dt2.Rows.Count <=0 )
            {
                existing1 = "False";
            }

            DataTable dt3 = Employee.GetData("SELECT* FROM tbl_pm WHERE Employee_id ='" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'");
            if (dt3.Rows.Count > 0)
            {
                existing2 = "True";
            }
            else if (dt3.Rows.Count <= 0)
            {
                existing2 = "False";
            }

            
            //MORNING ATTENDANCE
            if (DateTime.Now.ToString("tt") == "AM")
            { 
                int d1 = Int32.Parse(DateTime.Now.ToString("HHmm"));
                
                //Time in
                if(d1 >= 0800 || d1 <= 0830)
                {
                    if (d1 <= 0800)
                    {
                        remark = "On-Time";
                    }
                    else if (d1 >= 0900)
                    {
                        remark = "Late";
                    }

                    if (existing1 != "True")
                    {
                        //Morning
                        Employee.executeSQL("INSERT INTO tbl_am (`id`,`Employee_ID`, `Time_IN`, `Date`, `Remark`) VALUES ('"+id1+"','" + emp_id + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + remark + "' )");
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
                            MessageBox.Show("Updated Days Present!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Attendance Already Recorded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                //Time out
                else if (d1 >= 1200 || d1 <= 1230)
                {
                    //Afternoon
                    Employee.executeSQL("UPDATE tb_am SET Time_OUT = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Employee_ID = '" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "')");
                    if (Employee.rowAffected > 0)
                    {
                        MessageBox.Show("Time Out Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Hide();
                    }
                }
            }
            //AFTERNOON ATTENDANCE
            else if (DateTime.Now.ToString("tt") == "PM")
            {
                int d1 = Int32.Parse(DateTime.Now.ToString("HHmm"));

                //detect if time in or time out
                //time in
                if(d1 >= 1250 || d1 <= 1310)
                {
                    if (d1 <= 1300)
                    {
                        remark = "On-Time";
                    }
                    else if (d1 > 1300)
                    {
                        remark = "Late";
                    }

                    if (existing2 == "False")
                    {
                        //Afternoon
                        Employee.executeSQL("INSERT INTO tbl_pm (`id`, `Employee_ID`, `Time_IN`, `Date`, `Remark`) VALUES ('"+ id1 +"','" + emp_id + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + remark + "' )");
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
                            MessageBox.Show("Updated Days Present!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Attendance Already Recorded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                //time out
                else if(d1 >= 1650 || d1 <= 1710)
                {
                
                    //Afternoon
                    Employee.executeSQL("UPDATE tb_pm SET Time_OUT = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Employee_ID = '" + emp_id + "' AND Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "')");
                    if (Employee.rowAffected > 0)
                    {
                        MessageBox.Show("Time Out Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Hide();
                    }
                }
            }
        }
    }
}
