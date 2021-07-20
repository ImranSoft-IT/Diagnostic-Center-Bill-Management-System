using Diagnostic_Center_Bill_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.ViewModel
{
    public class TestRequestViewModel
    {
        public long[] Id { set; get; }
        public string[] Bill_Number { set; get; }
        public string[] PatientName { set; get; }
        public DateTime?[] DOB { set; get; }
        public long[] MobileNo { set; get; }
        public long?[] TestSetupId { set; get; }
        public float?[] ReqTestFee { set; get; }
        public DateTime?[] EntryDate { set; get; }
        public IEnumerable<TestTypeSetup> testTypes { get; set; }
        public IEnumerable<TestSetup>  testSetups { get; set; }
        public IEnumerable<TestRequest> testRequests { get; set; }
    }


}
