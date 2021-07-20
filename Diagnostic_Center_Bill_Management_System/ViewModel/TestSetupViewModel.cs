using Diagnostic_Center_Bill_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.ViewModel
{
    public class TestTypeViewModel
    {
        public long Id { set; get; }
        public string TestType_Name { set; get; }
        public long? Slno { set; get; }
        public IEnumerable<TestTypeSetup> testTypes { get; set; }
    }
}
