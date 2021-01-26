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

namespace Returm_Management_System
{
    public partial class find : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SHAAHU;Initial Catalog=rmsDatabase;Integrated Security=True");
        int icolumn = 0;
        int columnindex = 0;

        public find()
        {
            InitializeComponent();
        }

        private void noteNo_Enter(object sender, EventArgs e)
        {
            if (noteNo.Text == "Note No")
            {
                noteNo.Text = "";
                noteNo.ForeColor = Color.Black;
            }
        }

        private void noteNo_Leave(object sender, EventArgs e)
        {
            if (noteNo.Text == "")
            {
                noteNo.Text = "Note No";
                noteNo.ForeColor = Color.DimGray;
            }
        }

        private void supplier_Enter(object sender, EventArgs e)
        {
            if (supplier.Text == "Supplier Name")
            {
                supplier.Text = "";
                supplier.ForeColor = Color.Black;
            }
        }

        private void supplier_Leave(object sender, EventArgs e)
        {
            if (supplier.Text == "")
            {
                supplier.Text = "Supplier Name";
                supplier.ForeColor = Color.DimGray;
            }
        }

        

        

        private void date_Enter(object sender, EventArgs e)
        {
            if (date.Text == "Date")
            {
                date.Text = "";
                date.ForeColor = Color.Black;
            }
        }

        private void date_Leave(object sender, EventArgs e)
        {
            if (date.Text == "")
            {
                date.Text = "Date";
                date.ForeColor = Color.DimGray;
            }
        }

        

        private void find_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Gill Sans MT", 11);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Eras Demi ITC", 14);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String noteNoData = noteNo.Text;
            String supplierData = supplier.Text;
            String fromData = from.Text;
            String dateData = date.Text;

            String[] variables = { noteNoData, supplierData, fromData, dateData };
            String[] lableHint = { "Note No", "Supplier Name", "From", "Date" };

            for (int i = 0; 4>i; i++)
            {
                if (variables[i] == lableHint[i])
                {
                    variables[i] = "";
                }
            }

            String[] lables = { "noteNo", "supplier", "shop", "date" };

            String[] variablesData = new String[4];
            String[] lablesData = new String[4];

            int index = 0, count = 0;

            for (int i = 0; 4 > i; i++)
            {
                if (variables[i] != "")
                {
                    count += 1;
                    variablesData[index] = variables[i];
                    lablesData[index] = lables[i];
                    index += 1;
                }
            }

            if (count == 1)
            {
                String query = "Select * From noteInfo  WHERE " + lablesData[0] + " LIKE '%" + variablesData[0] + "%' ORDER BY id DESC ";
                find(query);
            }

            if (count == 2)
            {
                String query = "Select * From noteInfo  WHERE " + lablesData[0] + " LIKE '%" + variablesData[0] + "%' AND " + lablesData[1] + " LIKE '%" + variablesData[1] + "%'  ORDER BY id DESC ";
                find(query);
            }

            if (count == 3)
            {
                String query = "Select * From noteInfo  WHERE " + lablesData[0] + " LIKE '%" + variablesData[0] + "%' AND " + lablesData[1] + " LIKE '%" + variablesData[1] + "%' AND " + lablesData[2] + " LIKE '%" + variablesData[2] + "%'  ORDER BY id DESC ";
                find(query);
            }

            if (count == 4)
            {
                String query = "Select * From noteTbl  WHERE " + lablesData[0] + " LIKE '" + variablesData[0] + "' AND " + lablesData[1] + " LIKE '%" + variablesData[1] + "%' AND " + lablesData[2] + " LIKE '%" + variablesData[2] + "%' AND " + lablesData[3] + " LIKE '%" + variablesData[3] + "%'  ORDER BY id DESC ";
                find(query);
            }
            if (count < 1 && count > 4 )
            {
                MessageBox.Show("No any input(s) !");
            }


            void find (String query)
            {
                dataGridView1.Rows.Clear();

                conn.Open();

                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader read = cmd.ExecuteReader();

                for (int i = 0; read.Read(); i++)
                {
                    dataGridView1.Rows.Add();

                    dataGridView1.Rows[i].Cells[0].Value = read.GetString(0);
                    dataGridView1.Rows[i].Cells[1].Value = read.GetString(1);
                    dataGridView1.Rows[i].Cells[2].Value = read.GetString(2);
                    dataGridView1.Rows[i].Cells[3].Value = read.GetString(3);
                    dataGridView1.Rows[i].Cells[4].Value = read.GetString(4);
                    dataGridView1.Rows[i].Cells[5].Value = read.GetString(5);
                    dataGridView1.Rows[i].Cells[6].Value = read.GetString(6);
                    dataGridView1.Rows[i].Cells[7].Value = read.GetString(7);
                    dataGridView1.Rows[i].Cells[8].Value = read.GetString(8);

                }

                conn.Close();
            }

            /*{
                MessageBox.Show("No input(s) to Find !");
            }*/
        }

        private void from_Leave_1(object sender, EventArgs e)
        {

        }

        private void from_Enter(object sender, EventArgs e)
        {

            if (from.Text == "From")
            {
                from.Text = "";
                from.ForeColor = Color.Black;
            }
        }

        private void from_Leave(object sender, EventArgs e)
        {
            if (from.Text == "")
            {
                from.Text = "From";
                from.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            icolumn = dataGridView1.CurrentCell.ColumnIndex;
            MessageBox.Show("" + icolumn);
            columnindex = icolumn;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //icolumn = dataGridView1.CurrentCell.ColumnIndex;
        }

        
    }
}
