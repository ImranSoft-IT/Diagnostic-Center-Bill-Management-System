using Diagnostic_Center_Bill_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.ViewModel
{
    public class TestSetupViewModel
    {
        public long Id { set; get; }
        public string TestName { set; get; }
        public float? TestFee { set; get; }
        public long? Slno { set; get; }
        public long? TestTypeSetupId { set; get; }
        public IEnumerable<TestTypeSetup> testTypes { get; set; }
        public IEnumerable<TestSetup>  testSetups { get; set; }
    }
}
