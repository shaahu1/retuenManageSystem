namespace Returm_Management_System
{
    partial class enterNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enterNote));
            this.tital = new System.Windows.Forms.Label();
            this.lbl_noteNo = new System.Windows.Forms.Label();
            this.togNo = new System.Windows.Forms.TextBox();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dateOfNote = new System.Windows.Forms.DateTimePicker();
            this.lbl_reason = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lbl_userValue = new System.Windows.Forms.Label();
            this.supplier = new System.Windows.Forms.ComboBox();
            this.location = new System.Windows.Forms.ComboBox();
            this.lblReturnBy = new System.Windows.Forms.Label();
            this.returnBy = new System.Windows.Forms.TextBox();
            this.reason1 = new System.Windows.Forms.RadioButton();
            this.reason2 = new System.Windows.Forms.RadioButton();
            this.reason3 = new System.Windows.Forms.RadioButton();
            this.reason4 = new System.Windows.Forms.RadioButton();
            this.reason5 = new System.Windows.Forms.RadioButton();
            this.saveButton = new FlatButton.JFlatButton();
            this.reason6 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tital
            // 
            this.tital.AutoSize = true;
            this.tital.BackColor = System.Drawing.Color.Transparent;
            this.tital.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tital.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tital.Location = new System.Drawing.Point(38, 52);
            this.tital.Name = "tital";
            this.tital.Size = new System.Drawing.Size(168, 22);
            this.tital.TabIndex = 0;
            this.tital.Text = "TOG Note Details";
            this.tital.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_noteNo
            // 
            this.lbl_noteNo.AutoSize = true;
            this.lbl_noteNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_noteNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noteNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_noteNo.Location = new System.Drawing.Point(173, 164);
            this.lbl_noteNo.Name = "lbl_noteNo";
            this.lbl_noteNo.Size = new System.Drawing.Size(74, 18);
            this.lbl_noteNo.TabIndex = 1;
            this.lbl_noteNo.Text = "TOG No :";
            this.lbl_noteNo.Click += new System.EventHandler(this.lbl_noteNo_Click);
            // 
            // togNo
            // 
            this.togNo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.togNo.Location = new System.Drawing.Point(262, 163);
            this.togNo.Name = "togNo";
            this.togNo.Size = new System.Drawing.Size(151, 22);
            this.togNo.TabIndex = 2;
            this.togNo.TextChanged += new System.EventHandler(this.noteNo_TextChanged);
            this.togNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noteNo_KeyDown);
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.BackColor = System.Drawing.Color.Transparent;
            this.lbl_supplier.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_supplier.Location = new System.Drawing.Point(172, 223);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(76, 18);
            this.lbl_supplier.TabIndex = 3;
            this.lbl_supplier.Text = "Supplier :";
            this.lbl_supplier.Click += new System.EventHandler(this.lbl_supplier_Click);
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.BackColor = System.Drawing.Color.Transparent;
            this.lbl_from.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_from.Location = new System.Drawing.Point(174, 282);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(77, 18);
            this.lbl_from.TabIndex = 5;
            this.lbl_from.Text = "Location :";
            this.lbl_from.Click += new System.EventHandler(this.lbl_from_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_date.Location = new System.Drawing.Point(565, 163);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(103, 18);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "Date of note :";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // dateOfNote
            // 
            this.dateOfNote.Location = new System.Drawing.Point(682, 164);
            this.dateOfNote.Name = "dateOfNote";
            this.dateOfNote.Size = new System.Drawing.Size(200, 20);
            this.dateOfNote.TabIndex = 8;
            this.dateOfNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateOfNote_KeyDown);
            // 
            // lbl_reason
            // 
            this.lbl_reason.AutoSize = true;
            this.lbl_reason.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reason.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reason.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_reason.Location = new System.Drawing.Point(565, 221);
            this.lbl_reason.Name = "lbl_reason";
            this.lbl_reason.Size = new System.Drawing.Size(70, 18);
            this.lbl_reason.TabIndex = 10;
            this.lbl_reason.Text = "Reason :";
            this.lbl_reason.Click += new System.EventHandler(this.lbl_reason_Click);
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(682, 312);
            this.reason.Multiline = true;
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(370, 65);
            this.reason.TabIndex = 11;
            this.reason.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reason_KeyDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(1137, 58);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 19);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "User :";
            this.lblUser.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_userValue
            // 
            this.lbl_userValue.AutoSize = true;
            this.lbl_userValue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userValue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_userValue.Location = new System.Drawing.Point(1198, 58);
            this.lbl_userValue.Name = "lbl_userValue";
            this.lbl_userValue.Size = new System.Drawing.Size(0, 20);
            this.lbl_userValue.TabIndex = 13;
            // 
            // supplier
            // 
            this.supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.supplier.FormattingEnabled = true;
            this.supplier.Items.AddRange(new object[] {
            "Pilot St",
            "Saman St",
            "Samudra"});
            this.supplier.Location = new System.Drawing.Point(262, 223);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(151, 21);
            this.supplier.TabIndex = 14;
            this.supplier.SelectedIndexChanged += new System.EventHandler(this.supplier_SelectedIndexChanged);
            this.supplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.supplier_KeyDown_1);
            // 
            // location
            // 
            this.location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.location.FormattingEnabled = true;
            this.location.Items.AddRange(new object[] {
            "G1",
            "G2",
            "G3",
            "NB",
            "KW",
            "KPY",
            "HO"});
            this.location.Location = new System.Drawing.Point(262, 282);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(151, 21);
            this.location.TabIndex = 15;
            this.location.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.location.KeyDown += new System.Windows.Forms.KeyEventHandler(this.from_KeyDown_1);
            // 
            // lblReturnBy
            // 
            this.lblReturnBy.AutoSize = true;
            this.lblReturnBy.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnBy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReturnBy.Location = new System.Drawing.Point(174, 338);
            this.lblReturnBy.Name = "lblReturnBy";
            this.lblReturnBy.Size = new System.Drawing.Size(85, 18);
            this.lblReturnBy.TabIndex = 17;
            this.lblReturnBy.Text = "Return by :";
            // 
            // returnBy
            // 
            this.returnBy.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBy.Location = new System.Drawing.Point(262, 338);
            this.returnBy.Name = "returnBy";
            this.returnBy.Size = new System.Drawing.Size(151, 22);
            this.returnBy.TabIndex = 18;
            this.returnBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.returnBy_KeyDown);
            // 
            // reason1
            // 
            this.reason1.AutoSize = true;
            this.reason1.BackColor = System.Drawing.Color.Transparent;
            this.reason1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.reason1.ForeColor = System.Drawing.Color.White;
            this.reason1.Location = new System.Drawing.Point(682, 223);
            this.reason1.Name = "reason1";
            this.reason1.Size = new System.Drawing.Size(110, 20);
            this.reason1.TabIndex = 19;
            this.reason1.TabStop = true;
            this.reason1.Text = "Damage Items";
            this.reason1.UseVisualStyleBackColor = false;
            // 
            // reason2
            // 
            this.reason2.AutoSize = true;
            this.reason2.BackColor = System.Drawing.Color.Transparent;
            this.reason2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.reason2.ForeColor = System.Drawing.Color.White;
            this.reason2.Location = new System.Drawing.Point(682, 249);
            this.reason2.Name = "reason2";
            this.reason2.Size = new System.Drawing.Size(124, 20);
            this.reason2.TabIndex = 20;
            this.reason2.TabStop = true;
            this.reason2.Text = "Syllabus Change";
            this.reason2.UseVisualStyleBackColor = false;
            this.reason2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // reason3
            // 
            this.reason3.AutoSize = true;
            this.reason3.BackColor = System.Drawing.Color.Transparent;
            this.reason3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.reason3.ForeColor = System.Drawing.Color.White;
            this.reason3.Location = new System.Drawing.Point(682, 275);
            this.reason3.Name = "reason3";
            this.reason3.Size = new System.Drawing.Size(114, 20);
            this.reason3.TabIndex = 21;
            this.reason3.TabStop = true;
            this.reason3.Text = "Shortage Items";
            this.reason3.UseVisualStyleBackColor = false;
            // 
            // reason4
            // 
            this.reason4.AutoSize = true;
            this.reason4.BackColor = System.Drawing.Color.Transparent;
            this.reason4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.reason4.ForeColor = System.Drawing.Color.White;
            this.reason4.Location = new System.Drawing.Point(882, 223);
            this.reason4.Name = "reason4";
            this.reason4.Size = new System.Drawing.Size(125, 20);
            this.reason4.TabIndex = 22;
            this.reason4.TabStop = true;
            this.reason4.Text = "Supplier Request";
            this.reason4.UseVisualStyleBackColor = false;
            // 
            // reason5
            // 
            this.reason5.AutoSize = true;
            this.reason5.BackColor = System.Drawing.Color.Transparent;
            this.reason5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.reason5.ForeColor = System.Drawing.Color.White;
            this.reason5.Location = new System.Drawing.Point(882, 249);
            this.reason5.Name = "reason5";
            this.reason5.Size = new System.Drawing.Size(142, 20);
            this.reason5.TabIndex = 23;
            this.reason5.TabStop = true;
            this.reason5.Text = "Issued a New Paper";
            this.reason5.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.ButtonText = "Save";
            this.saveButton.CausesValidation = false;
            this.saveButton.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("saveButton.ErrorImageLeft")));
            this.saveButton.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("saveButton.ErrorImageRight")));
            this.saveButton.FocusBackground = System.Drawing.Color.Empty;
            this.saveButton.FocusFontColor = System.Drawing.Color.Empty;
            this.saveButton.ForeColors = System.Drawing.Color.White;
            this.saveButton.HoverBackground = System.Drawing.Color.Empty;
            this.saveButton.HoverFontColor = System.Drawing.Color.Empty;
            this.saveButton.ImageLeft = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageLeft")));
            this.saveButton.ImageRight = null;
            this.saveButton.LeftPictureColor = System.Drawing.Color.Transparent;
            this.saveButton.Location = new System.Drawing.Point(437, 451);
            this.saveButton.Name = "saveButton";
            this.saveButton.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.saveButton.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.saveButton.RightPictureColor = System.Drawing.Color.Transparent;
            this.saveButton.Size = new System.Drawing.Size(231, 43);
            this.saveButton.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.saveButton.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.saveButton.TabIndex = 24;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // reason6
            // 
            this.reason6.AutoSize = true;
            this.reason6.BackColor = System.Drawing.Color.Transparent;
            this.reason6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.reason6.ForeColor = System.Drawing.Color.White;
            this.reason6.Location = new System.Drawing.Point(882, 275);
            this.reason6.Name = "reason6";
            this.reason6.Size = new System.Drawing.Size(155, 20);
            this.reason6.TabIndex = 25;
            this.reason6.TabStop = true;
            this.reason6.Text = "Items not to be Return";
            this.reason6.UseVisualStyleBackColor = false;
            // 
            // enterNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1335, 623);
            this.Controls.Add(this.reason6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reason5);
            this.Controls.Add(this.reason4);
            this.Controls.Add(this.reason3);
            this.Controls.Add(this.reason2);
            this.Controls.Add(this.reason1);
            this.Controls.Add(this.returnBy);
            this.Controls.Add(this.lblReturnBy);
            this.Controls.Add(this.location);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.lbl_userValue);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.lbl_reason);
            this.Controls.Add(this.dateOfNote);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.lbl_supplier);
            this.Controls.Add(this.togNo);
            this.Controls.Add(this.lbl_noteNo);
            this.Controls.Add(this.tital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "enterNote";
            this.Text = "enterNote";
            this.Load += new System.EventHandler(this.enterNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tital;
        private System.Windows.Forms.Label lbl_noteNo;
        private System.Windows.Forms.TextBox togNo;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker dateOfNote;
        private System.Windows.Forms.Label lbl_reason;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lbl_userValue;
        private System.Windows.Forms.ComboBox supplier;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.Label lblReturnBy;
        private System.Windows.Forms.TextBox returnBy;
        private System.Windows.Forms.RadioButton reason1;
        private System.Windows.Forms.RadioButton reason2;
        private System.Windows.Forms.RadioButton reason3;
        private System.Windows.Forms.RadioButton reason4;
        private System.Windows.Forms.RadioButton reason5;
        private FlatButton.JFlatButton saveButton;
        private System.Windows.Forms.RadioButton reason6;
    }
}