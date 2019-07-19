using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InterviewApp.Data.Model
{
    public class InterviewStatus
    {
        [Key]
        public int StatusID { get; set; }
        public string Status { get; set; }
    }
}
