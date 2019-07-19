using InterviewApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.Data.Repositories
{
    public interface IInterviewRespository
    {
        bool SaveDetails(CandiateDetails candiateDetails);
        Task<List<CandiateDetails>> GetDetails();
        CandiateDetails GetDetailsByPhoneNumber(string phonenumber);
    }
}
