namespace Returm_Management_System
{
    partial class find
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
            this.from = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.TextBox();
            this.supplier = new System.Windows.Forms.TextBox();
            this.noteNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tital
            // 
            this.tital.AutoSize = true;
            this.tital.BackColor = System.Drawing.Color.Transparent;
            this.tital.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tital.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tital.Location = new System.Drawing.Point(71, 57);
            this.tital.Name = "tital";
            this.tital.Size = new System.Drawing.Size(125, 22);
            this.tital.TabIndex = 2;
            this.tital.Text = "Find a Notes";
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.from.ForeColor = System.Drawing.Color.DimGray;
            this.from.FormattingEnabled = true;
            this.from.Items.AddRange(new object[] {
            "G1",
            "G2",
            "G3",
            "NB",
            "KW",
            "KPY"});
            this.from.Location = new System.Drawing.Point(509, 115);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(164, 28);
            this.from.TabIndex = 15;
            this.from.Text = "From";
            this.from.Enter += new System.EventHandler(this.from_Enter);
            this.from.Leave += new System.EventHandler(this.from_Leave);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.date.ForeColor = System.Drawing.Color.DimGray;
            this.date.Location = new System.Drawing.Point(740, 116);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(164, 26);
            this.date.TabIndex = 14;
            this.date.Text = "Date";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Enter += new System.EventHandler(this.date_Enter);
            this.date.Leave += new System.EventHandler(this.date_Leave);
            // 
            // supplier
            // 
            this.supplier.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.supplier.ForeColor = System.Drawing.Color.DimGray;
            this.supplier.Location = new System.Drawing.Point(291, 118);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(164, 26);
            this.supplier.TabIndex = 13;
            this.supplier.Text = "Supplier Name";
            this.supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.supplier.Enter += new System.EventHandler(this.supplier_Enter);
            this.supplier.Leave += new System.EventHandler(this.supplier_Leave);
            // 
            // noteNo
            // 
            this.noteNo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.noteNo.ForeColor = System.Drawing.Color.DimGray;
            this.noteNo.Location = new System.Drawing.Point(72, 118);
            this.noteNo.Name = "noteNo";
            this.noteNo.Size = new System.Drawing.Size(164, 26);
            this.noteNo.TabIndex = 12;
            this.noteNo.Text = "Note No";
            this.noteNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.noteNo.Enter += new System.EventHandler(this.noteNo_Enter);
            this.noteNo.Leave += new System.EventHandler(this.noteNo_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1042, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ReturnBy,
            this.dateOfNote,
            this.reasonCate,
            this.reasonDisc,
            this.dataGridViewTextBoxColumn4,
            this.state});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(29, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1211, 437);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Note no";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "From";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ReturnBy
            // 
            this.ReturnBy.HeaderText = "Return By";
            this.ReturnBy.Name = "ReturnBy";
            this.ReturnBy.ReadOnly = true;
            // 
            // dateOfNote
            // 
            this.dateOfNote.HeaderText = "Date of note";
            this.dateOfNote.Name = "dateOfNote";
            this.dateOfNote.ReadOnly = true;
            this.dateOfNote.Width = 120;
            // 
            // reasonCate
            // 
            this.reasonCate.HeaderText = "Category";
            this.reasonCate.Name = "reasonCate";
            this.reasonCate.ReadOnly = true;
            // 
            // reasonDisc
            // 
            this.reasonDisc.HeaderText = "Discription";
            this.reasonDisc.Name = "reasonDisc";
            this.reasonDisc.ReadOnly = true;
            this.reasonDisc.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 120;
            // 
            // find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Returm_Management_System.Properties.Resources.wtiopz;
            this.ClientSize = new System.Drawing.Size(1264, 684);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.from);
            this.Controls.Add(this.date);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.noteNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "find";
            this.Text = "find";
            this.Load += new System.EventHandler(this.find_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tital;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox supplier;
        private System.Windows.Forms.TextBox noteNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}