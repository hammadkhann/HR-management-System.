namespace HR
{
    partial class JobForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.jobTitleTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jobDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SkillDropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YearDropDown = new System.Windows.Forms.ComboBox();
            this.RequiredSkillsWithExperienceListView = new System.Windows.Forms.ListView();
            this.Skills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequiredYears = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.jobDepartmentDropDown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeDropDown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.CandidateTypeDropDown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Skills1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Title";
            // 
            // jobTitleTextbox
            // 
            this.jobTitleTextbox.Location = new System.Drawing.Point(97, 6);
            this.jobTitleTextbox.Name = "jobTitleTextbox";
            this.jobTitleTextbox.Size = new System.Drawing.Size(538, 20);
            this.jobTitleTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // jobDescriptionTextbox
            // 
            this.jobDescriptionTextbox.Location = new System.Drawing.Point(96, 32);
            this.jobDescriptionTextbox.Multiline = true;
            this.jobDescriptionTextbox.Name = "jobDescriptionTextbox";
            this.jobDescriptionTextbox.Size = new System.Drawing.Size(539, 119);
            this.jobDescriptionTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Required Skills";
            // 
            // SkillDropDown
            // 
            this.SkillDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkillDropDown.FormattingEnabled = true;
            this.SkillDropDown.Location = new System.Drawing.Point(109, 21);
            this.SkillDropDown.Name = "SkillDropDown";
            this.SkillDropDown.Size = new System.Drawing.Size(121, 21);
            this.SkillDropDown.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Years of Experience";
            // 
            // YearDropDown
            // 
            this.YearDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearDropDown.FormattingEnabled = true;
            this.YearDropDown.Location = new System.Drawing.Point(388, 21);
            this.YearDropDown.Name = "YearDropDown";
            this.YearDropDown.Size = new System.Drawing.Size(121, 21);
            this.YearDropDown.TabIndex = 3;
            // 
            // RequiredSkillsWithExperienceListView
            // 
            this.RequiredSkillsWithExperienceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Skills,
            this.RequiredYears});
            this.RequiredSkillsWithExperienceListView.FullRowSelect = true;
            this.RequiredSkillsWithExperienceListView.GridLines = true;
            this.RequiredSkillsWithExperienceListView.Location = new System.Drawing.Point(27, 49);
            this.RequiredSkillsWithExperienceListView.Name = "RequiredSkillsWithExperienceListView";
            this.RequiredSkillsWithExperienceListView.Size = new System.Drawing.Size(515, 143);
            this.RequiredSkillsWithExperienceListView.TabIndex = 5;
            this.RequiredSkillsWithExperienceListView.UseCompatibleStateImageBehavior = false;
            this.RequiredSkillsWithExperienceListView.View = System.Windows.Forms.View.Details;
            this.RequiredSkillsWithExperienceListView.SelectedIndexChanged += new System.EventHandler(this.RequiredSkillsWithExperienceListView_SelectedIndexChanged);
            // 
            // Skills
            // 
            this.Skills.Width = 108;
            // 
            // RequiredYears
            // 
            this.RequiredYears.Text = "Required Years";
            this.RequiredYears.Width = 150;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(546, 20);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(63, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(546, 49);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(63, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(480, 393);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 24);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // jobDepartmentDropDown
            // 
            this.jobDepartmentDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobDepartmentDropDown.Location = new System.Drawing.Point(86, 157);
            this.jobDepartmentDropDown.Name = "jobDepartmentDropDown";
            this.jobDepartmentDropDown.Size = new System.Drawing.Size(121, 21);
            this.jobDepartmentDropDown.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department";
            // 
            // employeeDropDown
            // 
            this.employeeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDropDown.Location = new System.Drawing.Point(298, 157);
            this.employeeDropDown.Name = "employeeDropDown";
            this.employeeDropDown.Size = new System.Drawing.Size(121, 21);
            this.employeeDropDown.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hiring Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.RequiredSkillsWithExperienceListView);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SkillDropDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.YearDropDown);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 203);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Requirement";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(558, 393);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 24);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CandidateTypeDropDown
            // 
            this.CandidateTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CandidateTypeDropDown.Location = new System.Drawing.Point(513, 157);
            this.CandidateTypeDropDown.Name = "CandidateTypeDropDown";
            this.CandidateTypeDropDown.Size = new System.Drawing.Size(121, 21);
            this.CandidateTypeDropDown.TabIndex = 9;
            this.CandidateTypeDropDown.SelectedIndexChanged += new System.EventHandler(this.CandidateTypeDropDown_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Candidate Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Skills1,
            this.year});
            this.dataGridView1.Location = new System.Drawing.Point(163, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Skills1
            // 
            this.Skills1.HeaderText = "Skills";
            this.Skills1.Name = "Skills1";
            // 
            // year
            // 
            this.year.HeaderText = "year of experience";
            this.year.Name = "year";
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 424);
            this.Controls.Add(this.CandidateTypeDropDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeeDropDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jobDepartmentDropDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.jobDescriptionTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobTitleTextbox);
            this.Controls.Add(this.label1);
            this.Name = "JobForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.JobForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jobTitleTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobDescriptionTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SkillDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox YearDropDown;
        private System.Windows.Forms.ListView RequiredSkillsWithExperienceListView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox jobDepartmentDropDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Skills;
        private System.Windows.Forms.ColumnHeader RequiredYears;
        private System.Windows.Forms.ComboBox employeeDropDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox CandidateTypeDropDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skills1;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
    }
}

