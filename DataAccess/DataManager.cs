using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrObjects;
using System.Data.SqlClient;
using System.Data;
namespace DataAccess
{
    public class DataManager
    {

        public SqlConnection GetConnection()
        {
            return new SqlConnection("Server=(local); Initial Catalog=HR; user id= sa; password=hello123;");
        }

        public bool PublishJob(Job jobObject)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Skill");
            table.Columns.Add("YearsOfExperience", typeof(int));

            try
            {
                foreach (var skill in jobObject.SkillsWithExperience)
                {
                    var row = table.NewRow();
                    row[0] = skill.Skill;
                    row[1] = skill.YearOfExperience;
                    table.Rows.Add(row);
                }

                using (var conn = GetConnection())
                {
                    var comm = new SqlCommand("dbo.uspJobPosting_Save", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlParameter PostingDateParam = new SqlParameter("PostingDate", jobObject.JobPostingDate);
                    SqlParameter JobTitleParam = new SqlParameter("JobTitle", jobObject.JobTitle);
                    SqlParameter JobDescriptionParam = new SqlParameter("JobDescription", jobObject.JobDescription);
                    SqlParameter DepartmentParam = new SqlParameter("Department", jobObject.JobDepartment.ToString());
                    SqlParameter HiringManagerIdParam = new SqlParameter("HiringManagerId", jobObject.HiringManagerId);
                    SqlParameter CandidateTypeParam = new SqlParameter("Candidatetype", jobObject.CandidateType.ToString());
                    SqlParameter SkillsSetsParam = new SqlParameter("@SkillsSets", SqlDbType.Structured);
                    SkillsSetsParam.Value = table;

                    comm.Parameters.Add(PostingDateParam);
                    comm.Parameters.Add(JobTitleParam);
                    comm.Parameters.Add(JobDescriptionParam);
                    comm.Parameters.Add(DepartmentParam);
                    comm.Parameters.Add(HiringManagerIdParam);
                    comm.Parameters.Add(CandidateTypeParam);
                    comm.Parameters.Add(SkillsSetsParam);

                    comm.ExecuteNonQuery();

                    comm = new SqlCommand("dbo.RandomCandidateAppliedForJob", conn);
                    comm.CommandType  = CommandType.StoredProcedure;
                    comm.ExecuteNonQuery();


                }
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public List<Job> GetAllJobPosting()
        {

            List<Job> jobPosting = new List<Job>();

            using (var conn = GetConnection())
            {
                var comm = new SqlCommand("dbo.uspJobPosting_Get", conn);
                comm.CommandType = CommandType.StoredProcedure;
                conn.Open();

                using (var dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Department dept;
                        Enum.TryParse(dr["JobDepartment"].ToString(), out dept);
                        var job = new Job
                        {
                            JobTitle = dr["JobTitle"].ToString(),
                            JobDescription = dr["JobDescription"].ToString(),
                            JobDepartment = dept,
                            JobPostingId = int.Parse(dr["JobPostingId"].ToString()),
                            Status = dr["Status"].ToString(),
                            HiringManager = dr["HiringManager"].ToString()
                        };

                        jobPosting.Add(job);
                    }
                }

                return jobPosting;
            }
        }
        public List<Candidate> GetAllCandiates()
        {
            List<Candidate> jobPosting = new List<Candidate>();

            using (var conn = GetConnection())
            {
                var comm = new SqlCommand("dbo.uspGet_AllCandidates", conn);
                comm.CommandType = CommandType.StoredProcedure;
                conn.Open();

                using (var dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var job = new Candidate { 
                            FirstName = dr["CandidateFirstName"].ToString(),
                            LastName = dr["CandidateLastName"].ToString(),
                            JobPostingId = int.Parse(dr["JobPostingId"].ToString()),
                            Status = dr["Status"].ToString(),
                            CandidateId = int.Parse(dr["CandidateId"].ToString())
                            //PhoneNumber = dr["CandidatePhoneNumber"].ToString(),
                            //ResumeFilePath = dr["CandidateResumeFilePath"].ToString()
                        };

                        jobPosting.Add(job);
                    }
                }
                return jobPosting;
            }
        }
        public List<Employee> GetAllEmployee()
        {
            List<Employee> AllEmployees = new List<Employee>();

            using (var conn = GetConnection())
            {
                var comm = new SqlCommand("dbo.uspGet_AllEmployees", conn);
                comm.CommandType = CommandType.StoredProcedure;
                conn.Open();

                using (var dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var employee = new Employee { 
                        EmployeeId = (int)dr["EmployeeId"],
                        FirstName = dr["EmployeeFirstName"].ToString(),
                        LastName = dr["EmployeeLastName"].ToString()

                        };

                        AllEmployees.Add(employee);                        
                    }
                }
                return AllEmployees;
            }
        }
        public bool SetInterviewSchedule(Interview interviewObject)
        {
            DataTable table = new DataTable();            
            table.Columns.Add("EmployeeId",typeof(int));
            table.Columns.Add("InterviewStartTime",typeof(DateTime));
            table.Columns.Add("InterviewEndTime",typeof(DateTime));

            foreach (var interview in interviewObject.InterviewSchedules)
            {
                var row = table.NewRow();                
                row[0] = interview.InterviewerId;
                row[1] = interview.InterviewStartTime;
                row[2] = interview.InterviewEndTime;
                table.Rows.Add(row);
            }
            try
            {
                using (var conn = GetConnection())
                {
                    var comm = new SqlCommand("dbo.uspInterviewDate_Save", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlParameter JobPostingIdParam = new SqlParameter("JobPostingId", interviewObject.JobPostingId);
                    SqlParameter CandidateIdParam = new SqlParameter("CandidateId", interviewObject.CandidateId);
                    SqlParameter InterviewDateParam = new SqlParameter("InterviewDate", interviewObject.InterviewDate);
                    SqlParameter InterviewerParam = new SqlParameter("@InterViewer", SqlDbType.Structured);
                    InterviewerParam.Value = table;

                    comm.Parameters.Add(JobPostingIdParam);
                    comm.Parameters.Add(CandidateIdParam);
                    comm.Parameters.Add(InterviewDateParam);
                    comm.Parameters.Add(InterviewerParam);
                    comm.ExecuteNonQuery();
                    
                }
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public List<InterviewDetails> GetAllInterview()
        {
            List<InterviewDetails> allInterviews = new List<InterviewDetails>();
             using (var conn = GetConnection())
            {
                var comm = new SqlCommand("dbo.uspInterview_Get", conn);
                comm.CommandType = CommandType.StoredProcedure;
                conn.Open();

                using (var dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var interview = new InterviewDetails 
                        {                             
                            JobTitle = dr["JobTitle"].ToString(),
                            Department = dr["JobDepartment"].ToString(),
                            CandidateName = dr["CandidateName"].ToString(),
                            HiringManager =dr["HiringManager"].ToString(),
                            InterviewDate = dr["Interviewdate"].ToString(),
                            InterviewStatus = dr["InterviewStatus"].ToString(),
                            InterviewId = (int)dr["InterviewId"]
                        };

                        allInterviews.Add(interview);                        
                    }
                }
                return allInterviews;
            }
        }
        public bool HiredEmployeeSave(int Interviewid,DateTime hiringdate)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    var comm = new SqlCommand("dbo.uspSaveNewEmployee", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlParameter InterviewIdParam = new SqlParameter("InterviewId", Interviewid);
                    SqlParameter HiringDateParam = new SqlParameter("HiringDate", hiringdate);                    

                    comm.Parameters.Add(InterviewIdParam);
                    comm.Parameters.Add(HiringDateParam);
                    comm.ExecuteNonQuery();
                }
                return true;
            }

            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
