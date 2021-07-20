using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.ViewModel
{
    public class TestReportViewModel
    {
        //[Key]
        public int TestSetupId { set; get; }
        public string TestName { set; get; }
        public int TotalTest { set; get; }
        public decimal TotalAmount { set; get; }
    }
}
