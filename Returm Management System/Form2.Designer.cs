namespace Returm_Management_System
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enterReturnNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertANoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeANoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.step3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.step4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceSearchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterReturnNoteToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enterReturnNoteToolStripMenuItem
            // 
            this.enterReturnNoteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertANoteToolStripMenuItem,
            this.completeANoteToolStripMenuItem,
            this.step3ToolStripMenuItem,
            this.step4ToolStripMenuItem});
            this.enterReturnNoteToolStripMenuItem.Name = "enterReturnNoteToolStripMenuItem";
            this.enterReturnNoteToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.enterReturnNoteToolStripMenuItem.Text = "Insert";
            this.enterReturnNoteToolStripMenuItem.Click += new System.EventHandler(this.enterReturnNoteToolStripMenuItem_Click);
            // 
            // insertANoteToolStripMenuItem
            // 
            this.insertANoteToolStripMenuItem.Name = "insertANoteToolStripMenuItem";
            this.insertANoteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.insertANoteToolStripMenuItem.Text = "TOG Details";
            this.insertANoteToolStripMenuItem.Click += new System.EventHandler(this.insertANoteToolStripMenuItem_Click);
            // 
            // completeANoteToolStripMenuItem
            // 
            this.completeANoteToolStripMenuItem.Name = "completeANoteToolStripMenuItem";
            this.completeANoteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.completeANoteToolStripMenuItem.Text = "Return Note Details";
            this.completeANoteToolStripMenuItem.Click += new System.EventHandler(this.completeANoteToolStripMenuItem_Click);
            // 
            // step3ToolStripMenuItem
            // 
            this.step3ToolStripMenuItem.Name = "step3ToolStripMenuItem";
            this.step3ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.step3ToolStripMenuItem.Text = "Receiver Details";
            this.step3ToolStripMenuItem.Click += new System.EventHandler(this.step3ToolStripMenuItem_Click);
            // 
            // step4ToolStripMenuItem
            // 
            this.step4ToolStripMenuItem.Name = "step4ToolStripMenuItem";
            this.step4ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.step4ToolStripMenuItem.Text = "Complete Return note";
            this.step4ToolStripMenuItem.Click += new System.EventHandler(this.step4ToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewNotesToolStripMenuItem,
            this.advanceSearchToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.viewToolStripMenuItem.Text = "View ";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // viewNotesToolStripMenuItem
            // 
            this.viewNotesToolStripMenuItem.Name = "viewNotesToolStripMenuItem";
            this.viewNotesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.viewNotesToolStripMenuItem.Text = "View Notes";
            this.viewNotesToolStripMenuItem.Click += new System.EventHandler(this.viewNotesToolStripMenuItem_Click);
            // 
            // advanceSearchToolStripMenuItem1
            // 
            this.advanceSearchToolStripMenuItem1.Name = "advanceSearchToolStripMenuItem1";
            this.advanceSearchToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.advanceSearchToolStripMenuItem1.Text = "Advance Search";
            this.advanceSearchToolStripMenuItem1.Click += new System.EventHandler(this.advanceSearchToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Returm_Management_System.Properties.Resources.wtiopz;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Return Manage System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enterReturnNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertANoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeANoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceSearchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem step3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem step4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
    }
}