using Diagnostic_Center_Bill_Management_System.Data;
using Diagnostic_Center_Bill_Management_System.Interfaces;
using Diagnostic_Center_Bill_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.Repositores
{
    public class TestTypeSetupService : ITestTypeSetup
    {
        private readonly AppDbContext _context;
        public TestTypeSetupService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TestTypeSetup>> GetTestType()
        {
            IEnumerable<TestTypeSetup> TestTypeList = await _context.TestTypeSetups.OrderBy(d=>d.TestType_Name).ToListAsync();
            return TestTypeList;
        }

        public async Task<long> SaveTestType(TestTypeSetup testType)
        {
            try
            {
                if (testType.Id != 0)
                {
                   _context.TestTypeSetups.Update(testType);
                }
                else
                {
                    _context.TestTypeSetups.Add(testType);
                }
                await _context.SaveChangesAsync();
                return testType.Id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<string> IsThisNamePresent(string TestType_Name)
        {
            return await _context.TestTypeSetups.Where(x => x.TestType_Name == TestType_Name).Select(x => x.TestType_Name).FirstOrDefaultAsync();
        }


    }
}
