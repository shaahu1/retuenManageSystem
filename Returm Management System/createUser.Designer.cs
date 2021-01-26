
namespace Returm_Management_System
{
    partial class createUser
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
            this.tital = new System.Windows.Forms.Label();
            this.lbl_noteNo = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noteNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tital
            // 
            this.tital.AutoSize = true;
            this.tital.BackColor = System.Drawing.Color.Transparent;
            this.tital.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tital.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tital.Location = new System.Drawing.Point(68, 64);
            this.tital.Name = "tital";
            this.tital.Size = new System.Drawing.Size(119, 22);
            this.tital.TabIndex = 5;
            this.tital.Text = "Create User";
            // 
            // lbl_noteNo
            // 
            this.lbl_noteNo.AutoSize = true;
            this.lbl_noteNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_noteNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noteNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_noteNo.Location = new System.Drawing.Point(137, 166);
            this.lbl_noteNo.Name = "lbl_noteNo";
            this.lbl_noteNo.Size = new System.Drawing.Size(129, 18);
            this.lbl_noteNo.TabIndex = 7;
            this.lbl_noteNo.Text = "Employee Name :";
            // 
            // empName
            // 
            this.empName.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.empName.Location = new System.Drawing.Point(278, 164);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(125, 22);
            this.empName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(137, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Name :";
            // 
            // noteNo
            // 
            this.noteNo.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.noteNo.Location = new System.Drawing.Point(278, 232);
            this.noteNo.Name = "noteNo";
            this.noteNo.Size = new System.Drawing.Size(125, 22);
            this.noteNo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(137, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(278, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(137, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Position :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Employee",
            "Manager"});
            this.comboBox1.Location = new System.Drawing.Point(278, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "---select---";
            // 
            // createUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1070, 582);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteNo);
            this.Controls.Add(this.lbl_noteNo);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.tital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "createUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tital;
        private System.Windows.Forms.Label lbl_noteNo;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noteNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}