using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace QR_Attendance_System
{
    public partial class frm_accountList : Form
    {
        String logged_id;
        public frm_accountList(string logged_id)
        {
            InitializeComponent();
            this.logged_id = logged_id;
        }
        Class1 Employee = new Class1("127.0.0.1", "qronos", "root", "");

        //Filter 
        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_filter.SelectedIndex == 0)
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

        //exit
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //this page reload when shown
        private void frm_accountList_Shown(object sender, EventArgs e)
        {
            DataTable dt = Employee.GetData("SELECT * FROM tblemployee");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
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
            }

            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //View the selected cell
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (select_iD == "")
                {
                    MessageBox.Show("Select Employee to view!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {   
                    frm_view main1 = new frm_view(select_iD, logged_id);
                    main1.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //edit the selected cell
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (select_iD == "")
                {
                    MessageBox.Show("Select Employee to view!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //code for editing the employee
                    //MessageBox.Show(select_iD + " will be edited!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_editEmployee edit = new frm_editEmployee(select_iD);
                    edit.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete the selected cell
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt1 = Employee.GetData("SELECT* FROM tbl_am WHERE Employee_ID ='" + select_iD + "'");
                if (dt1.Rows.Count > 0)
                {
                    
                }
                DataTable dt2 = Employee.GetData("SELECT* FROM tbl_pm' WHERE Employee_ID ='" + select_iD + "'");
                if (dt2.Rows.Count > 0)
                {
                    
                }

                if (select_iD == "")
                {
                    MessageBox.Show("Select Account to Delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this record?", 
                        "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        if(select_iD == logged_id)
                        {
                            MessageBox.Show("Cannot Delete Logged Account", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Employee.executeSQL("DELETE FROM tblemployee WHERE Employee_ID = '" + select_iD + "'");
                            Employee.executeSQL("DELETE FROM tblemployee_attendance WHERE Employee_ID = '" + select_iD + "'");
                            //Employee.executeSQL("DELETE FROM tbl_am WHERE Employee_ID = '" + select_iD + "'");
                            //Employee.executeSQL("DELETE FROM tbl_pm WHERE Employee_ID = '" + select_iD + "'");
                            if (Employee.rowAffected > 0)
                            {
                                MessageBox.Show("Account Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frm_accountList_Shown(this, e);
                                //log

                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_filterID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Employee.GetData("SELECT * FROM tblemployee WHERE Employee_ID like '%" + txt_filterID.Text + "%'");
                dataGridView1.DataSource = dt;
            }

            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_filterName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Employee.GetData("SELECT * FROM tblemployee WHERE Name like '%" + txt_filterName.Text + "%'");
                dataGridView1.DataSource = dt;
            }

            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //reset display
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            cmb_filter.SelectedIndex = -1;
            txt_filterID.Visible = false;
            txt_filterName.Visible = false;
            frm_accountList_Activated(this, e);
        }

        private void frm_accountList_Activated(object sender, EventArgs e)
        {

            DataTable dt = Employee.GetData("SELECT * FROM tblemployee");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        string qrLoc;
        private void btnQr_Click(object sender, EventArgs e)
        {
            try
            {
                if (select_iD == "")
                {
                    MessageBox.Show("Select Employee to Generate QRCode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("QRCode Generated, Do you wish to save the QRCode?",
                        "Save QRCode", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                                encoder.QRCodeScale = 8;
                                Bitmap bmp = encoder.Encode(select_iD);
                                bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                                qrLoc = sfd.FileName;
                                qrLoc = qrLoc.Replace("\\", "\\\\");

                                Employee.executeSQL("UPDATE tblemployee SET QR_Code = '" + qrLoc + "' WHERE Employee_ID = '" + select_iD + "'");
                                if (Employee.rowAffected > 0)
                                {
                                    MessageBox.Show("QR Code Generated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //this.Hide();
                                }
                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //public static byte[] GetHash(string inputString)
        //{
        //    using (HashAlgorithm algorithm = SHA256.Create())
        //        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        //}

        //public static string GetHashString(string inputString)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (byte b in GetHash(inputString))
        //        sb.Append(b.ToString("X2"));

        //    return sb.ToString();
        //}
    }
}
