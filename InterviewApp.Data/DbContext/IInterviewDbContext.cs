using System;
using System.Collections.Generic;
using System.Text;
using InterviewApp.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace InterviewApp.Data.DbContext
{
    public interface IInterviewDbContext
    {
        DbSet<CandiateDetails> CandiateDetails { get; set; }
        DbSet<InterviewStatus> InterviewStatus { get; set; }
        int SaveChanges();
    }
}

