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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection (ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

        String us, pw, user;

        public Form1()
        {
            InitializeComponent();
        }

        private void userNameEnter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userName_Leave(object sender, EventArgs e)
        {
            
        }

        private void passWord_Enter(object sender, EventArgs e)
        {
            
        }

        private void passWord_Leave(object sender, EventArgs e)
        {
            
        }

        private void passWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logIn.Focus();
            }
        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passWord.Focus();
            }
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            
            us = userName.Text.ToString();
            pw = passWord.Text.ToString();

            con.Open();

            String query = "SELECT * FROM [user] WHERE userName = '" + us + "' AND password = '" + pw + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                user = us;

                Form2 main = new Form2(user);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password !");
                userName.Text = "";
                passWord.Text = "";

                userName.Focus();
            }

            con.Close();

            /*Form2 pos = new Form2(user);
            pos.Show();
            this.Hide();*/

        }
    }
}
