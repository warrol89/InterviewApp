using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InterviewApp.Data.Model
{
    public class CandiateDetails
    {
        [Key]
        public int CandiateDetailsID { get; set; }
        public string CandiateName { get; set; }
        public string PhoneNumber { get; set; }
        public double Experience { get; set; }
        public string EmailAddress { get; set; }
        public string PreviousCompanies { get; set; }
        public string SkillSet { get; set; }
        public string StatusID { get; set; }
        public string L1Panel { get; set; }
        public string L2Panel { get; set; }
        public string Recruiter { get; set; }


    }
}
