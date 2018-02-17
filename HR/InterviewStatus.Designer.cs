namespace HR
{
    partial class InterviewStatus
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.JobTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JobDept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InterviewDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CandidateName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HiringManager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.candidateSelectedPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CandidateSelectedNoRadioButton = new System.Windows.Forms.RadioButton();
            this.CandidateSelectedYesRadioButton = new System.Windows.Forms.RadioButton();
            this.offerAcceptedPanel = new System.Windows.Forms.Panel();
            this.JoiningDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OfferAcceptedNoRadioButton = new System.Windows.Forms.RadioButton();
            this.OfferAcceptedYesRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.InterviewCompletedPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.InterviewCompletedNoRadioButton = new System.Windows.Forms.RadioButton();
            this.InterviewCompletedYesRadioButton = new System.Windows.Forms.RadioButton();
            this.closeButton = new System.Windows.Forms.Button();
            this.candidateSelectedPanel.SuspendLayout();
            this.offerAcceptedPanel.SuspendLayout();
            this.InterviewCompletedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JobTitle,
            this.JobDept,
            this.InterviewDate,
            this.CandidateName,
            this.Status,
            this.HiringManager});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(628, 141);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // JobTitle
            // 
            this.JobTitle.Text = "Job Title";
            this.JobTitle.Width = 78;
            // 
            // JobDept
            // 
            this.JobDept.Text = "Department";
            this.JobDept.Width = 91;
            // 
            // InterviewDate
            // 
            this.InterviewDate.Text = "Interview Date";
            this.InterviewDate.Width = 102;
            // 
            // CandidateName
            // 
            this.CandidateName.Text = "Candidate Name";
            this.CandidateName.Width = 97;
            // 
            // Status
            // 
            this.Status.Text = "Interview Status";
            this.Status.Width = 133;
            // 
            // HiringManager
            // 
            this.HiringManager.Text = "Hiring Manager";
            this.HiringManager.Width = 115;
            // 
            // candidateSelectedPanel
            // 
            this.candidateSelectedPanel.Controls.Add(this.label1);
            this.candidateSelectedPanel.Controls.Add(this.CandidateSelectedNoRadioButton);
            this.candidateSelectedPanel.Controls.Add(this.CandidateSelectedYesRadioButton);
            this.candidateSelectedPanel.Location = new System.Drawing.Point(18, 209);
            this.candidateSelectedPanel.Name = "candidateSelectedPanel";
            this.candidateSelectedPanel.Size = new System.Drawing.Size(284, 35);
            this.candidateSelectedPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Candidate is selected?";
            // 
            // CandidateSelectedNoRadioButton
            // 
            this.CandidateSelectedNoRadioButton.AutoSize = true;
            this.CandidateSelectedNoRadioButton.Location = new System.Drawing.Point(224, 9);
            this.CandidateSelectedNoRadioButton.Name = "CandidateSelectedNoRadioButton";
            this.CandidateSelectedNoRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CandidateSelectedNoRadioButton.Size = new System.Drawing.Size(39, 17);
            this.CandidateSelectedNoRadioButton.TabIndex = 1;
            this.CandidateSelectedNoRadioButton.TabStop = true;
            this.CandidateSelectedNoRadioButton.Text = "No";
            this.CandidateSelectedNoRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CandidateSelectedNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CandidateSelectedYesRadioButton
            // 
            this.CandidateSelectedYesRadioButton.AutoSize = true;
            this.CandidateSelectedYesRadioButton.Location = new System.Drawing.Point(157, 9);
            this.CandidateSelectedYesRadioButton.Name = "CandidateSelectedYesRadioButton";
            this.CandidateSelectedYesRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CandidateSelectedYesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.CandidateSelectedYesRadioButton.TabIndex = 0;
            this.CandidateSelectedYesRadioButton.TabStop = true;
            this.CandidateSelectedYesRadioButton.Text = "Yes";
            this.CandidateSelectedYesRadioButton.UseVisualStyleBackColor = true;
            this.CandidateSelectedYesRadioButton.CheckedChanged += new System.EventHandler(this.CandidateSelectedYesRadioButton_CheckedChanged);
            // 
            // offerAcceptedPanel
            // 
            this.offerAcceptedPanel.Controls.Add(this.JoiningDateTimePicker);
            this.offerAcceptedPanel.Controls.Add(this.label3);
            this.offerAcceptedPanel.Controls.Add(this.label2);
            this.offerAcceptedPanel.Controls.Add(this.OfferAcceptedNoRadioButton);
            this.offerAcceptedPanel.Controls.Add(this.OfferAcceptedYesRadioButton);
            this.offerAcceptedPanel.Location = new System.Drawing.Point(18, 244);
            this.offerAcceptedPanel.Name = "offerAcceptedPanel";
            this.offerAcceptedPanel.Size = new System.Drawing.Size(284, 68);
            this.offerAcceptedPanel.TabIndex = 3;
            // 
            // JoiningDateTimePicker
            // 
            this.JoiningDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.JoiningDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.JoiningDateTimePicker.Location = new System.Drawing.Point(80, 37);
            this.JoiningDateTimePicker.Name = "JoiningDateTimePicker";
            this.JoiningDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.JoiningDateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Joining Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Candidate accepted the offer?";
            // 
            // OfferAcceptedNoRadioButton
            // 
            this.OfferAcceptedNoRadioButton.AutoSize = true;
            this.OfferAcceptedNoRadioButton.Location = new System.Drawing.Point(224, 9);
            this.OfferAcceptedNoRadioButton.Name = "OfferAcceptedNoRadioButton";
            this.OfferAcceptedNoRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OfferAcceptedNoRadioButton.Size = new System.Drawing.Size(39, 17);
            this.OfferAcceptedNoRadioButton.TabIndex = 1;
            this.OfferAcceptedNoRadioButton.TabStop = true;
            this.OfferAcceptedNoRadioButton.Text = "No";
            this.OfferAcceptedNoRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OfferAcceptedNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // OfferAcceptedYesRadioButton
            // 
            this.OfferAcceptedYesRadioButton.AutoSize = true;
            this.OfferAcceptedYesRadioButton.Location = new System.Drawing.Point(157, 9);
            this.OfferAcceptedYesRadioButton.Name = "OfferAcceptedYesRadioButton";
            this.OfferAcceptedYesRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OfferAcceptedYesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.OfferAcceptedYesRadioButton.TabIndex = 0;
            this.OfferAcceptedYesRadioButton.TabStop = true;
            this.OfferAcceptedYesRadioButton.Text = "Yes";
            this.OfferAcceptedYesRadioButton.UseVisualStyleBackColor = true;
            this.OfferAcceptedYesRadioButton.CheckedChanged += new System.EventHandler(this.OfferAcceptedYesRadioButton_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(483, 286);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(72, 29);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // InterviewCompletedPanel
            // 
            this.InterviewCompletedPanel.Controls.Add(this.label4);
            this.InterviewCompletedPanel.Controls.Add(this.InterviewCompletedNoRadioButton);
            this.InterviewCompletedPanel.Controls.Add(this.InterviewCompletedYesRadioButton);
            this.InterviewCompletedPanel.Location = new System.Drawing.Point(18, 174);
            this.InterviewCompletedPanel.Name = "InterviewCompletedPanel";
            this.InterviewCompletedPanel.Size = new System.Drawing.Size(284, 35);
            this.InterviewCompletedPanel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Is interview is conducted?";
            // 
            // InterviewCompletedNoRadioButton
            // 
            this.InterviewCompletedNoRadioButton.AutoSize = true;
            this.InterviewCompletedNoRadioButton.Location = new System.Drawing.Point(224, 9);
            this.InterviewCompletedNoRadioButton.Name = "InterviewCompletedNoRadioButton";
            this.InterviewCompletedNoRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InterviewCompletedNoRadioButton.Size = new System.Drawing.Size(39, 17);
            this.InterviewCompletedNoRadioButton.TabIndex = 1;
            this.InterviewCompletedNoRadioButton.TabStop = true;
            this.InterviewCompletedNoRadioButton.Text = "No";
            this.InterviewCompletedNoRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InterviewCompletedNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // InterviewCompletedYesRadioButton
            // 
            this.InterviewCompletedYesRadioButton.AutoSize = true;
            this.InterviewCompletedYesRadioButton.Location = new System.Drawing.Point(157, 9);
            this.InterviewCompletedYesRadioButton.Name = "InterviewCompletedYesRadioButton";
            this.InterviewCompletedYesRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InterviewCompletedYesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.InterviewCompletedYesRadioButton.TabIndex = 0;
            this.InterviewCompletedYesRadioButton.TabStop = true;
            this.InterviewCompletedYesRadioButton.Text = "Yes";
            this.InterviewCompletedYesRadioButton.UseVisualStyleBackColor = true;
            this.InterviewCompletedYesRadioButton.CheckedChanged += new System.EventHandler(this.candidateSelectYesRadioButton_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(561, 286);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(72, 29);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // InterviewStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(658, 327);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.InterviewCompletedPanel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.offerAcceptedPanel);
            this.Controls.Add(this.candidateSelectedPanel);
            this.Controls.Add(this.listView1);
            this.Name = "InterviewStatus";
            this.Text = "Interview Status";
            this.Load += new System.EventHandler(this.InterviewStatus_Load);
            this.candidateSelectedPanel.ResumeLayout(false);
            this.candidateSelectedPanel.PerformLayout();
            this.offerAcceptedPanel.ResumeLayout(false);
            this.offerAcceptedPanel.PerformLayout();
            this.InterviewCompletedPanel.ResumeLayout(false);
            this.InterviewCompletedPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader JobTitle;
        private System.Windows.Forms.ColumnHeader JobDept;
        private System.Windows.Forms.ColumnHeader InterviewDate;
        private System.Windows.Forms.ColumnHeader CandidateName;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Panel candidateSelectedPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CandidateSelectedNoRadioButton;
        private System.Windows.Forms.RadioButton CandidateSelectedYesRadioButton;
        private System.Windows.Forms.Panel offerAcceptedPanel;
        private System.Windows.Forms.DateTimePicker JoiningDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton OfferAcceptedNoRadioButton;
        private System.Windows.Forms.RadioButton OfferAcceptedYesRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel InterviewCompletedPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton InterviewCompletedNoRadioButton;
        private System.Windows.Forms.RadioButton InterviewCompletedYesRadioButton;
        private System.Windows.Forms.ColumnHeader HiringManager;
        private System.Windows.Forms.Button closeButton;
    }
}