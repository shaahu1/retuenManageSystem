namespace Returm_Management_System
{
    partial class completeNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(completeNote));
            this.noteNo = new System.Windows.Forms.TextBox();
            this.lbl_noteNo = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.tital = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.ComboBox();
            this.returnNoteNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOfNote = new System.Windows.Forms.DateTimePicker();
            this.btnComplete = new FlatButton.JFlatButton();
            this.SuspendLayout();
            // 
            // noteNo
            // 
            this.noteNo.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.noteNo.Location = new System.Drawing.Point(316, 156);
            this.noteNo.Name = "noteNo";
            this.noteNo.Size = new System.Drawing.Size(125, 22);
            this.noteNo.TabIndex = 0;
            this.noteNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.noteNo.Leave += new System.EventHandler(this.noteNo_Leave);
            // 
            // lbl_noteNo
            // 
            this.lbl_noteNo.AutoSize = true;
            this.lbl_noteNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_noteNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noteNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_noteNo.Location = new System.Drawing.Point(210, 158);
            this.lbl_noteNo.Name = "lbl_noteNo";
            this.lbl_noteNo.Size = new System.Drawing.Size(74, 18);
            this.lbl_noteNo.TabIndex = 2;
            this.lbl_noteNo.Text = "TOG No :";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblSupplier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSupplier.Location = new System.Drawing.Point(319, 280);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(33, 17);
            this.lblSupplier.TabIndex = 6;
            this.lblSupplier.Text = "-----";
            // 
            // tital
            // 
            this.tital.AutoSize = true;
            this.tital.BackColor = System.Drawing.Color.Transparent;
            this.tital.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tital.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tital.Location = new System.Drawing.Point(68, 65);
            this.tital.Name = "tital";
            this.tital.Size = new System.Drawing.Size(187, 22);
            this.tital.TabIndex = 4;
            this.tital.Text = "Return Note Details";
            this.tital.Click += new System.EventHandler(this.tital_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(210, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Supplier :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(210, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Location :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // location
            // 
            this.location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.location.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.location.FormattingEnabled = true;
            this.location.Items.AddRange(new object[] {
            "G1",
            "G2",
            "G3",
            "NB",
            "KW",
            "KPY",
            "HO"});
            this.location.Location = new System.Drawing.Point(316, 213);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(125, 24);
            this.location.TabIndex = 16;
            this.location.SelectedIndexChanged += new System.EventHandler(this.location_SelectedIndexChanged);
            this.location.KeyDown += new System.Windows.Forms.KeyEventHandler(this.location_KeyDown);
            // 
            // returnNoteNo
            // 
            this.returnNoteNo.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.returnNoteNo.Location = new System.Drawing.Point(385, 333);
            this.returnNoteNo.Name = "returnNoteNo";
            this.returnNoteNo.Size = new System.Drawing.Size(125, 22);
            this.returnNoteNo.TabIndex = 17;
            this.returnNoteNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.retuenNoteNo_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(210, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Retuen Note No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(210, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Date of Rerurn Note :";
            // 
            // dateOfNote
            // 
            this.dateOfNote.Location = new System.Drawing.Point(385, 386);
            this.dateOfNote.Name = "dateOfNote";
            this.dateOfNote.Size = new System.Drawing.Size(200, 20);
            this.dateOfNote.TabIndex = 20;
            this.dateOfNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateOfNote_KeyDown);
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
            this.btnComplete.Location = new System.Drawing.Point(345, 476);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnComplete.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnComplete.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnComplete.Size = new System.Drawing.Size(147, 43);
            this.btnComplete.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnComplete.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnComplete.TabIndex = 21;
            this.btnComplete.Click += new System.EventHandler(this.jFlatButton1_Click);
            this.btnComplete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnComplete_KeyDown);
            // 
            // completeNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1175, 614);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.dateOfNote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.returnNoteNo);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.tital);
            this.Controls.Add(this.lbl_noteNo);
            this.Controls.Add(this.noteNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "completeNote";
            this.Text = "completeNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noteNo;
        private System.Windows.Forms.Label lbl_noteNo;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label tital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.TextBox returnNoteNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateOfNote;
        private FlatButton.JFlatButton btnComplete;
    }
}