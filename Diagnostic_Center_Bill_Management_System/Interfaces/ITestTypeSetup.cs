using Diagnostic_Center_Bill_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.Interfaces
{
    public interface ITestTypeSetup
    {
        Task<long> SaveTestType(TestTypeSetup testType);
        Task<IEnumerable<TestTypeSetup>> GetTestType();
        Task<string> IsThisNamePresent(string TestType_Name);
    }
}
