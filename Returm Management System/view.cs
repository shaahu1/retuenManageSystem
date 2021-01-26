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
    public partial class view : Form
    {

        //SqlConnection conn = new SqlConnection(@"Data Source=SHAAHU;Initial Catalog=returnSystem;Integrated Security=True");
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

        int icolumn = 0;
        int columnindex = 0;

        public view()
        {
            InitializeComponent();
            fill();
        }

      
        private void tital_Click(object sender, EventArgs e)
        {

        }

        public void fill()
        {
            dataGridView1.Rows.Clear();

            conn.Open();
            SqlCommand cmd = new SqlCommand("view1", conn);


            SqlDataReader read = cmd.ExecuteReader();

            fillData(read);

            conn.Close();

            /*conn.Open();

            SqlCommand cmd = new SqlCommand("select * from tblNote ORDER BY id DESC", conn);
            SqlDataReader read = cmd.ExecuteReader();

            fillData(read);

            conn.Close();*/
        }

        public void fillData (SqlDataReader read)
        {
            for (int i = 0; read.Read(); i++)
            {
                dataGridView1.Rows.Add();

                dataGridView1.Rows[i].Cells[0].Value = read.GetString(1);
                dataGridView1.Rows[i].Cells[1].Value = read.GetString(3);
                dataGridView1.Rows[i].Cells[2].Value = read.GetString(2);
                dataGridView1.Rows[i].Cells[3].Value = read.GetString(4);
                dataGridView1.Rows[i].Cells[4].Value = read.GetString(5);
                dataGridView1.Rows[i].Cells[5].Value = read.GetInt32(6);
                dataGridView1.Rows[i].Cells[6].Value = read.GetString(7);
                dataGridView1.Rows[i].Cells[7].Value = read.GetString(8);
                dataGridView1.Rows[i].Cells[8].Value = read.GetString(9);
                dataGridView1.Rows[i].Cells[9].Value = read.GetString(10);
                dataGridView1.Rows[i].Cells[10].Value = read.GetString(11);
                dataGridView1.Rows[i].Cells[11].Value = read.GetString(12);
                dataGridView1.Rows[i].Cells[12].Value = read.GetString(13);
                dataGridView1.Rows[i].Cells[13].Value = read.GetString(14);
                dataGridView1.Rows[i].Cells[14].Value = read.GetString(15);

                

            }
        }




        private void view_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Gill Sans MT", 11);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Eras Demi ITC", 12);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            conn.Open();

            SqlCommand cmd = new SqlCommand("viewStep1", conn);
            SqlDataReader read = cmd.ExecuteReader();

            fillData(read);

            conn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from tblNote WHERE state = 'Complete' ORDER BY id DESC", conn);
            SqlDataReader read = cmd.ExecuteReader();

            fillData(read);

            conn.Close();
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void search_Enter(object sender, EventArgs e)
        {
            icolumn = dataGridView1.CurrentCell.ColumnIndex;
            //MessageBox.Show("" + icolumn);
            columnindex = icolumn;
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //MessageBox.Show("Enter Key Pressed ");
                String[] columns = {"togNo", "location", "supplier", "returnBy" ,"dateOfTog", "category" , "", "" , "state" };
                String query = "";

                

                conn.Open();

                if (columnindex != 6 && columnindex != 7 )
                {
                    dataGridView1.Rows.Clear();
                    query = "SELECT * FROM tblNote WHERE " + columns[columnindex] + " LIKE '%" + search.Text + "%' ORDER BY id DESC ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader read = cmd.ExecuteReader();

                    fillData(read);
                }

                conn.Close();
                search.Text = "";
                
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void step2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            conn.Open();
            SqlCommand cmd = new SqlCommand("viewStep2", conn);
            
            SqlDataReader read = cmd.ExecuteReader();

            fillData(read);

            conn.Close();





        }

        private void step3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            conn.Open();

            SqlCommand cmd = new SqlCommand("viewStep3", conn);
            SqlDataReader read = cmd.ExecuteReader();

            fillData(read);

            conn.Close();
        }
    }
}
