using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Returm_Management_System
{
    public partial class Form2 : Form
    {
        String user;
        view v1;
        enterNote enter;
        find find;
        completeNote cn;
        public Form2(String user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void enterReturnNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //v1.Hide();
            
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //enter.Hide();
            
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void advanceSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void insertANoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enter = new enterNote(user);

            enter.MdiParent = this;
            enter.Dock = DockStyle.Fill;
            enter.Show();
        }

        private void completeANoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn = new completeNote();

            cn.MdiParent = this;
            cn.Dock = DockStyle.Fill;
            cn.Show();
        }

        private void viewNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1 = new view();

            v1.MdiParent = this;
            v1.Dock = DockStyle.Fill;
            v1.Show();
        }

        private void advanceSearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            find = new find();

            find.MdiParent = this;
            find.Dock = DockStyle.Fill;
            find.Show();
        }

        private void step3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            step3 s3 = new step3();

            s3.MdiParent = this;
            s3.Dock = DockStyle.Fill;
            s3.Show();
        }

        private void step4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            step4 s4 = new step4();

            s4.MdiParent = this;
            s4.Dock = DockStyle.Fill;
            s4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUser cu = new createUser();
            cu.MdiParent = this;
            cu.Dock = DockStyle.Fill;
            cu.Show();
        }
    }
}
