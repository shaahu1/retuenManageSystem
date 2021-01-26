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
    public partial class step4 : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=SHAAHU;Initial Catalog=returnSystem;Integrated Security=True");
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

        String state;

        public step4()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateOfNote_ValueChanged(object sender, EventArgs e)
        {

        }

        private void returnNoteNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String noteNoValue = noteNo.Text.ToString();

                con.Open();

                SqlCommand cmd1 = new SqlCommand("SELECT * FROM tblNote WHERE returnNoteNo = '" + noteNoValue + "' ",con);
                SqlDataReader read = cmd1.ExecuteReader();

                if (read.Read())
                {
                    state = read.GetString(9);
                    if (state == "step 3")
                    {
                        name.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Incomplete Note");
                        noteNo.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Note Number!");
                    noteNo.Text = "";
                }
                con.Close();
            }
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String nameValue = name.Text.ToString();

                if (nameValue != "")
                {
                    date.Focus();
                }
            }
        }

        private void date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnComplete.Focus();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            complete();
        }

        public void complete()
        {
            if (state == "step 3")
            {
                String noteNoValue = noteNo.Text.ToString();
                String nameValue = name.Text.ToString();
                String dateValue = date.Value.ToShortDateString();

                //SqlCommand cmd2 = new SqlCommand("UPDATE tblNote SET givenDateAccount = '" + dateValue + "' , nameOfAccountant = '" + nameValue + "' , state = 'Complete' WHERE retuenNoteNo = '" + noteNoValue + "'", conn);
                SqlCommand cmd2 = new SqlCommand("insertStep4", con);
                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.AddWithValue("@dateValue", dateValue);
                cmd2.Parameters.AddWithValue("@nameValue", nameValue);
                cmd2.Parameters.AddWithValue("@noteNoValue", noteNoValue);
                con.Open();

                if (cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Save!");
                }
                else
                {
                    MessageBox.Show("Incomplete!");
                }
                con.Close();

                noteNo.Text = "";
                name.Text = "";
                noteNo.Focus();
            }
        }

        private void btnComplete_KeyDown(object sender, KeyEventArgs e)
        {
            complete();
        }
    }
}
