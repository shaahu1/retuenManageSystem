namespace Returm_Management_System
{
    partial class step4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(step4));
            this.tital = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.noteNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnComplete = new FlatButton.JFlatButton();
            this.SuspendLayout();
            // 
            // tital
            // 
            this.tital.AutoSize = true;
            this.tital.BackColor = System.Drawing.Color.Transparent;
            this.tital.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tital.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tital.Location = new System.Drawing.Point(88, 57);
            this.tital.Name = "tital";
            this.tital.Size = new System.Drawing.Size(212, 22);
            this.tital.TabIndex = 5;
            this.tital.Text = "Complete Return Note";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(174, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Retuen Note No :";
            // 
            // noteNo
            // 
            this.noteNo.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.noteNo.Location = new System.Drawing.Point(359, 166);
            this.noteNo.Name = "noteNo";
            this.noteNo.Size = new System.Drawing.Size(125, 22);
            this.noteNo.TabIndex = 19;
            this.noteNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.returnNoteNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(174, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Received By (Account) :";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.name.Location = new System.Drawing.Point(359, 257);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 22);
            this.name.TabIndex = 21;
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_KeyDown);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(359, 339);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 24;
            this.date.ValueChanged += new System.EventHandler(this.dateOfNote_ValueChanged);
            this.date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(174, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnComplete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnComplete.ButtonText = "  Save";
            this.btnComplete.CausesValidation = false;
            this.btnComplete.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnComplete.ErrorImageLeft")));
            this.btnComplete.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnComplete.ErrorImageRight")));
            this.btnComplete.FocusBackground = System.Drawing.Color.Empty;
            this.btnComplete.FocusFontColor = System.Drawing.Color.Empty;
            this.btnComplete.ForeColors = System.Drawing.Color.White;
            this.btnComplete.HoverBackground = System.Drawing.Color.Empty;
            this.btnComplete.HoverFontColor = System.Drawing.Color.Empty;
            this.btnComplete.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnComplete.ImageLeft")));
            this.btnComplete.ImageRight = null;
            this.btnComplete.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnComplete.Location = new System.Drawing.Point(359, 452);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnComplete.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnComplete.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnComplete.Size = new System.Drawing.Size(147, 43);
            this.btnComplete.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnComplete.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnComplete.TabIndex = 25;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            this.btnComplete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnComplete_KeyDown);
            // 
            // step4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Returm_Management_System.Properties.Resources.wtiopz;
            this.ClientSize = new System.Drawing.Size(1253, 588);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.noteNo);
            this.Controls.Add(this.tital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "step4";
            this.Text = "step4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tital;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox noteNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label7;
        private FlatButton.JFlatButton btnComplete;
    }
}