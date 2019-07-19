using InterviewApp.Data.DbContext;
using InterviewApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InterviewApp.Data.Repositories
{
    public class InterviewRespository : IInterviewRespository
    {
        private readonly IInterviewDbContext _dbContext;
        public InterviewRespository(IInterviewDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<CandiateDetails>> GetDetails()
        {
            return await _dbContext.CandiateDetails.ToListAsync();
        }
        public CandiateDetails GetDetailsByPhoneNumber(string phonenumber)
        {
            return _dbContext.CandiateDetails.FirstOrDefault(x => x.PhoneNumber == phonenumber);
        }
        public bool SaveDetails(CandiateDetails candiateDetail)
        {
            var detail = _dbContext.CandiateDetails.FirstOrDefault(x => x.CandiateDetailsID == candiateDetail.CandiateDetailsID);
            if (detail != null)
                _dbContext.CandiateDetails.Add(candiateDetail);
            else
                _dbContext.CandiateDetails.Update(candiateDetail);
            return _dbContext.SaveChanges() > 0;

        }
    }
}
