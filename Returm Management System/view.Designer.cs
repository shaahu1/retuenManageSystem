namespace Returm_Management_System
{
    partial class view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view));
            this.tital = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.togNoteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfTogNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnNoteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.Button();
            this.step3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tital
            // 
            this.tital.AutoSize = true;
            this.tital.BackColor = System.Drawing.Color.Transparent;
            this.tital.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tital.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tital.Location = new System.Drawing.Point(73, 47);
            this.tital.Name = "tital";
            this.tital.Size = new System.Drawing.Size(130, 22);
            this.tital.TabIndex = 1;
            this.tital.Text = "Return Notes";
            this.tital.Click += new System.EventHandler(this.tital_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.togNoteNo,
            this.location,
            this.supplier,
            this.ReturnBy,
            this.dateOfTogNote,
            this.reasonCate,
            this.reasonDisc,
            this.date2,
            this.state,
            this.returnNoteNo,
            this.date3,
            this.receivedBy,
            this.name1,
            this.accountant,
            this.date4});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(46, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 447);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // togNoteNo
            // 
            this.togNoteNo.HeaderText = "TOG Note no";
            this.togNoteNo.Name = "togNoteNo";
            this.togNoteNo.ReadOnly = true;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Supplier";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            this.supplier.Width = 150;
            // 
            // ReturnBy
            // 
            this.ReturnBy.HeaderText = "Return By";
            this.ReturnBy.Name = "ReturnBy";
            this.ReturnBy.ReadOnly = true;
            // 
            // dateOfTogNote
            // 
            this.dateOfTogNote.HeaderText = "Date of TOG note";
            this.dateOfTogNote.Name = "dateOfTogNote";
            this.dateOfTogNote.ReadOnly = true;
            this.dateOfTogNote.Width = 120;
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
            // date2
            // 
            this.date2.HeaderText = "TOG Received Date";
            this.date2.Name = "date2";
            this.date2.ReadOnly = true;
            this.date2.Width = 120;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 120;
            // 
            // returnNoteNo
            // 
            this.returnNoteNo.HeaderText = "Retuen Note No";
            this.returnNoteNo.Name = "returnNoteNo";
            this.returnNoteNo.ReadOnly = true;
            // 
            // date3
            // 
            this.date3.HeaderText = "Date of return Note";
            this.date3.Name = "date3";
            this.date3.ReadOnly = true;
            // 
            // receivedBy
            // 
            this.receivedBy.HeaderText = "Received By";
            this.receivedBy.Name = "receivedBy";
            this.receivedBy.ReadOnly = true;
            // 
            // name1
            // 
            this.name1.HeaderText = "Date";
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            // 
            // accountant
            // 
            this.accountant.HeaderText = "Accountant";
            this.accountant.Name = "accountant";
            this.accountant.ReadOnly = true;
            // 
            // date4
            // 
            this.date4.HeaderText = "Date";
            this.date4.Name = "date4";
            this.date4.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(46, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Received TOGs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(827, 619);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Complete Notes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.search.Location = new System.Drawing.Point(566, 46);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(614, 26);
            this.search.TabIndex = 17;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1060, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 108);
            this.label1.TabIndex = 21;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // step2
            // 
            this.step2.BackColor = System.Drawing.Color.Red;
            this.step2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step2.ForeColor = System.Drawing.Color.White;
            this.step2.Location = new System.Drawing.Point(310, 619);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(180, 48);
            this.step2.TabIndex = 22;
            this.step2.Text = "Notes not handed over";
            this.step2.UseVisualStyleBackColor = false;
            this.step2.Click += new System.EventHandler(this.step2_Click);
            // 
            // step3
            // 
            this.step3.BackColor = System.Drawing.Color.Red;
            this.step3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step3.ForeColor = System.Drawing.Color.White;
            this.step3.Location = new System.Drawing.Point(575, 619);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(180, 48);
            this.step3.TabIndex = 23;
            this.step3.Text = "Notes handed over";
            this.step3.UseVisualStyleBackColor = false;
            this.step3.Click += new System.EventHandler(this.step3_Click);
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1363, 694);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "view";
            this.Text = "view";
            this.Load += new System.EventHandler(this.view_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tital;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn togNoteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfTogNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnNoteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date3;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountant;
        private System.Windows.Forms.DataGridViewTextBoxColumn date4;
        private System.Windows.Forms.Button step2;
        private System.Windows.Forms.Button step3;
    }
}