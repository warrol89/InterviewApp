using System;
using System.Collections.Generic;
using System.Text;
using InterviewApp.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace InterviewApp.Data.DbContext
{
    public class InterviewDbContext: Microsoft.EntityFrameworkCore.DbContext,IInterviewDbContext
    {
        private readonly string _invConnString;

        public InterviewDbContext(string connString)
        {
            _invConnString = connString;
        }
        public InterviewDbContext(DbContextOptions<InterviewDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(_invConnString))
                optionsBuilder.UseSqlServer(_invConnString);
        }
        public virtual DbSet<CandiateDetails> CandiateDetails { get; set; }
        public virtual DbSet<InterviewStatus> InterviewStatus { get; set; }
    }
}
