namespace Student_ManagementSystem
{
    partial class StudentGrades
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
            this.panelsidebar = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCRUD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.dgvStudentGrades = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panelsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsidebar
            // 
            this.panelsidebar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelsidebar.Controls.Add(this.button2);
            this.panelsidebar.Controls.Add(this.button1);
            this.panelsidebar.Controls.Add(this.btnUsers);
            this.panelsidebar.Controls.Add(this.btnCRUD);
            this.panelsidebar.Controls.Add(this.pictureBox1);
            this.panelsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidebar.Location = new System.Drawing.Point(0, 0);
            this.panelsidebar.Name = "panelsidebar";
            this.panelsidebar.Size = new System.Drawing.Size(175, 765);
            this.panelsidebar.TabIndex = 12;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(29, 350);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(113, 73);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Manage Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCRUD
            // 
            this.btnCRUD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCRUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCRUD.Location = new System.Drawing.Point(29, 237);
            this.btnCRUD.Name = "btnCRUD";
            this.btnCRUD.Size = new System.Drawing.Size(113, 73);
            this.btnCRUD.TabIndex = 1;
            this.btnCRUD.Text = "Manage Student";
            this.btnCRUD.UseVisualStyleBackColor = false;
            this.btnCRUD.Click += new System.EventHandler(this.btnCRUD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 69);
            this.label1.TabIndex = 13;
            this.label1.Text = "STUDENT GRADES";
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(370, 187);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(280, 24);
            this.cmbStudents.TabIndex = 14;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(780, 169);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(285, 47);
            this.btnAddStudent.TabIndex = 15;
            this.btnAddStudent.Text = "Add New Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Grade:";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(500, 350);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(171, 22);
            this.txtGrade.TabIndex = 18;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrade.Location = new System.Drawing.Point(780, 319);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(171, 40);
            this.btnAddGrade.TabIndex = 19;
            this.btnAddGrade.Text = "Add Grade";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(500, 300);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(171, 24);
            this.cmbSubjects.TabIndex = 20;
            // 
            // dgvStudentGrades
            // 
            this.dgvStudentGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentGrades.Location = new System.Drawing.Point(398, 441);
            this.dgvStudentGrades.Name = "dgvStudentGrades";
            this.dgvStudentGrades.RowHeadersWidth = 51;
            this.dgvStudentGrades.RowTemplate.Height = 24;
            this.dgvStudentGrades.Size = new System.Drawing.Size(667, 230);
            this.dgvStudentGrades.TabIndex = 21;
            this.dgvStudentGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentGrades_CellContentClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(574, 699);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(297, 54);
            this.button3.TabIndex = 22;
            this.button3.Text = "Back to Main";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "Student Grades";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Student_ManagementSystem.Properties.Resources.stud1;
            this.pictureBox1.Image = global::Student_ManagementSystem.Properties.Resources.stud1;
            this.pictureBox1.Location = new System.Drawing.Point(29, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(29, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 73);
            this.button2.TabIndex = 7;
            this.button2.Text = "Student Average";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1318, 765);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvStudentGrades);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelsidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentGrades";
            this.Load += new System.EventHandler(this.StudentGrades_Load);
            this.panelsidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelsidebar;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCRUD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.DataGridView dgvStudentGrades;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}