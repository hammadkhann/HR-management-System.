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
    public partial class ScheuleInterview : Form
    {

        List<InterviewSchedule> interViewSchedulle = new List<InterviewSchedule>();
        List<Candidate> allCandidates = new List<Candidate>();
        int CurrentcandidateId, CurrentjobpostingId,CurrentEmployeeId;         

        public ScheuleInterview()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                var item = listView2.SelectedItems[0];
                CurrentcandidateId = (int)item.Tag;
            }
        }

        private void Employee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                var item = listView1.SelectedItems[0];
                CurrentjobpostingId = (int)item.Tag;
                FillCandidate(CurrentjobpostingId);
            }
        }

        private void ScheuleInterview_Load(object sender, EventArgs e)
        {
            FillAllJobs();
             
            SchedulePanel.Enabled = false;
        }

        private void FillCandidate(int jobPostingId)
        {
            listView2.Items.Clear();

            foreach (Candidate oneCandidate in allCandidates.Where(x=> x.JobPostingId == jobPostingId))
            {
                ListViewItem item = new ListViewItem(oneCandidate.FirstName);
                item.Tag = oneCandidate.CandidateId;                
                item.SubItems.Add(oneCandidate.LastName);
                item.SubItems.Add(oneCandidate.Status);
                listView2.Items.Add(item);
            }
        }

        private void FillAllJobs()
        {
            listView1.Items.Clear();

            DataManager dataMgr = new DataManager();
            List<Job> AllJobs = dataMgr.GetAllJobPosting();

            allCandidates = dataMgr.GetAllCandiates();

            foreach(Job OneJob in AllJobs)
            {
                ListViewItem item = new ListViewItem(OneJob.JobTitle);
                item.Tag = OneJob.JobPostingId;
                item.SubItems.Add(OneJob.JobDescription);
                item.SubItems.Add(OneJob.Status);
                item.SubItems.Add(OneJob.HiringManager);
                listView1.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView2.SelectedItems.Count > 0)
            {
                var item = listView2.SelectedItems[0];
                if (item.SubItems[2].Text == "Interview Scheduled")
                {
                    MessageBox.Show("Interview is already scheduled for this candidate");
                    return;
                }

                if (listView1.SelectedItems.Count > 0 &&
                listView1.SelectedItems[0].SubItems[2].Text == "Interview Scheduled")
                {
                    MessageBox.Show("Interview is already scheduled for this job");
                    return;
                }

                SchedulePanel.Enabled = true;
                SetAllData();
            }
            else
            {
                MessageBox.Show("Please select Candidate first.");
            }
        }
        private void SetAllData()
        {
            DataManager dataMgr = new DataManager();
            List<Employee> AllEmployees = dataMgr.GetAllEmployee();

            EmployeeDropDown.DisplayMember = "Name";
            EmployeeDropDown.ValueMember = "EmployeeId";
            EmployeeDropDown.DataSource = AllEmployees;
            
             
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var interviewDate = dateTimePicker2.Value;
            Interview interView = new Interview
            {
                JobPostingId = CurrentjobpostingId,
                CandidateId = CurrentcandidateId,
                InterviewDate = interviewDate,
                InterviewSchedules = interViewSchedulle
            };
            DataManager db = new DataManager();
            if(db.SetInterviewSchedule(interView))
            {
                MessageBox.Show("Interview Scheduled successfully.");
            }

            FillAllJobs();
            FillCandidate(CurrentjobpostingId);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var startfrom = dateTimePicker1.Value.TimeOfDay;
            var endto = dateTimePicker3.Value.TimeOfDay;
            var date = dateTimePicker2.Value.ToShortDateString();
            int employeeId = (int) EmployeeDropDown.SelectedValue;

            String employee = EmployeeDropDown.Text;            
            
            interViewSchedulle.Add
                    (
                    new InterviewSchedule
                    {
                        InterviewerId = employeeId,                        
                        InterviewStartTime = DateTime.Parse(startfrom.ToString()),
                        InterviewEndTime = DateTime.Parse(endto.ToString())
                    }
                    );            
            
            ListViewItem item = new ListViewItem(employee);
            item.SubItems.Add(date.ToString());
            item.SubItems.Add(startfrom.ToString());
            item.SubItems.Add(endto.ToString());


            listView3.Items.Add(item);
        }

        private void DeleteButon_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView3.Items)
                if (item.Selected)
                    listView3.Items.Remove(item);
        }
    }
}
