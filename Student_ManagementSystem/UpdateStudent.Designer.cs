namespace Student_ManagementSystem
{
    partial class UpdateStudent
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panelsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsidebar
            // 
            this.panelsidebar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelsidebar.Controls.Add(this.button3);
            this.panelsidebar.Controls.Add(this.button2);
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(273, 237);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 22);
            this.txtName.TabIndex = 13;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(622, 237);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(246, 22);
            this.txtAge.TabIndex = 14;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(1006, 237);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(246, 22);
            this.txtGender.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 69);
            this.label1.TabIndex = 16;
            this.label1.Text = "STUDENT UPDATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1072, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gender";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(622, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 79);
            this.button1.TabIndex = 20;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(29, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 73);
            this.button2.TabIndex = 4;
            this.button2.Text = "Student Grades";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(29, 592);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 73);
            this.button3.TabIndex = 7;
            this.button3.Text = "Student Average";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1318, 765);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panelsidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStudent";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            this.panelsidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelsidebar;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCRUD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}