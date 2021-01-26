using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Returm_Management_System
{
    public partial class enterNote : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=SHAAHU;Initial Catalog=returnSystem;Integrated Security=True");
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        String user;

        //DateTime today = DateTime.Now;
        String today = DateTime.Now.ToString("M/d/yyyy");
        

        public enterNote(String user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void enterNote_Load(object sender, EventArgs e)
        {

            lbl_userValue.Text = user;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_supplier_Click(object sender, EventArgs e)
        {

        }

        private void lbl_from_Click(object sender, EventArgs e)
        {

        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void lbl_reason_Click(object sender, EventArgs e)
        {

        }

        private void lbl_noteNo_Click(object sender, EventArgs e)
        {

        }

        private void noteNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void noteNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                supplier.Focus();
            }
        }

        private void supplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                location.Focus();
            }
        }

        

        private void dateOfNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                reason.Focus();
            }
        }

        private void reason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveButton.Focus();
            }
        }

       

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void supplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void supplier_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                location.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void from_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                returnBy.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void returnBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateOfNote.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
                       

            String togNoValue = togNo.Text.ToString();
            String supplierValue = supplier.Text.ToString();
            String locationValue = location.Text.ToString();
            String returnByValue = returnBy.Text.ToString();
            String togDateValue = dateOfNote.Value.ToShortDateString();
            String discriptionValue = reason.Text.ToString();
            String state = "step 1";

            String cateValue = "";
            
            if (reason1.Checked)
            {
                cateValue = "1";
            }
            else if (reason2.Checked)
            {
                cateValue = "2";
            }
            else if (reason3.Checked)
            {
                cateValue = "3";
            }
            else if (reason4.Checked)
            {
                cateValue = "4";
            }
            else if (reason5.Checked)
            {
                cateValue = "5";
            }
            else if (reason6.Checked)
            {
                cateValue = "6";
            }

            if ( togNoValue != "" && supplierValue != "" && locationValue != "" && returnByValue != "" && ( cateValue != "" || discriptionValue != ""))
            {

                using (con)
                {
                    SqlCommand cmd = new SqlCommand("insertstep1", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    cmd.Parameters.AddWithValue("@togNoValue", togNoValue);
                    cmd.Parameters.AddWithValue("@supplierValue", supplierValue);
                    cmd.Parameters.AddWithValue("@locationValue", locationValue);
                    cmd.Parameters.AddWithValue("@returnByValue", returnByValue);
                    cmd.Parameters.AddWithValue("@togDateValue", togDateValue);
                    cmd.Parameters.AddWithValue("@cateValue", cateValue);
                    cmd.Parameters.AddWithValue("@discriptionValue", discriptionValue);
                    cmd.Parameters.AddWithValue("@today", today);
                    cmd.Parameters.AddWithValue("@state", state);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Note Added!");
                    }
                    else
                    {
                        MessageBox.Show("Insert Unsuccessful !");
                    }

                    togNo.Text = "";
                    supplier.Text = "";
                    location.Text = "";
                    dateOfNote.Text = "";
                    reason.Text = "";
                    returnBy.Text = "";
                    reason1.Checked = false;
                    reason2.Checked = false;
                    reason3.Checked = false;
                    reason4.Checked = false;
                    reason5.Checked = false;

                    con.Close();

                    togNo.Focus();
                }

                //con.Open();

                /*String quary = "INSERT INTO tblNote Values " +
                    "('" + togNoValue + "', '" + locationValue  + "', '" + supplierValue + "', '" + returnByValue + "' , '" + togDateValue + "', '" + cateValue + "' , '" + discriptionValue + "', '" + today + "' , '" + state + "' , '---' , '---' , '---' , '---' , '---' , '---'  )";
                SqlCommand cmd = new SqlCommand(quary, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Note Added!");
                }
                else
                {
                    MessageBox.Show("Insert Unsuccessful !");
                }

                togNo.Text = "";
                supplier.Text = "";
                location.Text = "";
                dateOfNote.Text = "";
                reason.Text = "";
                returnBy.Text = "";
                reason1.Checked = false;
                reason2.Checked = false;
                reason3.Checked = false;
                reason4.Checked = false;
                reason5.Checked = false;

                conn.Close();

                togNo.Focus();*/
            }
            else
            {
                MessageBox.Show("Some fields are Empty !");
            }


        }
    }
}
