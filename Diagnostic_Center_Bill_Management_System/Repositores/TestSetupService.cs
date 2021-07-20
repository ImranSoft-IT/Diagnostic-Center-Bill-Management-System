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
    public class TestSetupService : ITestSetup
    {
        private readonly AppDbContext _context;
        public TestSetupService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TestSetup>> GetTestSetup()
        {
            IEnumerable<TestSetup> TestTypeList = await _context.TestSetups.Include(d => d.TestTypeSetup).OrderBy(o=>o.TestName).ToListAsync();
            return TestTypeList;
        }

        public async Task<string> IsThisNamePresent(string Test_Name)
        {           
            return await _context.TestSetups.Where(x => x.TestName == Test_Name).Select(x => x.TestName).FirstOrDefaultAsync();           
        }

        public async Task<long> SaveTestSetup(TestSetup testSetup)
        {
            try
            {
                if (testSetup.Id != 0)
                {
                    _context.TestSetups.Update(testSetup);
                }
                else
                {
                    _context.TestSetups.Add(testSetup);
                }
                await _context.SaveChangesAsync();
                return testSetup.Id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
