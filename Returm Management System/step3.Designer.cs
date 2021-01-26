namespace Returm_Management_System
{
    partial class step3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(step3));
            this.tital = new System.Windows.Forms.Label();
            this.noteNo = new System.Windows.Forms.TextBox();
            this.lbl_noteNo = new System.Windows.Forms.Label();
            this.receivedBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new FlatButton.JFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTogNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tital
            // 
            this.tital.AutoSize = true;
            this.tital.BackColor = System.Drawing.Color.Transparent;
            this.tital.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tital.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tital.Location = new System.Drawing.Point(91, 59);
            this.tital.Name = "tital";
            this.tital.Size = new System.Drawing.Size(159, 22);
            this.tital.TabIndex = 1;
            this.tital.Text = "Receiver Details";
            // 
            // noteNo
            // 
            this.noteNo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteNo.Location = new System.Drawing.Point(333, 163);
            this.noteNo.Name = "noteNo";
            this.noteNo.Size = new System.Drawing.Size(151, 22);
            this.noteNo.TabIndex = 4;
            this.noteNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noteNo_KeyDown);
            // 
            // lbl_noteNo
            // 
            this.lbl_noteNo.AutoSize = true;
            this.lbl_noteNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_noteNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noteNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_noteNo.Location = new System.Drawing.Point(182, 165);
            this.lbl_noteNo.Name = "lbl_noteNo";
            this.lbl_noteNo.Size = new System.Drawing.Size(127, 18);
            this.lbl_noteNo.TabIndex = 3;
            this.lbl_noteNo.Text = "Return Note No :";
            // 
            // receivedBy
            // 
            this.receivedBy.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedBy.Location = new System.Drawing.Point(333, 257);
            this.receivedBy.Name = "receivedBy";
            this.receivedBy.Size = new System.Drawing.Size(151, 22);
            this.receivedBy.TabIndex = 6;
            this.receivedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.receivedBy_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(182, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Received By :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.BackgroundColor = System.Drawing.Color.Lime;
            this.btnSave.ButtonText = "  Save";
            this.btnSave.CausesValidation = false;
            this.btnSave.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnSave.ErrorImageLeft")));
            this.btnSave.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnSave.ErrorImageRight")));
            this.btnSave.FocusBackground = System.Drawing.Color.Empty;
            this.btnSave.FocusFontColor = System.Drawing.Color.Empty;
            this.btnSave.ForeColors = System.Drawing.Color.White;
            this.btnSave.HoverBackground = System.Drawing.Color.Empty;
            this.btnSave.HoverFontColor = System.Drawing.Color.Empty;
            this.btnSave.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageLeft")));
            this.btnSave.ImageRight = null;
            this.btnSave.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(288, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnSave.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnSave.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnSave.Size = new System.Drawing.Size(159, 43);
            this.btnSave.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSave.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnSave.TabIndex = 7;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(182, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date :";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.date.Location = new System.Drawing.Point(333, 342);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 9;
            this.date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_KeyDown);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSupplier.Location = new System.Drawing.Point(774, 165);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(0, 18);
            this.lblSupplier.TabIndex = 10;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocation.Location = new System.Drawing.Point(939, 165);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 18);
            this.lblLocation.TabIndex = 11;
            // 
            // lblTogNo
            // 
            this.lblTogNo.AutoSize = true;
            this.lblTogNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTogNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTogNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTogNo.Location = new System.Drawing.Point(607, 165);
            this.lblTogNo.Name = "lblTogNo";
            this.lblTogNo.Size = new System.Drawing.Size(0, 18);
            this.lblTogNo.TabIndex = 12;
            // 
            // step3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Returm_Management_System.Properties.Resources.wtiopz;
            this.ClientSize = new System.Drawing.Size(1275, 644);
            this.Controls.Add(this.lblTogNo);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.receivedBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteNo);
            this.Controls.Add(this.lbl_noteNo);
            this.Controls.Add(this.tital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "step3";
            this.Text = "step3";
            this.Load += new System.EventHandler(this.step3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tital;
        private System.Windows.Forms.TextBox noteNo;
        private System.Windows.Forms.Label lbl_noteNo;
        private System.Windows.Forms.TextBox receivedBy;
        private System.Windows.Forms.Label label1;
        private FlatButton.JFlatButton btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTogNo;
    }
}