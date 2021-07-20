using Diagnostic_Center_Bill_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.Interfaces
{
    public interface ITestSetup
    {
        Task<long> SaveTestSetup(TestSetup testSetup);
        Task<IEnumerable<TestSetup>> GetTestSetup();
        Task<string> IsThisNamePresent(string Test_Name);
    }
}
