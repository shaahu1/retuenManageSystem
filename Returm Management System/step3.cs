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
    public partial class step3 : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=SHAAHU;Initial Catalog=returnSystem;Integrated Security=True");
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

        String state;

        public step3()
        {
            InitializeComponent();
        }

        private void step3_Load(object sender, EventArgs e)
        {

        }

        private void noteNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (noteNo.Text != "")
                {
                    String noteNOValue = noteNo.Text.ToString();

                    con.Open();

                    //MessageBox.Show("" + noteNOValue);

                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM tblNote WHERE returnNoteNo = '" + noteNOValue + "'", con);
                    SqlDataReader read = cmd1.ExecuteReader();

                    if (read.Read())
                    {
                        lblTogNo.Text = "TOG No - " + read.GetString(1);
                        lblLocation.Text = "Location - " + read.GetString(3);
                        lblSupplier.Text = "Supplier - " + read.GetString(2);
                        state = read.GetString(9);

                        if (state == "step 2")
                        {
                            receivedBy.Focus();
                        }
                        else if (state == "step 1")
                        {
                            MessageBox.Show("This note is step 1 !");
                            noteNo.Text = "";
                        }
                        else if (state == "step 3")
                        {
                            MessageBox.Show("This note is alrady complete this step !");
                            noteNo.Text = "";
                        }
                        else if (state == "step 4")
                        {
                            MessageBox.Show("This note is completed");
                            noteNo.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Note Number !");
                        noteNo.Text = "";
                    }

                    con.Close();

                }
                else
                {
                    noteNo.Focus();
                }

                
            }
        }

        private void receivedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (receivedBy.Text != "")
                {
                    date.Focus();
                }
                else
                {
                    MessageBox.Show("Fill the receiver name!");
                }
                
            }
        }

        private void date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        public void save()
        {

            String noteNoValue = noteNo.Text.ToString();
            String receivedByValue = receivedBy.Text.ToString();
            String dateValue = date.Value.ToShortDateString();

            if (noteNoValue != "" && receivedByValue != "" && state == "step 2")
            {


                //SqlCommand cmd2 = new SqlCommand("UPDATE tblNote SET dateOfHandover = '" + dateValue + "', receivedBy = '" + receivedByValue + "', state = 'step 3' WHERE retuenNoteNo = '" + noteNoValue + "' AND state = 'step 2' ", conn);

                SqlCommand cmd2 = new SqlCommand("insertStep3",con); 
                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.AddWithValue("@dateValue", dateValue);
                cmd2.Parameters.AddWithValue("@receivedByValue", receivedByValue);
                cmd2.Parameters.AddWithValue("@noteNoValue", noteNoValue);

                con.Open();

                if (cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Save");
                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }

                noteNo.Text = "";
                receivedBy.Text = "";
                lblLocation.Text = "";
                lblSupplier.Text = "";
                lblTogNo.Text = "";

                con.Close();
            }
            else
            {
                MessageBox.Show("Some fields are empty!");
            }
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save();
            }
        }
    }
}
