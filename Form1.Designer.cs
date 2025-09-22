namespace StudentNotes
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.gbxaddStudent = new System.Windows.Forms.GroupBox();
            this.tbxnumber = new System.Windows.Forms.TextBox();
            this.lblnumber = new System.Windows.Forms.Label();
            this.tbxclass = new System.Windows.Forms.TextBox();
            this.tbxsurname = new System.Windows.Forms.TextBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.lblclass = new System.Windows.Forms.Label();
            this.lblssurname = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.gbxupdateStudent = new System.Windows.Forms.GroupBox();
            this.tbxclassUpdate = new System.Windows.Forms.TextBox();
            this.tbxsurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxnameUpdate = new System.Windows.Forms.TextBox();
            this.lblclassUpdate = new System.Windows.Forms.Label();
            this.lblsurnameUpdate = new System.Windows.Forms.Label();
            this.lblnameUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.rtbxmesaj = new System.Windows.Forms.RichTextBox();
            this.btnyes = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.lblnumberUpdate = new System.Windows.Forms.Label();
            this.tbxnumberUpdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.gbxaddStudent.SuspendLayout();
            this.gbxupdateStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwStudents
            // 
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.Location = new System.Drawing.Point(12, 12);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowHeadersWidth = 51;
            this.dgwStudents.RowTemplate.Height = 24;
            this.dgwStudents.Size = new System.Drawing.Size(776, 181);
            this.dgwStudents.TabIndex = 0;
            this.dgwStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudents_CellClick);
            // 
            // gbxaddStudent
            // 
            this.gbxaddStudent.Controls.Add(this.tbxnumber);
            this.gbxaddStudent.Controls.Add(this.lblnumber);
            this.gbxaddStudent.Controls.Add(this.tbxclass);
            this.gbxaddStudent.Controls.Add(this.tbxsurname);
            this.gbxaddStudent.Controls.Add(this.tbxname);
            this.gbxaddStudent.Controls.Add(this.lblclass);
            this.gbxaddStudent.Controls.Add(this.lblssurname);
            this.gbxaddStudent.Controls.Add(this.lblname);
            this.gbxaddStudent.Controls.Add(this.btnadd);
            this.gbxaddStudent.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxaddStudent.Location = new System.Drawing.Point(12, 213);
            this.gbxaddStudent.Name = "gbxaddStudent";
            this.gbxaddStudent.Size = new System.Drawing.Size(324, 225);
            this.gbxaddStudent.TabIndex = 1;
            this.gbxaddStudent.TabStop = false;
            this.gbxaddStudent.Text = "Add a Student";
            // 
            // tbxnumber
            // 
            this.tbxnumber.Location = new System.Drawing.Point(171, 81);
            this.tbxnumber.Name = "tbxnumber";
            this.tbxnumber.Size = new System.Drawing.Size(100, 25);
            this.tbxnumber.TabIndex = 8;
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(33, 84);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(62, 17);
            this.lblnumber.TabIndex = 7;
            this.lblnumber.Text = "Number";
            this.lblnumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxclass
            // 
            this.tbxclass.Location = new System.Drawing.Point(171, 109);
            this.tbxclass.Name = "tbxclass";
            this.tbxclass.Size = new System.Drawing.Size(100, 25);
            this.tbxclass.TabIndex = 6;
            // 
            // tbxsurname
            // 
            this.tbxsurname.Location = new System.Drawing.Point(171, 54);
            this.tbxsurname.Name = "tbxsurname";
            this.tbxsurname.Size = new System.Drawing.Size(100, 25);
            this.tbxsurname.TabIndex = 5;
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(171, 27);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(100, 25);
            this.tbxname.TabIndex = 4;
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.Location = new System.Drawing.Point(33, 112);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(45, 17);
            this.lblclass.TabIndex = 3;
            this.lblclass.Text = "Class";
            this.lblclass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblssurname
            // 
            this.lblssurname.AutoSize = true;
            this.lblssurname.Location = new System.Drawing.Point(33, 57);
            this.lblssurname.Name = "lblssurname";
            this.lblssurname.Size = new System.Drawing.Size(65, 17);
            this.lblssurname.TabIndex = 2;
            this.lblssurname.Text = "Surname";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(33, 30);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(47, 17);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(153, 160);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(147, 33);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // gbxupdateStudent
            // 
            this.gbxupdateStudent.Controls.Add(this.tbxnumberUpdate);
            this.gbxupdateStudent.Controls.Add(this.lblnumberUpdate);
            this.gbxupdateStudent.Controls.Add(this.tbxclassUpdate);
            this.gbxupdateStudent.Controls.Add(this.tbxsurnameUpdate);
            this.gbxupdateStudent.Controls.Add(this.tbxnameUpdate);
            this.gbxupdateStudent.Controls.Add(this.lblclassUpdate);
            this.gbxupdateStudent.Controls.Add(this.lblsurnameUpdate);
            this.gbxupdateStudent.Controls.Add(this.lblnameUpdate);
            this.gbxupdateStudent.Controls.Add(this.btnUpdate);
            this.gbxupdateStudent.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxupdateStudent.Location = new System.Drawing.Point(342, 213);
            this.gbxupdateStudent.Name = "gbxupdateStudent";
            this.gbxupdateStudent.Size = new System.Drawing.Size(324, 225);
            this.gbxupdateStudent.TabIndex = 9;
            this.gbxupdateStudent.TabStop = false;
            this.gbxupdateStudent.Text = "Update a Student";
            // 
            // tbxclassUpdate
            // 
            this.tbxclassUpdate.Location = new System.Drawing.Point(171, 109);
            this.tbxclassUpdate.Name = "tbxclassUpdate";
            this.tbxclassUpdate.Size = new System.Drawing.Size(100, 25);
            this.tbxclassUpdate.TabIndex = 6;
            // 
            // tbxsurnameUpdate
            // 
            this.tbxsurnameUpdate.Location = new System.Drawing.Point(171, 54);
            this.tbxsurnameUpdate.Name = "tbxsurnameUpdate";
            this.tbxsurnameUpdate.Size = new System.Drawing.Size(100, 25);
            this.tbxsurnameUpdate.TabIndex = 5;
            // 
            // tbxnameUpdate
            // 
            this.tbxnameUpdate.Location = new System.Drawing.Point(171, 27);
            this.tbxnameUpdate.Name = "tbxnameUpdate";
            this.tbxnameUpdate.Size = new System.Drawing.Size(100, 25);
            this.tbxnameUpdate.TabIndex = 4;
            // 
            // lblclassUpdate
            // 
            this.lblclassUpdate.AutoSize = true;
            this.lblclassUpdate.Location = new System.Drawing.Point(33, 112);
            this.lblclassUpdate.Name = "lblclassUpdate";
            this.lblclassUpdate.Size = new System.Drawing.Size(45, 17);
            this.lblclassUpdate.TabIndex = 3;
            this.lblclassUpdate.Text = "Class";
            this.lblclassUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblsurnameUpdate
            // 
            this.lblsurnameUpdate.AutoSize = true;
            this.lblsurnameUpdate.Location = new System.Drawing.Point(33, 57);
            this.lblsurnameUpdate.Name = "lblsurnameUpdate";
            this.lblsurnameUpdate.Size = new System.Drawing.Size(65, 17);
            this.lblsurnameUpdate.TabIndex = 2;
            this.lblsurnameUpdate.Text = "Surname";
            // 
            // lblnameUpdate
            // 
            this.lblnameUpdate.AutoSize = true;
            this.lblnameUpdate.Location = new System.Drawing.Point(33, 30);
            this.lblnameUpdate.Name = "lblnameUpdate";
            this.lblnameUpdate.Size = new System.Drawing.Size(47, 17);
            this.lblnameUpdate.TabIndex = 1;
            this.lblnameUpdate.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(153, 160);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 33);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(684, 236);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(88, 43);
            this.btnremove.TabIndex = 9;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // rtbxmesaj
            // 
            this.rtbxmesaj.Location = new System.Drawing.Point(672, 285);
            this.rtbxmesaj.Name = "rtbxmesaj";
            this.rtbxmesaj.Size = new System.Drawing.Size(116, 52);
            this.rtbxmesaj.TabIndex = 10;
            this.rtbxmesaj.Text = "";
            // 
            // btnyes
            // 
            this.btnyes.BackColor = System.Drawing.SystemColors.Control;
            this.btnyes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnyes.Location = new System.Drawing.Point(672, 343);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(59, 44);
            this.btnyes.TabIndex = 11;
            this.btnyes.Text = "YES";
            this.btnyes.UseVisualStyleBackColor = false;
            this.btnyes.Visible = false;
            this.btnyes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(731, 343);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(57, 44);
            this.btnno.TabIndex = 12;
            this.btnno.Text = "NO";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Visible = false;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // lblnumberUpdate
            // 
            this.lblnumberUpdate.AutoSize = true;
            this.lblnumberUpdate.Location = new System.Drawing.Point(33, 84);
            this.lblnumberUpdate.Name = "lblnumberUpdate";
            this.lblnumberUpdate.Size = new System.Drawing.Size(62, 17);
            this.lblnumberUpdate.TabIndex = 8;
            this.lblnumberUpdate.Text = "Number";
            this.lblnumberUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxnumberUpdate
            // 
            this.tbxnumberUpdate.Location = new System.Drawing.Point(171, 81);
            this.tbxnumberUpdate.Name = "tbxnumberUpdate";
            this.tbxnumberUpdate.Size = new System.Drawing.Size(100, 25);
            this.tbxnumberUpdate.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.rtbxmesaj);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.gbxupdateStudent);
            this.Controls.Add(this.gbxaddStudent);
            this.Controls.Add(this.dgwStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.gbxaddStudent.ResumeLayout(false);
            this.gbxaddStudent.PerformLayout();
            this.gbxupdateStudent.ResumeLayout(false);
            this.gbxupdateStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.GroupBox gbxaddStudent;
        private System.Windows.Forms.TextBox tbxclass;
        private System.Windows.Forms.TextBox tbxsurname;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.Label lblssurname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox gbxupdateStudent;
        private System.Windows.Forms.TextBox tbxclassUpdate;
        private System.Windows.Forms.TextBox tbxsurnameUpdate;
        private System.Windows.Forms.TextBox tbxnameUpdate;
        private System.Windows.Forms.Label lblclassUpdate;
        private System.Windows.Forms.Label lblsurnameUpdate;
        private System.Windows.Forms.Label lblnameUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.RichTextBox rtbxmesaj;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.TextBox tbxnumber;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.TextBox tbxnumberUpdate;
        private System.Windows.Forms.Label lblnumberUpdate;
    }
}

