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
    public partial class completeNote : Form
    {

        //SqlConnection conn = new SqlConnection(@"Data Source=SHAAHU;Initial Catalog=returnSystem;Integrated Security=True");
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        int state = 0;

        public completeNote()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String noteNoValue = noteNo.Text.ToString();

                if (noteNoValue != "")
                {
                    location.Focus();
                }

            }

            

        }

        

        private void noteNo_Leave(object sender, EventArgs e)
        {

            
        }

        private void tital_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
            update();
        }

        public void showDetails()
        {
            String noteNoValue = noteNo.Text.ToString();
            String locationValue = location.Text.ToString();

            //MessageBox.Show("55" + locationValue + "55");

            conn.Open();

            SqlCommand cmd2 = new SqlCommand("step2Check1", conn);
            cmd2.CommandType = CommandType.StoredProcedure;

            cmd2.Parameters.AddWithValue("@noteNoValue", noteNoValue);
            cmd2.Parameters.AddWithValue("@locationValue", locationValue);

            SqlDataReader read = cmd2.ExecuteReader();
            if (read.Read())
            {
                lblSupplier.Text = read.GetString(2
                    );
                string state = read.GetString(9);


                if (state == "step 1")
                {
                    returnNoteNo.Focus();
                }
                else if (state == "step 2" || state == "step 3" || state == "step 4")
                {
                    MessageBox.Show("This TOG has a return note!");
                    noteNo.Text = "";
                    location.Text = "";
                    lblSupplier.Text = "-----";
                    noteNo.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Invalide Note Number or Location !");
                lblSupplier.Text = "-----";
                location.Text = "";
                noteNo.Text = "";
            }

            conn.Close();
        }

        public void update()
        {
            String noteNoValue = noteNo.Text.ToString();
            String returnNoteValue = returnNoteNo.Text.ToString();
            String dateValue = dateOfNote.Value.ToShortDateString();
            String locationValue = location.Text.ToString();

            if (state == 0)
            {
                if (noteNoValue != "")
                {
                    

                    /*String query = "UPDATE tblNote SET retuenNoteNo = '" + returnNoteValue + "' , dateOfReturnNote = '" + dateValue + "' ,state = 'step 2' WHERE togNo = '" + noteNoValue + "' AND state = 'step 1' AND location = '" + locationValue + "' ";
                    */
                    SqlCommand cmd = new SqlCommand("insertStep2", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@returnNoteValue", returnNoteValue);
                    cmd.Parameters.AddWithValue("@dateValue", dateValue);
                    cmd.Parameters.AddWithValue("@noteNoValue", noteNoValue);
                    cmd.Parameters.AddWithValue("@locationValue", locationValue);
                    

                    conn.Open();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Successful!");
                    }
                    else
                    {
                        MessageBox.Show("This note has already completed !");
                    }

                    conn.Close();
                }
            }

            noteNo.Text = "";
            location.Text = "";
            lblSupplier.Text = "-----";
            returnNoteNo.Text = "";
            noteNo.Focus();
        }

        private void location_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (location.Text.ToString() != "")
                {
                    showDetails();
                }
                
            }
        }

        private void retuenNoteNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String retuenNoteNoValue = returnNoteNo.Text.ToString();

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblNote WHERE returnNoteNo = '" + retuenNoteNoValue + "' ", conn);
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    MessageBox.Show("Invalid Return Note Number!");
                    returnNoteNo.Text = "";
                }
                else
                {
                    dateOfNote.Focus();
                }
                conn.Close();
                
            }
        }

        private void dateOfNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnComplete.Focus();
            }
        }

        private void btnComplete_KeyDown(object sender, KeyEventArgs e)
        {
            update();
        }

        private void tital_Click_1(object sender, EventArgs e)
        {

        }

        private void location_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
