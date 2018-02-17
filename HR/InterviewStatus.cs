using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using HrObjects;
namespace HR
{
    public partial class InterviewStatus : Form
    {
        public int InterviewId;
        public InterviewStatus()
        {
            InitializeComponent();
        }

        private void InterviewStatus_Load(object sender, EventArgs e)
        {
            InterviewCompletedPanel.Enabled = false;
            offerAcceptedPanel.Enabled = false;
            candidateSelectedPanel.Enabled = false;
            JoiningDateTimePicker.Enabled = false;
            FillInterviews();
        }

        private void FillInterviews()
        {
            listView1.Items.Clear();
            DataManager dm = new DataManager();
            var interviews = dm.GetAllInterview();

            foreach (InterviewDetails interview in interviews)
            {
                ListViewItem item = new ListViewItem(interview.JobTitle);
                item.Tag = interview.InterviewId;
                InterviewId = interview.InterviewId;
                item.SubItems.Add(interview.Department);
                item.SubItems.Add(interview.InterviewDate);
                item.SubItems.Add(interview.CandidateName);
                item.SubItems.Add(interview.InterviewStatus);
                item.SubItems.Add(interview.HiringManager);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0].SubItems[4].Text == "Interview Scheduled")
                {
                    InterviewCompletedPanel.Enabled = true;
                }
            }
        }

        private void candidateSelectYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InterviewCompletedYesRadioButton.Checked)
            {
                candidateSelectedPanel.Enabled = true;
            }
        }

        private void CandidateSelectedYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CandidateSelectedYesRadioButton.Checked)
            {
                offerAcceptedPanel.Enabled = true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OfferAcceptedYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OfferAcceptedYesRadioButton.Checked)
            {
                JoiningDateTimePicker.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(JoiningDateTimePicker.Enabled == true)
            {
                DataManager db = new DataManager();
                if(db.HiredEmployeeSave(InterviewId, JoiningDateTimePicker.Value))
                {
                    MessageBox.Show("Employee has been hired Successfully.");
                }
            }
        }
    }
}
