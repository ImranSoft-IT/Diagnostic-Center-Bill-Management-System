using Diagnostic_Center_Bill_Management_System.Models;
using Diagnostic_Center_Bill_Management_System.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Diagnostic_Center_Bill_Management_System.Data
{
    public class AppDbContext : DbContext
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;
        public AppDbContext(DbContextOptions<AppDbContext> options/*, IHttpContextAccessor httpContextAccessor*/) : base(options)
        {
            //_httpContextAccessor = httpContextAccessor;
        }
        public virtual DbSet<TestTypeSetup> TestTypeSetups { get; set; }
        public virtual DbSet<TestSetup> TestSetups { get; set; }
        public virtual DbSet<TestRequest> TestRequests { get; set; }
        //public virtual DbQuery<TestReportViewModel> TestReports { get; set; }
        //public virtual DbQuery<TestTypeReportViewModel> TestTypeReports { get; set; }

        
    }
}
