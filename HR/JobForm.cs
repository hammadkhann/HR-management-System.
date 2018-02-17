using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HrObjects;
using DataAccess;
namespace HR
{
    public partial class JobForm : Form
    {
        public JobForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void JobForm_Load(object sender, EventArgs e)
        {
            PopulateDropDown();
        }

        private void PopulateDropDown()
        {
            //Year dropDown (from 1 to 10 years)
            for (int i = 1; i < 10; i++)
                YearDropDown.Items.Add(i.ToString());

            YearDropDown.Items.Add("10+");
            YearDropDown.SelectedIndex = 0;

            var skillsEnumValues = Enum.GetValues( typeof(Skills));
            foreach (var enumValue in skillsEnumValues)
            {
                SkillDropDown.Items.Add(enumValue);
            }
            SkillDropDown.SelectedIndex = 0;

            var departmentEnumValues = Enum.GetValues(typeof(Department));
            foreach (var enumValue in departmentEnumValues)
            {
                jobDepartmentDropDown.Items.Add(enumValue);
            }
            jobDepartmentDropDown.SelectedIndex = 0;

            var Candidatetype = Enum.GetValues(typeof(EmployeeType));
            foreach (var emptype in Candidatetype)
            {
                CandidateTypeDropDown.Items.Add(emptype);
            }
            CandidateTypeDropDown.SelectedIndex = 0;

            var dm = new DataManager();

            employeeDropDown.DisplayMember = "Name";
            employeeDropDown.ValueMember = "EmployeeId";
            employeeDropDown.DataSource = dm.GetAllEmployee();            

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String skills = SkillDropDown.GetItemText(SkillDropDown.SelectedItem);
            String yearOfExperience = YearDropDown.GetItemText(YearDropDown.SelectedItem);

            ListViewItem item = new ListViewItem(skills);
            item.SubItems.Add(yearOfExperience);
            RequiredSkillsWithExperienceListView.Items.Add(item);
            //RequiredSkillsWithExperienceListView.Items.Add(skills);
            //RequiredSkillsWithExperienceListView.Items.Add(yearOfExperience);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                String jobTitle = jobTitleTextbox.Text;
                String jobDescription = jobDescriptionTextbox.Text;
                Department department;
                Enum.TryParse(jobDepartmentDropDown.Text, out department);
                EmployeeType Candidatetype;
                Enum.TryParse(CandidateTypeDropDown.Text, out Candidatetype);

                var requiredSkills = new List<SkillsWithExperience>();
                for (int i = 0; i < RequiredSkillsWithExperienceListView.Items.Count; i++)
                {
                    var lvItem = RequiredSkillsWithExperienceListView.Items[i];
                    Skills skill;
                    Enum.TryParse(lvItem.SubItems[0].Text, out skill);
                    var years = int.Parse(lvItem.SubItems[1].Text);
                    requiredSkills.Add
                        (
                            new SkillsWithExperience { Skill = skill, YearOfExperience = years }
                        );
                }

                var job = new Job
                {
                    JobPostingDate = DateTime.Now,
                    JobTitle = jobTitle,
                    JobDescription = jobDescription,
                    JobDepartment = department,
                    SkillsWithExperience = requiredSkills,
                    HiringManagerId = (int)employeeDropDown.SelectedValue,
                    CandidateType = Candidatetype
                };
                DataManager datasave = new DataManager();
                if (datasave.PublishJob(job))
                {
                    MessageBox.Show("Job posting is created successfully");
                    SaveButton.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in RequiredSkillsWithExperienceListView.Items)
                if (item.Selected)
                    RequiredSkillsWithExperienceListView.Items.Remove(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataManager dm = new DataManager();
            var postingJobs = dm.GetAllJobPosting();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CandidateTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RequiredSkillsWithExperienceListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
    
}
